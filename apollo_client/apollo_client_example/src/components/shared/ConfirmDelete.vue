<template>
  <div>
    <span
      v-if="!is_confirming"
      class="font-bold cursor-pointer bg-teal-500 text-white ml-2 px-2 rounded-full"
      @click="is_confirming = true"
    >
      <font-awesome-icon icon="fa-solid fa-xmark" />
    </span>
    <span
      v-if="is_confirming"
      class="font-bold cursor-pointer ml-2 text-green-500"
      @click="$emit('kill', uid)"
    >
      <font-awesome-icon icon="fa-solid fa-check" />
    </span>
    <span
      v-if="is_confirming"
      class="font-bold cursor-pointer ml-2 text-red-500"
      @click="is_confirming = false"
      ><font-awesome-icon icon="fa-solid fa-xmark"
    /></span>
  </div>
</template>

<script lang="ts">
export default {
  props: ["uid"],
  data() {
    return { is_confirming: false };
  },
};
</script>
