<template>
  <input
    class="border text-sm rounded-lg p-2.5 my-2 focus:border-teal-500 focus:outline-none"
    type="search"
    list="technologies"
    v-model="technology"
    @change="selected"
    placeholder="Search Technology here"
  />
  <datalist id="technologies">
    <option
      :key="tech.id"
      v-for="tech in technologies"
      :value="tech.name"
    ></option>
  </datalist>
</template>
<script setup lang="ts">
import TECHNOLOGIES_QUERY from "./query";
import type { IdName } from "../projects/Interfaces";
</script>
<script lang="ts">
export default {
  emits: ["technologyAdded"],
  apollo: {
    technologies: {
      query: TECHNOLOGIES_QUERY,
    },
  },
  data() {
    return { technology: "", technologies: [] as IdName[] };
  },
  methods: {
    selected() {
      this.$emit(
        "technologyAdded",
        this.technologies.find((d: IdName) => d.name === this.technology)
      );
      this.technology = "";
    },
  },
};
</script>
