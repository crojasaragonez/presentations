<template>
  <aside class="pr-2">
    <div class="rounded-2xl bg-slate-900/90 p-6 text-white shadow-xl ring-1 ring-white/10">
      <div class="text-sm font-semibold uppercase tracking-widest opacity-70">
        Ciclo del agente
      </div>

      <div class="mt-6 space-y-4 text-xl">
        <div v-for="step in steps" :key="step.title">
          <div class="font-bold">{{ step.title }}</div>
          <div class="text-sm opacity-75">{{ step.description }}</div>
        </div>
      </div>

      <div class="mt-6 rounded-lg bg-white/10 p-4 text-sm leading-relaxed">
        La diferencia está en sostener el objetivo mientras toma decisiones.
      </div>
    </div>
  </aside>
</template>

<script setup lang="ts">
const steps = [
  {
    title: '1. Interpreta',
    description: 'Qué se necesita realmente.',
  },
  {
    title: '2. Planifica',
    description: 'Qué estrategia conviene.',
  },
  {
    title: '3. Actúa',
    description: 'Qué pasos ejecutar y con qué recursos.',
  },
  {
    title: '4. Ajusta',
    description: 'Qué cambia según el resultado.',
  },
] as const
</script>
