<script setup lang="ts">
/** Términos que deben resaltarse frente al resto (estilo discreto). */
const PROMINENT = new Set([
  'LLM',
  'Agent',
  'Tokens',
  'Multi-Agents',
  'Prompt',
  'Context',
  'Agentic frameworks',
  'Hallucination',
])

const tags = [
  'LLM',
  'SLMs',
  'Observability',
  'MCP',
  'Explainability',
  'Human-in-the-loop',
  'Autonomous',
  'Agent',
  'Semi-autonomous',
  'Prompt',
  'Short-term memory',
  'Long-term memory',
  'Asynchronous',
  'Synchronous',
  'Guardrails',
  'Sandboxing',
  'System prompt',
  'Tokens',
  'Zero-shot prompting',
  'Finetuning',
  'Context',
  'Multi-Agents',
  'Few-shot prompting',
  'Chain of thought',
  'Structured prompting',
  'Prompt injection',
  'Inference',
  'Caching',
  'Embeddings',
  'Voice agents',
  'Agentic frameworks',
  'Vectors',
  'Vector DBs',
  'Hallucination',
  'RAG',
  'Temperature',
  'Infinite loops',
  'Data pipelines',
  'State machines',
  'Agent role',
] as const

function classesFor(text: string) {
  if (PROMINENT.has(text)) {
    // Legible en fondo claro; `dark:` alinea con slides oscuros (p. ej. seriph por defecto)
    return 'text-3xl sm:text-4xl font-bold text-slate-900 dark:text-white drop-shadow-sm dark:drop-shadow-sm'
  }
  return 'text-[11px] sm:text-sm font-normal text-slate-500 dark:text-white/75'
}
</script>

<template>
  <div
    class="mx-auto mt-4 max-w-5xl flex flex-wrap justify-center gap-x-3 gap-y-2 sm:gap-x-4 sm:gap-y-3 content-center px-2 text-center leading-tight"
    aria-label="Conceptos relacionados con agentes de IA"
  >
    <span
      v-for="text in tags"
      :key="text"
      :class="['inline-block tracking-tight', classesFor(text)]"
    >
      {{ text }}
    </span>
  </div>
</template>
