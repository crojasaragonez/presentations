<script setup lang="ts">
/** Peaks in SVG coordinates (viewBox height = 200); lower Y = taller mountain. */
const levels = [
  {
    level: 0,
    label: 'Level 0',
    description: 'Use of AI is explicitly prohibited.',
    peakY: 168,
    fillClass: 'fill-slate-400/80 dark:fill-slate-600/65',
  },
  {
    level: 1,
    label: 'Level 1',
    description:
      'Individual productivity: generative AI in everyday tasks for people in many roles.',
    peakY: 132,
    fillClass: 'fill-slate-500 dark:fill-slate-500',
  },
  {
    level: 2,
    label: 'Level 2',
    description:
      'Specialized roles and tasks: targeted generative AI applications for specific jobs.',
    peakY: 82,
    fillClass: 'fill-slate-600 dark:fill-slate-400',
  },
  {
    level: 3,
    label: 'Level 3',
    description:
      'Products and processes: greater autonomy in product features, customer interaction, and operational processes.',
    peakY: 28,
    fillClass: 'fill-slate-800 dark:fill-slate-200',
  },
] as const
</script>

<template>
  <div
    class="mx-auto mt-2 w-full max-w-5xl px-2"
    role="img"
    aria-label="Four levels of AI maturity as mountains left to right, each taller than the last"
  >
    <div class="flex items-end justify-between gap-2 sm:gap-4 md:gap-6">
      <div
        v-for="item in levels"
        :key="item.level"
        class="flex min-w-0 flex-1 flex-col items-center"
      >
        <svg
          class="h-40 w-full max-w-28 shrink-0 overflow-visible sm:h-44 sm:max-w-32 md:h-48 md:max-w-36"
          viewBox="0 0 100 200"
          preserveAspectRatio="xMidYMax meet"
        >
          <line
            x1="0"
            y1="199.5"
            x2="100"
            y2="199.5"
            class="stroke-slate-400/80 dark:stroke-slate-500"
            stroke-width="1"
          />
          <polygon
            :points="`0,200 100,200 50,${item.peakY}`"
            :class="['drop-shadow-md dark:drop-shadow-lg', item.fillClass]"
          />
          <polygon
            :points="`38,${item.peakY + 18} 50,${item.peakY} 62,${item.peakY + 18}`"
            class="fill-white/90 dark:fill-slate-100/90"
          />
        </svg>
        <div class="mt-3 w-full text-center">
          <div
            class="text-sm font-semibold tracking-tight sm:text-base"
            :class="'text-slate-800 dark:text-slate-100'"
          >
            {{ item.label }}
          </div>
          <p
            class="mt-1.5 text-[10px] leading-snug sm:text-xs md:text-sm"
            :class="'text-slate-600 dark:text-slate-300'"
          >
            {{ item.description }}
          </p>
        </div>
      </div>
    </div>
  </div>
</template>
