<template>
  <div>
    <hr class="h-px my-8 bg-teal-500 border-0" />
    <h1 class="text-2xl font-bold">{{ localProject.name }}</h1>
    <div class="flex justify-between">
      <h3 class="font-bold">
        From:
        <input
          type="date"
          class="bg-transparent p-2.5 focus:outline-none focus-visible:outline-none"
          v-model="localProject.start_date"
        />
        To:
        <input
          type="date"
          class="bg-transparent p-2.5 focus:outline-none focus-visible:outline-none"
          v-model="localProject.end_date"
        />
      </h3>
      <div class="flex mb-2">
        <h3 class="p-2.5">State:</h3>
        <select
          class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
          v-model="localProject.state"
        >
          <option>Draft</option>
          <option>In Progress</option>
          <option>On Hold</option>
          <option>Cancelled</option>
          <option>Completed</option>
        </select>
      </div>
    </div>
    <textarea
      rows="4"
      class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
      v-model="localProject.description"
    ></textarea>
    <h3 class="font-bold">Members:</h3>
    <div class="flex flex-wrap pb-2" v-auto-animate>
      <div
        :key="`m-${member.id}`"
        class="flex px-3 py-1 mr-2 text-teal-500 border-2 border-teal-500 rounded-xl mt-1"
        v-for="member in localProject.members"
      >
        {{ member.user.name }}
        <ConfirmDelete
          :uid="member.id"
          @kill="(uid) => itemRemoved(uid, 'members')"
        ></ConfirmDelete>
      </div>
    </div>
    <h3 class="font-bold">Technologies:</h3>
    <TechnologyPicker @technologyAdded="technologyAdded"></TechnologyPicker>
    <div class="flex flex-wrap pb-2" v-auto-animate>
      <div
        :key="`t-${technology.id}`"
        class="flex px-3 py-1 mr-2 text-teal-500 border-2 border-teal-500 rounded-xl"
        v-for="technology in localProject.technologies"
      >
        {{ technology.name }}
        <ConfirmDelete
          :uid="technology.id"
          @kill="(uid) => itemRemoved(uid, 'technologies')"
        ></ConfirmDelete>
      </div>
    </div>
    <div v-auto-animate>
      <div class="flex gap-1" v-if="!hideAction">
        <button
          class="bg-gray-400 hover:bg-gray-500 text-white py-1 px-4 rounded-xl"
          @click="projectUpdated"
        >
          Confirm
        </button>
        <button
          class="bg-red-500 hover:bg-red-700 text-white py-1 px-4 rounded-xl"
          @click="reset"
        >
          Cancel
        </button>
      </div>
    </div>
  </div>
</template>
<script setup lang="ts">
import ConfirmDelete from "../shared/ConfirmDelete.vue";
import TechnologyPicker from "../technologies/Picker.vue";
import type { Project, IdName } from "../projects/Interfaces";
</script>

<script lang="ts">
export default {
  props: ["project"],
  data() {
    return {
      localProject: structuredClone({
        dispose: { members: [], technologies: [] },
        ...this.project,
      }),
    };
  },
  computed: {
    hideAction() {
      return (
        this.localProject.description === this.project.description &&
        this.localProject.start_date === this.project.start_date &&
        this.localProject.end_date === this.project.end_date &&
        this.localProject.state === this.project.state &&
        JSON.stringify(this.localProject.members) ==
          JSON.stringify(this.project.members) &&
        JSON.stringify(this.localProject.technologies) ==
          JSON.stringify(this.project.technologies)
      );
    },
  },
  methods: {
    reset() {
      this.localProject = structuredClone({
        dispose: { members: [], technologies: [] },
        ...this.project,
      });
    },
    technologyAdded(technology: IdName) {
      this.localProject.technologies.push(technology);
    },
    projectUpdated() {
      this.$emit("projectUpdated", this.localProject);
    },
    itemRemoved(uid: string, key: string) {
      this.localProject[key] = this.localProject[key].filter(
        (t: Project) => t.id !== uid
      );
      this.localProject.dispose[key].push(uid);
    },
  },
};
</script>
