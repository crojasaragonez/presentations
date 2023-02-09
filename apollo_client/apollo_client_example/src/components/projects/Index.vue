<template>
  <div class="container mx-auto mt-3">
    <div class="flex justify-between">
      <h1 class="text-3xl font-bold">
        Projects
        <font-awesome-icon
          v-if="$apollo.queries.projects.loading"
          class="animate-spin"
          icon="fa-solid fa-spinner"
        />
      </h1>
      <input
        class="border text-sm rounded-lg p-2.5 focus:border-teal-500 focus:outline-none"
        type="search"
        name="name"
        v-model="name"
        placeholder="Filter by name"
        autofocus
      />
    </div>
    <template v-if="projects">
      <Row
        :key="project.id"
        :project="project"
        v-for="project in projects.data"
        @projectUpdated="projectUpdated"
      ></Row>
    </template>
  </div>
</template>
<script setup lang="ts">
import Row from "./Row.vue";
import PROJECTS_QUERY from "./query";
import UPDATE_PROJECT from "./mutation";
import type { Project, ProjectResponse } from "./Interfaces";
</script>
<script lang="ts">
export default {
  data() {
    return {
      name: "",
      projects: {} as ProjectResponse,
    };
  },
  apollo: {
    projects: {
      query: PROJECTS_QUERY,
      variables() {
        return this.name.trim() === "" ? {} : { name: `%${this.name}%` };
      },
    },
  },
  methods: {
    buildRequest(delta: Project) {
      const { start_date, end_date, name, description, state } = delta;
      return {
        start_date,
        end_date,
        name,
        description,
        state,
        technologies: {
          sync: (delta.technologies || []).map((t) => t.id),
        },
        members: {
          delete: (delta.dispose.members || []).map((uid) => uid),
        },
      };
    },
    projectUpdated(delta: Project) {
      this.$apollo
        .mutate({
          mutation: UPDATE_PROJECT,
          variables: {
            id: delta.id,
            project: this.buildRequest(delta),
          },
        })
        .then(() => {
          this.$apollo.queries.projects.refetch();
        });
    },
  },
};
</script>
