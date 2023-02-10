<template>
  <div class="flex flex-col">
    <details>
      <summary class="block cursor-pointer">
        <div class="py-2">
          <h1 class="text-2xl font-bold">Queries and Mutations</h1>
          <h3>Queries read data and Mutations write data in the database.</h3>
        </div>
      </summary>
      <div class="flex">
        <pre class="justify-between pr-10">
          <code class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white">
query {
  projects(name: "Project 1") {
    paginatorInfo {
      hasMorePages
    }
    data {
      id
      name
    }
  }
}</code>
        </pre>
        <pre>
          <code class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white">
mutation {
  updateProject(id: 1, input: {name: "New Name"}) {
    id
    name
  }
}</code>
        </pre>
      </div>
    </details>
    <hr />
    <details>
      <summary class="block cursor-pointer">
        <div class="py-2">
          <h1 class="text-2xl font-bold">Variables</h1>
          <h3>
            They allow you pass diferent values to the same query/mutation.
          </h3>
        </div>
      </summary>
      <pre>
          <code class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white">
query (<span class="font-bold text-teal-500">$name: String</span>) {
  projects(name: <span class="font-bold text-teal-500">$name</span>) {
    paginatorInfo {
      hasMorePages
    }
    data {
      id
      name
    }
  }
}</code>
        </pre>
    </details>
    <hr />
    <details>
      <summary class="block cursor-pointer">
        <div class="py-2">
          <h1 class="text-2xl font-bold">Inputs</h1>
          <h3>
            Building objects instead of passing a huge list of individual
            parameters.
          </h3>
        </div>
      </summary>
      <pre>
          <code class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white">
mutation ($id: ID!, $project: <span class="font-bold text-teal-500">ProjectInput!</span>) {
  updateProject(id: $id, input: $project) {
    id
    name
  }
}</code>
        </pre>
    </details>
    <hr />
    <details>
      <summary class="block cursor-pointer">
        <div class="py-2">
          <h1 class="text-2xl font-bold">Fragments</h1>
          <h3>
            <span class="cursor-help" title="Don't repeat yourself"
              >DRY principle?</span
            >
            no problem
          </h3>
        </div>
      </summary>
      <pre>
          <code class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white">
import gql from 'graphql-tag';
<span class="font-bold text-teal-500">
const PROJECT_FRAGMENT = gql`
  fragment project on Project {
    id
    name
  }
`;
</span>
const query = gql`
  query ($name: String) {
    projects(name: $name) {
      paginatorInfo {
        hasMorePages
      }
      data {
        <span class="font-bold text-teal-500">...project</span>
      }
    }
  }
`;
<span class="font-bold text-teal-500">${PROJECT_FRAGMENT}</span>
      </code>
    </pre>
    </details>
    <hr />
    <details>
      <summary class="block cursor-pointer">
        <div class="py-2">
          <h1 class="text-2xl font-bold">Aliases</h1>
          <h3>
            Renaming existing queries and/or fields for readability purposes.
          </h3>
        </div>
      </summary>
      <pre>
      <code class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white">
query {
  <span class="font-bold text-teal-500">internal_projects:</span> projects(is_internal: true) {
    paginatorInfo {
      hasMorePages
    }
    data {
      id
      name
    }
  }
}</code>
</pre>
    </details>
  </div>
</template>
