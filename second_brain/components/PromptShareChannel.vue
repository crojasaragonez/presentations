<script setup lang="ts">
interface PromptCard {
  initial: string
  author: string
  role: string
  time: string
  avatarGradient: string
  text: string
  claps: number
  savedBy: number
}

interface Props {
  channel?: string
  members?: number
  footer?: string
  badge?: string
  prompts?: PromptCard[]
}

withDefaults(defineProps<Props>(), {
  channel: 'ai-tricks',
  members: 128,
  footer: '+ 47 prompts shared this month',
  badge: '↗ trending',
  prompts: () => [
    {
      initial: 'M',
      author: 'María',
      role: 'Design',
      time: '2h',
      avatarGradient: 'from-pink-400 to-rose-500',
      text: 'Turn this Figma export into an accessible component spec, under 80 words.',
      claps: 14,
      savedBy: 9,
    },
    {
      initial: 'D',
      author: 'Diego',
      role: 'Sales',
      time: 'yesterday',
      avatarGradient: 'from-amber-400 to-orange-500',
      text: 'Rewrite this client email — warm, decisive, no filler. Match my last 3 replies.',
      claps: 22,
      savedBy: 18,
    },
  ],
})
</script>

<template>
  <div class="rounded-2xl bg-gradient-to-br from-emerald-500/15 to-teal-500/10 ring-1 ring-emerald-300/25 p-5 shadow-2xl">
    <div class="flex items-center justify-between text-emerald-300 text-[10px] font-mono uppercase tracking-widest opacity-90 mb-4">
      <div class="flex items-center gap-2">
        <carbon-hashtag />
        {{ channel }}
      </div>
      <span class="opacity-60">{{ members }} members</span>
    </div>

    <div class="space-y-3">
      <div
        v-for="(p, i) in prompts"
        :key="i"
        class="rounded-xl bg-white/5 p-3 ring-1 ring-white/10"
      >
        <div class="flex items-center gap-2 mb-1.5">
          <div
            class="w-6 h-6 rounded-full bg-gradient-to-br text-[10px] flex items-center justify-center font-bold"
            :class="p.avatarGradient"
          >
            {{ p.initial }}
          </div>
          <span class="text-sm font-semibold">{{ p.author }} · {{ p.role }}</span>
          <span class="text-[10px] opacity-50">{{ p.time }}</span>
        </div>
        <div class="text-sm opacity-90">&ldquo;{{ p.text }}&rdquo;</div>
        <div class="flex gap-3 mt-2 text-[11px] opacity-70">
          <span>👏 {{ p.claps }}</span>
          <span class="inline-flex items-center gap-1">
            <carbon-bookmark />
            saved by {{ p.savedBy }}
          </span>
        </div>
      </div>
    </div>

    <div class="mt-4 flex justify-between items-center text-[11px] opacity-60 pt-3 border-t border-emerald-300/15">
      <span>{{ footer }}</span>
      <span class="font-mono">{{ badge }}</span>
    </div>
  </div>
</template>
