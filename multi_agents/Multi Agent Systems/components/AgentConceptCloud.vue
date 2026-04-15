<script setup lang="ts">
/** Weighted labels for an informal word cloud (no layout algorithm — stable export). */
const tags = [
  { text: 'LLMs', class: 'text-3xl font-bold -rotate-1' },
  { text: 'Prompt', class: 'text-2xl rotate-2' },
  { text: 'SLMs', class: 'text-xl -rotate-2 opacity-90' },
  { text: 'Observability', class: 'text-lg opacity-90' },
  { text: 'MCP', class: 'text-3xl font-bold rotate-2' },
  { text: 'Explainability', class: 'text-lg opacity-90 -rotate-1' },
  { text: 'Human-in-the-loop', class: 'text-base opacity-90 rotate-1' },
  { text: 'Agent', class: 'text-3xl font-bold rotate-1' },
  { text: 'Autonomous', class: 'text-lg' },
  { text: 'Semi-autonomous', class: 'text-base font-bold opacity-90' },
  { text: 'Short-term memory', class: 'text-sm opacity-85' },
  { text: 'Long-term memory', class: 'text-sm opacity-85 -rotate-1' },
  { text: 'Asynchronous', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Synchronous', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Guardrails', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Tokens', class: 'text-2xl' },
  { text: 'Sandboxing', class: 'text-lg opacity-90 rotate-1' },
  { text: 'System prompt', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Zero-shot prompting', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Finetuning', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Few-shot prompting', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Chain of thought', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Multi-Agents', class: 'text-2xl -rotate-1' },
  { text: 'Structured prompting', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Prompt injection', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Inference', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Caching', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Embeddings', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Voice agents', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Agentic frameworks', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Vector databases', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Vector DBs', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Hallucination', class: 'text-lg opacity-90 rotate-1' },
  { text: 'RAG', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Temperature', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Infinite loops', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Context window', class: 'text-lg opacity-90 rotate-1' },
  { text: 'Data pipelines', class: 'text-lg opacity-90 rotate-1' },
  { text: 'State machines', class: 'text-lg opacity-90 rotate-1' },
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
