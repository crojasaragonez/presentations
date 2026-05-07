---
# try also 'default' to start simple
theme: seriph
# random image from a curated Unsplash collection by Anthony
# like them? see https://unsplash.com/collections/94734566/slidev
background: https://cover.sli.dev
# some information about your slides (markdown enabled)
title: The Second Brain
info: |
  ## Slidev Starter Template
  Golabs AI Fluency Program.

  Learn more at [Sli.dev](https://sli.dev)
# apply UnoCSS classes to the current slide
class: text-center
# https://sli.dev/features/drawing
drawings:
  persist: false
# slide transition: https://sli.dev/guide/animations.html#slide-transitions
transition: slide-left
# enable Comark Syntax: https://comark.dev/syntax/markdown
comark: true
# duration of the presentation
duration: 5min
---

# The Second Brain

Golabs AI Fluency Program

<div class="absolute top-8 right-8 rounded-xl bg-slate-950/80 px-4 py-3 shadow-lg ring-1 ring-white/10">
  <img
    src="/golabs/logotipo.png"
    alt="Golabs"
    class="w-30"
  />
</div>


<div @click="$slidev.nav.next" class="mt-12 py-1" hover:bg="white op-10">
  Let's start! <carbon:arrow-right />
</div>


<div class="absolute bottom-0 left-0 right-0 pb-8 px-6 text-center text-sm opacity-90">
  <div>Carlos Luis Rojas Aragonés</div>
  <div class="mt-1">2026 · All rights reserved</div>
</div>

<div class="abs-br m-6 text-xl">
  <a href="https://github.com/slidevjs/slidev" target="_blank" class="slidev-icon-btn">
    <img class="w-15" src="/golabs/isotipo.png"/>
  </a>
</div>

<!--
The last comment block of each slide will be treated as slide notes. It will be visible and editable in Presenter Mode along with the slide. [Read more in the docs](https://sli.dev/guide/syntax.html#notes)
-->

---
transition: fade-out
class: '!text-left'
---

<div class="grid h-full grid-cols-1 gap-10 pt-2 lg:grid-cols-12 lg:gap-10 lg:items-center">
  <div class="lg:col-span-8 flex flex-col justify-center gap-8">
    <div class="flex flex-wrap items-center gap-5">
      <div class="rounded-2xl bg-slate-950/70 p-4 shadow-xl ring-1 ring-white/10">
        <img src="/golabs/logotipo.png" alt="Golabs" class="w-36" />
      </div>
    </div>
    <p class="m-0 text-xl md:text-2xl leading-snug font-light">
      Golabs has been helping companies build and scale technology solutions for over 12 years,  6 of them, applying artificial intelligence to real business challenges across multiple industries.
    </p>
    <blockquote class="relative m-0 border-none pl-6 text-lg text-teal-200/95 md:text-xl">
      <span class="pointer-events-none absolute left-0 top-0 bottom-0 w-1 rounded-full bg-gradient-to-b from-cyan-400 to-emerald-500" />
      Smart Tech by Talented People!
    </blockquote>
  </div>
</div>

---
layout: two-cols
layoutClass: gap-10 items-center
transition: fade-out
level: 2
---


# Imagine having a 24/7 assistant

For just $20 per month, but also:

<v-clicks>

- 🌐 It has read most of the internet.
- 🧠 It has advanced analytical capabilities.
- ⚡ It doesn’t get tired / angry / quit.
- 🚀 It is incredibly fast at delivering results.
- ☁️ Easily accessible from the internet.
- 🔓 Zero ego / zero social friction

</v-clicks>

::right::

<figure v-click class="m-0 pr-2">
  <img
    src="/imgs/meme.png"
    alt="Shut up and take my money meme"
    class="max-h-[420px] rounded-2xl shadow-2xl"
  />
  <figcaption class="text-sm opacity-75 mt-2 text-left">Where do I sign?</figcaption>
</figure>

<!--
You can have `style` tag in markdown to override the style for the current page.
Learn more: https://sli.dev/features/slide-scope-style
-->

<style>
h1 {
  background-color: #2B90B6;
  background-image: linear-gradient(45deg, #4EC5D4 10%, #146b8c 20%);
  background-size: 100%;
  -webkit-background-clip: text;
  -moz-background-clip: text;
  -webkit-text-fill-color: transparent;
  -moz-text-fill-color: transparent;
}
</style>

<!--
Here is another comment.
-->

---
layout: two-cols
layoutClass: gap-10 items-center
transition: fade-out
level: 2
class: '!text-left'
---

# What if everyone had Copilot, ChatGPT, and Claude?

If we rolled out licenses org-wide, would that **solve the problem**?

::right::

<figure class="m-0 pr-2">
  <img
    src="/imgs/team-laptops-org-wide-ak4hmkNSU8g.jpg"
    alt="Two colleagues working together on laptops at a table"
    class="max-h-[420px] w-full object-cover rounded-2xl shadow-2xl"
  />
</figure>

<!--
That is like giving gym subscriptions to all the company and expecting everyone to be in shape within a few months.
-->

---
layout: cover
class: text-center
transition: slide-up
background: /imgs/second-brain-abstract-5zfkHMkccjc.jpg
---

<div class="absolute inset-0 bg-gradient-to-b from-slate-950/70 via-slate-950/40 to-slate-950/80" />

<div class="relative">

<div class="text-cyan-300 text-xs font-mono tracking-[0.4em] opacity-80 mb-4">THE PLAYBOOK</div>

# Build your <span class="brand">Second Brain</span>

<p class="mt-4 text-xl md:text-2xl font-light opacity-90 max-w-2xl mx-auto">
  Make AI a real part of your work and your life.
</p>

<div class="mt-10 inline-flex items-center gap-2 rounded-full bg-white/10 px-5 py-2 text-sm backdrop-blur-md ring-1 ring-white/20">
  <carbon:idea class="text-cyan-300" />
  5 simple steps · zero hype
</div>

</div>

<style>
h1 {
  font-size: 3.6rem;
  line-height: 1.05;
  font-weight: 700;
}
h1 .brand {
  background: linear-gradient(120deg, #67e8f9 0%, #818cf8 50%, #c4b5fd 100%);
  -webkit-background-clip: text;
  background-clip: text;
  color: transparent;
}
</style>

<!--
The tools are the easy part. The hard part is the system around them. Next 5 slides: a small, repeatable playbook anyone can run in 30 days.
-->

---
layout: two-cols
layoutClass: gap-10 items-center
transition: fade-out
level: 2
class: '!text-left'
---

<div class="text-cyan-300 text-xs font-mono tracking-[0.3em] opacity-80">STEP 01 · LEARN</div>

# Externalize your thinking

Let your favorite tool draft the first version from your expertise, then take it from there.
More often than you may think, the output is ready to ship or just a tweak away.

<v-clicks>

- 📝 Produce designer-grade multimedia content in seconds.
- 💬 Sharpen your opinions with crisper wording.
- 🪪 Anchor it in your role, your voice, what you care about.
- 🔁 Draft → refine → ship.

</v-clicks>

::right::

<figure class="m-0 pr-2">
  <img
    src="/imgs/externalize-thinking-notebook-FsXmqyeCMSM.jpg"
    alt="Person writing thoughts in a notebook with a pen"
    class="max-h-[420px] w-full object-cover rounded-2xl shadow-2xl"
  />
</figure>

<!--
You don’t have a memory problem. You have a Learn problem. The brain is for thinking; the system is for remembering.
-->

---
transition: fade-out
level: 2
class: '!text-left'
---

<div class="text-emerald-300 text-xs font-mono tracking-[0.3em] opacity-80">STEP 02 · REFINE</div>

# use the "wisdom of the crowd" and everyone wins

The fastest way to level up isn’t a smarter AI. It’s **a teammate handing you the prompt that already worked.** Make your discoveries everyone’s discoveries.

<div class="grid grid-cols-12 gap-6 mt-4 items-start">
  <div class="col-span-5">
    <ul class="space-y-3 text-base list-none p-0">
      <li v-click class="flex gap-3 items-start"><carbon:share class="text-emerald-300 mt-1 shrink-0" /><span>Post every prompt that shipped great work</span></li>
      <li v-click class="flex gap-3 items-start"><carbon:idea class="text-emerald-300 mt-1 shrink-0" /><span>Borrow generously, your team <em>is</em> your prompt library</span></li>
      <li v-click class="flex gap-3 items-start"><carbon:chat class="text-emerald-300 mt-1 shrink-0" /><span>Open an <code class="bg-emerald-300/10 px-1 rounded">#ai-tricks</code> channel, one post, one prompt</span></li>
      <li v-click class="flex gap-3 items-start"><carbon:events class="text-emerald-300 mt-1 shrink-0" /><span>Demo Fridays, 15 min to swap what’s working</span></li>
    </ul>
  </div>
  <div class="col-span-7">
    <PromptShareChannel />
  </div>
</div>

<!--
The real edge isn’t a smarter AI. It’s a team where one person’s win becomes everyone’s default in a week. Make sharing the path of least resistance: a single channel, a weekly demo, and a culture of stealing generously.
-->

---
transition: fade-out
level: 2
class: '!text-left'
---

<div class="text-violet-300 text-xs font-mono tracking-[0.3em] opacity-80">STEP 03 · CONNECT</div>

# Give it everything it needs to know about you

Stop copy-pasting the same background every time. Give AI your context **once**, and it stops feeling like a stranger.

<div class="flex items-stretch justify-between gap-3 mt-6">
  <div v-click class="flex-1 rounded-2xl bg-gradient-to-br from-violet-500/20 to-violet-500/5 p-5 ring-1 ring-violet-300/25 text-center">
    <div class="text-3xl mb-2">📂</div>
    <div class="text-base font-semibold">What you know</div>
    <div class="text-xs opacity-75 mt-1">files, notes, preferences</div>
  </div>
  <div class="self-center text-2xl text-violet-300 opacity-60"><carbon:arrow-right /></div>
  <div v-click class="flex-1 rounded-2xl bg-gradient-to-br from-violet-500/20 to-violet-500/5 p-5 ring-1 ring-violet-300/25 text-center">
    <div class="text-3xl mb-2">🤖</div>
    <div class="text-base font-semibold">Your AI assistant</div>
    <div class="text-xs opacity-75 mt-1">ChatGPT · Claude · Gemini · Copilot</div>
  </div>
  <div class="self-center text-2xl text-violet-300 opacity-60"><carbon:arrow-right /></div>
  <div v-click class="flex-1 rounded-2xl bg-gradient-to-br from-violet-500/20 to-violet-500/5 p-5 ring-1 ring-violet-300/25 text-center">
    <div class="text-3xl mb-2">💡</div>
    <div class="text-base font-semibold">Answers made for you</div>
    <div class="text-xs opacity-75 mt-1">no more starting from zero</div>
  </div>
</div>

<div class="grid grid-cols-3 gap-4 mt-6">
  <div v-click class="rounded-xl bg-white/5 p-4 ring-1 ring-white/10 backdrop-blur-md">
    <div class="text-[10px] font-mono uppercase tracking-widest opacity-60">your files</div>
    <div class="text-sm mt-1">Upload your résumé, your slides, your team’s playbook.</div>
  </div>
  <div v-click class="rounded-xl bg-white/5 p-4 ring-1 ring-white/10 backdrop-blur-md">
    <div class="text-[10px] font-mono uppercase tracking-widest opacity-60">memory</div>
    <div class="text-sm mt-1">Turn it on. It remembers your role, voice, and preferences between chats.</div>
  </div>
  <div v-click class="rounded-xl bg-white/5 p-4 ring-1 ring-white/10 backdrop-blur-md">
    <div class="text-[10px] font-mono uppercase tracking-widest opacity-60">your apps</div>
    <div class="text-sm mt-1">Connect calendar, email, Drive, Notion, already built into the AI you use.</div>
  </div>
</div>

<!--
This is the difference between a generic answer and one that actually fits your role, your team, your voice.
-->

---
transition: fade-out
level: 2
class: '!text-left'
---

<div class="text-amber-300 text-xs font-mono tracking-[0.3em] opacity-80">STEP 04 · AUTOMATE</div>

# Make AI part of your day

Go from **using AI when you think of it** to **AI already working for you** before you open your laptop.

<div class="grid grid-cols-2 md:grid-cols-4 gap-4 mt-6">
  <div v-click class="rounded-2xl p-4 bg-gradient-to-br from-cyan-500/15 to-indigo-500/10 ring-1 ring-white/10">
    <carbon:sunrise class="text-2xl text-cyan-300" />
    <div class="mt-3 font-semibold">Morning brief</div>
    <div class="text-xs opacity-75 mt-1">Your calendar, emails and priorities, summarized at 8 a.m.</div>
  </div>
  <div v-click class="rounded-2xl p-4 bg-gradient-to-br from-emerald-500/15 to-teal-500/10 ring-1 ring-white/10">
    <carbon:email class="text-2xl text-emerald-300" />
    <div class="mt-3 font-semibold">Inbox helper</div>
    <div class="text-xs opacity-75 mt-1">Drafts replies in your voice. Flags what really matters.</div>
  </div>
  <div v-click class="rounded-2xl p-4 bg-gradient-to-br from-violet-500/15 to-fuchsia-500/10 ring-1 ring-white/10">
    <carbon:notebook class="text-2xl text-violet-300" />
    <div class="mt-3 font-semibold">Meeting recap</div>
    <div class="text-xs opacity-75 mt-1">The call, turned into decisions, owners, and dates, in your inbox.</div>
  </div>
  <div v-click class="rounded-2xl p-4 bg-gradient-to-br from-amber-500/15 to-orange-500/10 ring-1 ring-white/10">
    <carbon:chart-line class="text-2xl text-amber-300" />
    <div class="mt-3 font-semibold">Weekly review</div>
    <div class="text-xs opacity-75 mt-1">What got done, what slipped, what’s next.</div>
  </div>
</div>

<div v-click class="mt-6 text-sm opacity-75">
  <span class="font-mono uppercase tracking-widest text-[10px] opacity-60 mr-2">where it lives</span>
  Already inside Copilot, ChatGPT, Claude &amp; Gemini · your calendar &amp; email · simple no-code tools
</div>

<!--
Think of each helper as a tiny assistant that never sleeps, never complains, and shows up before you do.
-->

---
layout: two-cols-header
transition: fade-out
level: 2
class: '!text-left'
---

<div class="text-fuchsia-300 text-xs font-mono tracking-[0.3em] opacity-80">STEP 05 · MEASURE</div>

# What gets measured gets better

::left::

<div class="space-y-6 pr-4">
  <div v-click>
    <div class="text-3xl font-bold bg-gradient-to-r from-cyan-300 to-indigo-300 bg-clip-text text-transparent">
      ⏱ &nbsp;Time saved
    </div>
    <div class="text-sm opacity-75 mt-1">Per task, per week. If it isn’t faster, change the instruction, or drop it.</div>
  </div>
  <div v-click>
    <div class="text-3xl font-bold bg-gradient-to-r from-emerald-300 to-teal-300 bg-clip-text text-transparent">
      🎯 &nbsp;Keep rate
    </div>
    <div class="text-sm opacity-75 mt-1">How often you keep what AI gives you, with little or no editing.</div>
  </div>
</div>

::right::

<div class="space-y-6 pl-4">
  <div v-click>
    <div class="text-3xl font-bold bg-gradient-to-r from-violet-300 to-fuchsia-300 bg-clip-text text-transparent">
      📓 &nbsp;Mistake notebook
    </div>
    <div class="text-sm opacity-75 mt-1">Note every wrong answer. Fix the instruction or give it more context.</div>
  </div>
  <div v-click>
    <div class="text-3xl font-bold bg-gradient-to-r from-amber-300 to-orange-300 bg-clip-text text-transparent">
      🔁 &nbsp;Friday review
    </div>
    <div class="text-sm opacity-75 mt-1">Once a week: drop what didn’t help. Double down on what did.</div>
  </div>
</div>

<!--
You don’t need a dashboard. A simple Friday check-in beats any shiny new tool.
-->

---
transition: fade-out
level: 2
class: '!text-left'
---

# Your first <span class="brand">30 days</span>

<div class="grid grid-cols-1 md:grid-cols-4 gap-4 mt-8">
  <div v-click class="rounded-2xl p-5 bg-gradient-to-b from-cyan-500/15 to-cyan-500/5 ring-1 ring-cyan-300/20">
    <div class="text-[10px] font-mono uppercase tracking-widest opacity-60">Week 1</div>
    <div class="mt-1 text-xl font-semibold text-cyan-200">Learn</div>
    <ul class="mt-3 text-sm opacity-90 space-y-1 list-disc pl-4">
      <li>Draft your next email, doc or deck with AI first</li>
      <li>Anchor every chat in your role &amp; your voice</li>
      <li>Save every instruction that shipped great work</li>
    </ul>
  </div>
  <div v-click class="rounded-2xl p-5 bg-gradient-to-b from-emerald-500/15 to-emerald-500/5 ring-1 ring-emerald-300/20">
    <div class="text-[10px] font-mono uppercase tracking-widest opacity-60">Week 2</div>
    <div class="mt-1 text-xl font-semibold text-emerald-200">Refine</div>
    <ul class="mt-3 text-sm opacity-90 space-y-1 list-disc pl-4">
      <li>Open an <code class="bg-emerald-300/10 px-1 rounded">#ai-tricks</code> channel and post 3 prompts</li>
      <li>Steal one prompt from a teammate, ship with it</li>
      <li>Run a 15-min Demo Friday</li>
    </ul>
  </div>
  <div v-click class="rounded-2xl p-5 bg-gradient-to-b from-violet-500/15 to-violet-500/5 ring-1 ring-violet-300/20">
    <div class="text-[10px] font-mono uppercase tracking-widest opacity-60">Week 3</div>
    <div class="mt-1 text-xl font-semibold text-violet-200">Connect</div>
    <ul class="mt-3 text-sm opacity-90 space-y-1 list-disc pl-4">
      <li>Upload your résumé, slides &amp; team playbook</li>
      <li>Turn on memory: role, voice, preferences</li>
      <li>Connect calendar, email and one work app</li>
    </ul>
  </div>
  <div v-click class="rounded-2xl p-5 bg-gradient-to-b from-amber-500/15 to-amber-500/5 ring-1 ring-amber-300/20">
    <div class="text-[10px] font-mono uppercase tracking-widest opacity-60">Week 4</div>
    <div class="mt-1 text-xl font-semibold text-amber-200">Automate + Measure</div>
    <ul class="mt-3 text-sm opacity-90 space-y-1 list-disc pl-4">
      <li>Ship 1 daily helper: morning brief or inbox</li>
      <li>Log time saved &amp; keep rate per task</li>
      <li>Hold your first Friday review</li>
    </ul>
  </div>
</div>

<div v-click class="mt-10 text-center text-sm opacity-70">
  Small. Boring. Repeatable. <span class="opacity-60">→</span> Compounding.
</div>

<style>
h1 .brand {
  background: linear-gradient(120deg, #67e8f9 0%, #34d399 50%, #fbbf24 100%);
  -webkit-background-clip: text;
  background-clip: text;
  color: transparent;
}
</style>

<!--
This isn’t a New Year’s resolution. Four weeks, one habit per week. By Week 5 you’re running with a system.
-->

---
layout: cover
class: text-center
transition: fade
background: /imgs/horizon-sunrise-A4iL43vunlY.jpg
---

<div class="absolute inset-0 bg-gradient-to-b from-slate-950/55 via-slate-950/30 to-slate-950/80" />

<div class="relative">

# Your second brain works <span class="brand">while you sleep</span>

<p class="mt-6 text-lg md:text-xl opacity-95 max-w-2xl mx-auto font-light">
  You don’t need a smarter AI. You need to give it what only you know.
</p>

<div class="mt-10 flex flex-wrap justify-center gap-2 text-xs">
  <span class="rounded-full bg-white/15 backdrop-blur-md px-4 py-1 ring-1 ring-white/25">Learn</span>
  <span class="rounded-full bg-white/15 backdrop-blur-md px-4 py-1 ring-1 ring-white/25">Refine</span>
  <span class="rounded-full bg-white/15 backdrop-blur-md px-4 py-1 ring-1 ring-white/25">Connect</span>
  <span class="rounded-full bg-white/15 backdrop-blur-md px-4 py-1 ring-1 ring-white/25">Automate</span>
  <span class="rounded-full bg-white/15 backdrop-blur-md px-4 py-1 ring-1 ring-white/25">Measure</span>
</div>

</div>

<style>
h1 {
  font-size: 3rem;
  line-height: 1.1;
  font-weight: 700;
}
h1 .brand {
  background: linear-gradient(120deg, #fde047 0%, #fb923c 50%, #f43f5e 100%);
  -webkit-background-clip: text;
  background-clip: text;
  color: transparent;
}
</style>

<!--
Closing thought: the playbook is small on purpose. Learn, Refine, Connect, Automate, Measure, repeat. The compounding does the rest.
-->

---
layout: cover
class: text-center
transition: fade
---

<div class="absolute inset-0 bg-gradient-to-br from-slate-950 via-slate-900 to-slate-950" />
<div class="absolute inset-0 opacity-40" style="background: radial-gradient(circle at 30% 20%, rgba(103, 232, 249, 0.25), transparent 45%), radial-gradient(circle at 70% 80%, rgba(167, 139, 250, 0.25), transparent 45%);" />

<div class="relative flex flex-col items-center justify-center h-full">

<div class="text-cyan-300 text-xs font-mono tracking-[0.4em] opacity-80 mb-4">END OF PLAYBOOK</div>

# <span class="brand">Thank you</span>

<p class="mt-6 text-lg md:text-xl opacity-90 max-w-xl mx-auto font-light">
  Now go build your Second Brain.
</p>

<div class="mt-10 flex items-center justify-center gap-3">
  <div class="rounded-2xl bg-slate-950/70 px-5 py-3 shadow-xl ring-1 ring-white/10">
    <img src="/golabs/logotipo.png" alt="Golabs" class="w-32" />
  </div>
</div>

<div class="mt-8 text-sm opacity-80">
  <div class="font-medium">Carlos Luis Rojas Aragonés</div>
  <div class="mt-1 flex items-center justify-center gap-3 text-xs opacity-75">
    <span>Golabs · AI Fluency Program</span>
    <span class="opacity-40">·</span>
    <span>2026</span>
  </div>
</div>

</div>

<style>
h1 {
  font-size: 5rem;
  line-height: 1;
  font-weight: 800;
  margin: 0;
}
h1 .brand {
  background: linear-gradient(120deg, #67e8f9 0%, #818cf8 50%, #c4b5fd 100%);
  -webkit-background-clip: text;
  background-clip: text;
  color: transparent;
}
</style>

<!--
Wrap up, invite questions, and point them at the next session of the AI Fluency Program.
-->
