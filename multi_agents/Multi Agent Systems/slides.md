---
theme: seriph
background: https://cover.sli.dev
title: Agentic AI
info: |
  ## Agentic AI

  A practical introduction to AI agents and multi-agent systems using a restaurant analogy.
class: text-center
drawings:
  persist: false
transition: slide-left
comark: true
duration: 35min
---

# Agentic AI

AI stops chatting and starts working.

<div class="absolute top-8 right-8 rounded-xl bg-slate-950/80 px-4 py-3 shadow-lg ring-1 ring-white/10">
  <img
    src="/golabs/logotipo.png"
    alt="Golabs"
    class="w-34"
  />
</div>

<div class="absolute bottom-0 left-0 right-0 pb-8 px-6 text-center text-sm opacity-90">
  <div>Carlos Luis Rojas Aragonés</div>
  <div class="mt-1">CTO · Golabs · 2026</div>
</div>

<!--
The last comment block of each slide will be treated as slide notes. It will be visible and editable in Presenter Mode along with the slide. [Read more in the docs](https://sli.dev/guide/syntax.html#notes)
-->

---
layout: center
class: text-center
---

# Is your organization ready for AI?

---
transition: fade-out
class: relative
---

# Levels of AI maturity

<AiMaturityMountains />

<div class="absolute bottom-6 right-8 max-w-md text-right text-[11px] leading-snug opacity-75 sm:text-xs text-slate-600 dark:text-slate-400">
  Source: adapted from a master class by Dr. George Westerman (MIT).
</div>

---
transition: fade-out
---

# Concepts

To understand what an AI agent *really* is, you need to weave together many pieces: models, interaction design, architecture, operations, and governance. **The vocabulary alone is exhausting.** On the next slide we use an analogy to organize it.

<AgentConceptCloud />

<!--
Approach: the cloud should look overwhelming on purpose; the next block will simplify with an analogy.
-->

---
layout: two-cols
layoutClass: gap-10 items-center
transition: fade-out
---

# Restaurant analogy

To organize all that vocabulary without drowning in definitions, we will use **a restaurant** as a shared image: in the following slides we will see how the concepts fit there—**one scenario** instead of a loose list of terms.

::right::

<div class="flex flex-col gap-4 justify-center pr-2">
  <figure class="m-0">
    <img
      src="/restaurant-analogy/chefs-collaborating.jpg"
      alt="Several chefs collaborating in a busy restaurant kitchen"
      class="rounded-lg object-cover w-full max-h-50 shadow-md"
    />
    <figcaption class="text-sm opacity-75 mt-2 text-left">Kitchen: team of chefs collaborating</figcaption>
  </figure>
  <figure class="m-0">
    <img
      src="/restaurant-analogy/dish-plate-wine.jpg"
      alt="Gourmet dish on white ceramic with food and wine glass on a table"
      class="rounded-lg object-cover w-full max-h-50 shadow-md"
    />
    <figcaption class="text-sm opacity-75 mt-2 text-left">Dining room: plates and drinks on the table</figcaption>
  </figure>
</div>

<!--
Only introduce the frame; do not map role by role yet. Photos: Unsplash (kitchen / dining room).
-->

---
layout: two-cols
layoutClass: gap-10 items-center
transition: fade-out
level: 2
---

# LLM

In the restaurant, an **LLM** is like having someone who has **read, in practice, the books and texts about cooking on the internet**, as if they had absorbed an entire library of gastronomy online. That **does not replace** the kitchen or service, but **adds exceptional value**: a base of knowledge and language that is hard to match with a single human expert.

::right::

<figure class="m-0 pr-2">
  <img
    src="/llm/cookbooks-stack.jpg"
    alt="Stack of cookbooks on a shelf: metaphor for the textual knowledge condensed in an LLM"
    class="rounded-lg object-cover w-full max-h-80 shadow-md"
  />
  <figcaption class="text-sm opacity-75 mt-2 text-left">Cooking knowledge accumulated like a library: the kind of material an LLM learns from</figcaption>
</figure>

<!--
First concept anchored to the analogy; clarify later limitations (has not “cooked” every dish, hallucinations, etc.) if needed. Image: Unsplash (Haberdoedas), cookbooks.
-->

---
layout: two-cols
layoutClass: gap-10 items-center
transition: fade-out
level: 2
---

# Prompt

The **prompt** is, in the restaurant, **the customer's order**: what is asked for in words at that moment (clear or vague, short or long) and that steers what should come out of the kitchen (or what the team should answer). Without an order there is no specific dish; with a poorly phrased order, the result often disappoints even when the kitchen is excellent.

::right::

<figure class="m-0 pr-2">
  <img
    src="/prompt/customer-order.jpg"
    alt="Server taking a customer's order at a bar: the explicit request that guides service"
    class="rounded-lg object-cover w-full max-h-80 shadow-md"
  />
  <figcaption class="text-sm opacity-75 mt-2 text-left">The order in words, equivalent to the prompt the model receives</figcaption>
</figure>

<!--
Analogy: prompt = instruction / order. Image: Unsplash (restaurant order).
-->

---
layout: two-cols
layoutClass: gap-10 items-center
transition: fade-out
level: 2
---

# Agent

The **agent** is the role that, faced with the order and with knowledge at hand, **does not limit itself to one single action**: it **interprets the order**, **decides which “recipe” (strategy) applies**, **organizes the steps**, and **coordinates resources** (ingredients, time, shifts) until the outcome is on track.

- **Interprets** the order (what the customer really asked for).
- **Decides** which recipe or approach fits best.
- **Organizes** the sequence of steps.
- **Coordinates** ingredients, time, and workload.

**Not just “cooking”**: **thinks and acts** to achieve a **goal** under real constraints.

::right::

<figure class="m-0 pr-2">
  <img
    src="/agent/latin-man-cooking-kitchen.jpg"
    alt="Specialist chef"
    class="rounded-lg object-cover w-full max-h-80 shadow-md"
  />
</figure>

<!--
Analogy: agent = who interprets the prompt, plans, acts, and adjusts.
-->

---
layout: two-cols
layoutClass: gap-10 items-center
transition: fade-out
level: 2
---

# Multi-Agents

**Multi-agent** setups are like a **multidisciplinary team in the kitchen**: no single profile does everything. Some excel at **savory**, some lead **pastries and baking**, some bring **another tradition or station** (as in a ***MasterChef***-style format, with specialties and different challenges in parallel), and **everyone coordinates** to meet **one shared goal** (service, the menu, the diner's experience).

Each “agent” brings its judgment and its tools; the value lies in **how tasks are split, how they communicate, and how they align** without jamming the kitchen.

::right::

<figure class="m-0 pr-2">
  <img
    src="/multi-agents/chef-group-table.jpg"
    alt="Group of chefs standing by a work table: multidisciplinary team gathered"
    class="rounded-lg object-cover w-full max-h-80 shadow-md"
  />
  <figcaption class="text-sm opacity-75 mt-2 text-left">Several roles, one team—like distinct agents with a common goal</figcaption>
</figure>

<!--
Image: Unsplash (CET / ceteduvn). https://unsplash.com/photos/group-of-chef-standing-beside-table-47Q3QfM5Eh4
-->

---
layout: center
class: text-center
transition: fade-out
level: 2
---

# How do I get started?

<div class="mx-auto mt-8 max-w-2xl text-2xl leading-relaxed opacity-85">
Don't start with architecture: start with a concrete operational decision.
</div>

---
transition: fade-out
level: 2
---

# Ideas to start bringing in AI

<div class="grid grid-cols-3 gap-5 pt-6">
  <div v-click class="rounded-xl border border-slate-300/60 p-5 shadow-sm dark:border-white/15 dark:bg-white/5">
    <div class="text-xl font-bold">1. Rules</div>
    <p class="mt-3 text-sm leading-relaxed opacity-80">
      Define usage policy, data that stays inside the perimeter, human review, and accountability.
    </p>
  </div>

  <div v-click class="rounded-xl border border-slate-300/60 p-5 shadow-sm dark:border-white/15 dark:bg-white/5">
    <div class="text-xl font-bold">2. Pilot</div>
    <p class="mt-3 text-sm leading-relaxed opacity-80">
      Pick a bounded, visible, low-risk use case with volunteers and a clear budget.
    </p>
  </div>

  <div v-click class="rounded-xl border border-slate-300/60 p-5 shadow-sm dark:border-white/15 dark:bg-white/5">
    <div class="text-xl font-bold">3. Measurement</div>
    <p class="mt-3 text-sm leading-relaxed opacity-80">
      Measure time saved, errors caught, and internal user satisfaction.
    </p>
  </div>
</div>

<!--
Bridge from multi-agents to organizational practice; tune examples to the audience (Golabs / sector).
-->

---
layout: center
class: text-center
transition: fade-out
level: 2
---

# AI starts with one well-chosen first use case

<div class="mx-auto mt-8 max-w-3xl text-left text-2xl leading-relaxed">

<v-clicks>

- A real, repetitive, measurable problem.
- Clear data and boundaries from day one.
- People responsible for validating, learning, and scaling.

</v-clicks>

</div>

<!--
Close the practical part: not selling a huge transformation, but a governed, measurable first step.
-->

---
layout: center
class: text-center
transition: slide-up
level: 2
---

<div class="absolute top-8 right-8 rounded-xl bg-slate-950/80 px-4 py-3 shadow-lg ring-1 ring-white/10">
  <img
    src="/golabs/logotipo.png"
    alt="Golabs"
    class="w-34"
  />
</div>

<h1 class="!text-8xl !font-bold !mb-2 bg-gradient-to-r from-sky-400 via-indigo-400 to-fuchsia-400 bg-clip-text text-transparent">
  Thank you!
</h1>

<div class="mt-2 text-xl opacity-70">Let's talk about bringing agentic AI to your organization.</div>

<div class="mt-12 flex items-center justify-center gap-12">
  <img
    src="/golabs/pic.jpeg"
    alt="Carlos Luis Rojas Aragonés"
    class="h-56 w-56 rounded-full object-cover shadow-xl ring-4 ring-white/20"
  />

  <div class="text-left">
    <div class="text-3xl font-semibold leading-tight">Carlos Luis Rojas Aragonés</div>
    <div class="mt-2 text-xl opacity-85">CTO · Golabs</div>
    <div class="mt-6 max-w-xs text-base opacity-70">
      Scan the QR code to save my contact details.
    </div>
  </div>

  <img
    src="/golabs/qr-code.png"
    alt="Contact QR code"
    class="h-52 w-52 rounded-lg bg-white p-3 shadow-xl"
  />
</div>

<!--
Warm close: thank you, clear identity, and a direct channel (QR) to continue the conversation.
-->
