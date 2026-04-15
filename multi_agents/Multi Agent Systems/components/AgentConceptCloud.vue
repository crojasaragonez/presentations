<script setup lang="ts">
/** Weighted labels for an informal word cloud (no layout algorithm — stable export). */
const tags = [
  { text: 'LLM', class: 'text-3xl font-bold -rotate-1' },
  { text: 'Agent', class: 'text-4xl font-bold rotate-1' },
  { text: 'Tokens', class: 'text-2xl font-semibold' },
  { text: 'Prompt', class: 'text-2xl rotate-2' },
  { text: 'SLM', class: 'text-xl -rotate-2 opacity-90' },
  { text: 'Multi-Agents', class: 'text-2xl font-semibold -rotate-1' },
  { text: 'MCP', class: 'text-3xl font-bold rotate-2' },
  { text: 'Observability', class: 'text-lg opacity-90' },
  { text: 'Explainability', class: 'text-lg opacity-90 -rotate-1' },
  { text: 'Human-in-the-loop', class: 'text-base opacity-90 rotate-1' },
  { text: 'Autonomous', class: 'text-xl font-medium' },
  { text: 'Semi-autonomous', class: 'text-base opacity-90' },
  { text: 'Short-term memory', class: 'text-sm opacity-85' },
  { text: 'Long-term memory', class: 'text-sm opacity-85 -rotate-1' },
  { text: 'Asynchronous', class: 'text-lg opacity-90 rotate-1' },
] as const
</script>

<template>
  <div
    class="mx-auto mt-4 max-w-5xl flex flex-wrap justify-center gap-x-4 gap-y-3 content-center px-2 text-center leading-tight"
    aria-label="Conceptos relacionados con agentes de IA"
  >
    <span
      v-for="tag in tags"
      :key="tag.text"
      :class="['inline-block tracking-tight', tag.class]"
    >
      {{ tag.text }}
    </span>
  </div>
</template>
