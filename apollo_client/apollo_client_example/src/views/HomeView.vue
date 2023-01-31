<script setup lang="ts">
import AgendaSlide from "../components/slides/AgendaSlide.vue";
import WhySlide from "../components/slides/WhySlide.vue";
import ConceptsSlide from "../components/slides/ConceptsSlide.vue";
import BackendSlide from "../components/slides/BackendSlide.vue";
import DemoSlide from "../components/slides/DemoSlide.vue";
import QuestionsSlide from "../components/slides/QuestionsSlide.vue";
import TitleSlide from "../components/slides/TitleSlide.vue";
</script>

<template>
  <main class="flex h-screen justify-center items-center">
    <TitleSlide v-if="slide === 'title'"></TitleSlide>
    <AgendaSlide v-if="slide === 'agenda'"></AgendaSlide>
    <WhySlide v-if="slide === 'why'"></WhySlide>
    <ConceptsSlide v-if="slide === 'concepts'"></ConceptsSlide>
    <BackendSlide v-if="slide === 'backend'"></BackendSlide>
    <DemoSlide v-if="slide === 'demo'"></DemoSlide>
    <QuestionsSlide v-if="slide === 'questions'"></QuestionsSlide>
  </main>
  <div class="flex justify-center absolute inset-x-0 bottom-0 h-16">
    <nav>
      <a
        class="font-medium text-blue-600 dark:text-blue-500 hover:underline px-2"
        href="#agenda"
        @click="slide = 'agenda'"
        >Agenda</a
      >
      <a
        class="font-medium text-blue-600 dark:text-blue-500 hover:underline px-2"
        href="#why"
        @click="slide = 'why'"
        >Why Apollo</a
      >
      <a
        class="font-medium text-blue-600 dark:text-blue-500 hover:underline px-2"
        href="#concepts"
        @click="slide = 'concepts'"
        >Theoretical Concepts</a
      >
      <a
        class="font-medium text-blue-600 dark:text-blue-500 hover:underline px-2"
        href="#backend"
        @click="slide = 'backend'"
        >Backend Description</a
      >
      <a
        class="font-medium text-blue-600 dark:text-blue-500 hover:underline px-2"
        href="#demo"
        @click="slide = 'demo'"
        >Demo</a
      >
      <a
        class="font-medium text-blue-600 dark:text-blue-500 hover:underline px-2"
        href="#questions"
        @click="slide = 'questions'"
        >Q&A Session</a
      >
    </nav>
  </div>
</template>

<script lang="ts">
export default {
  data() {
    return { slide: "title" };
  },
  computed: {
    showRoute() {
      return this.$route.name !== "home";
    },
  },
};
</script>
