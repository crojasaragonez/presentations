---
theme: seriph
background: https://cover.sli.dev
title: IA Agéntica
info: |
  ## IA Agéntica

  Una introducción práctica a agentes y multi-agentes de IA usando la analogía de un restaurante.
class: text-center
drawings:
  persist: false
transition: slide-left
comark: true
duration: 35min
---

# Agentic AI

La IA deja de conversar y empieza a trabajar.

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

# ¿Está su organización preparada para la IA?

---
transition: fade-out
class: relative
---

# Niveles de madurez en IA

<AiMaturityMountains />

<div class="absolute bottom-6 right-8 max-w-md text-right text-[11px] leading-snug opacity-75 sm:text-xs text-slate-600 dark:text-slate-400">
  Fuente: adaptación de una master class del Dr. George Westerman (MIT).
</div>

---
transition: fade-out
---

# Conceptos

Para entender qué es *realmente* un agente de IA hace falta tejer muchas piezas: modelos, diseño de interacción, arquitectura, operación y gobernanza. **Solo el vocabulario ya cansa.** En la siguiente diapositiva proponemos una analogía para ordenarlo.

<AgentConceptCloud />

<!--
Enfoque: la nube debe verse abrumadora a propósito; el siguiente bloque simplificará con analogía.
-->

---
layout: two-cols
layoutClass: gap-10 items-center
transition: fade-out
---

# Analogía del restaurante

Para ordenar todo ese vocabulario sin ahogarnos en definiciones, vamos a usar **un restaurante** como imagen común: en las siguientes diapositivas veremos cómo encajan ahí los conceptos: **un solo escenario** en lugar de una lista suelta de términos.

::right::

<div class="flex flex-col gap-4 justify-center pr-2">
  <figure class="m-0">
    <img
      src="/restaurant-analogy/chefs-collaborating.jpg"
      alt="Varios chefs colaborando en una cocina de restaurante ocupada"
      class="rounded-lg object-cover w-full max-h-50 shadow-md"
    />
    <figcaption class="text-sm opacity-75 mt-2 text-left">Cocina: equipo de chefs colaborando</figcaption>
  </figure>
  <figure class="m-0">
    <img
      src="/restaurant-analogy/dish-plate-wine.jpg"
      alt="Plato gourmet en cerámica blanca con comida y copa de vino en mesa"
      class="rounded-lg object-cover w-full max-h-50 shadow-md"
    />
    <figcaption class="text-sm opacity-75 mt-2 text-left">Sala: platillos y bebidas en la mesa</figcaption>
  </figure>
</div>

<!--
Solo presentar el marco; no mapear todavía rol por rol. Fotos: Unsplash (cocina / sala).
-->

---
layout: two-cols
layoutClass: gap-10 items-center
transition: fade-out
level: 2
---

# LLM

En el restaurante, un **LLM** equivale a tener a alguien que **se ha leído, en la práctica, los libros y textos sobre cocina que hay en internet**, como si hubiera absorbido una biblioteca entera de gastronomía en línea. Eso **no reemplaza** la cocina ni el servicio, pero **aporta un valor excepcional**: una base de conocimiento y de lenguaje difícil de igualar con un solo experto humano.

::right::

<figure class="m-0 pr-2">
  <img
    src="/llm/cookbooks-stack.jpg"
    alt="Pila de libros de cocina en una estantería: metáfora del conocimiento textual que condensa un LLM"
    class="rounded-lg object-cover w-full max-h-80 shadow-md"
  />
  <figcaption class="text-sm opacity-75 mt-2 text-left">Conocimiento de cocina acumulado como en una biblioteca: el tipo de material del que aprende un LLM</figcaption>
</figure>

<!--
Primer concepto anclado a la analogía; matizar después limitaciones (no ha “cocinado” cada plato, alucinaciones, etc.) si toca. Imagen: Unsplash (Haberdoedas), libros de cocina.
-->

---
layout: two-cols
layoutClass: gap-10 items-center
transition: fade-out
level: 2
---

# Prompt

El **prompt** es, en el restaurante, **la orden del cliente**: lo que se pide con palabras en ese momento (clara o ambigua, corta o larga) y que orienta qué debe salir de la cocina (o qué debe responder el equipo). Sin pedido no hay plato concreto; con un pedido mal formulado, el resultado suele decepcionar aunque la cocina sea excelente.

::right::

<figure class="m-0 pr-2">
  <img
    src="/prompt/customer-order.jpg"
    alt="Mesero tomando el pedido a una clienta en un bar: la petición explícita que guía el servicio"
    class="rounded-lg object-cover w-full max-h-80 shadow-md"
  />
  <figcaption class="text-sm opacity-75 mt-2 text-left">El pedido en palabras, equivalente al prompt que recibe el modelo</figcaption>
</figure>

<!--
Analogía: prompt = instrucción / pedido. Imagen: Unsplash (pedido en restaurante).
-->

---
layout: two-cols
layoutClass: gap-10 items-center
transition: fade-out
level: 2
---

# Agent

El **agente** es el rol que, frente al pedido y con el conocimiento a mano, **no se limita a ejecutar un solo gesto**: **interpreta la orden**, **decide qué “receta” (estrategia) aplica**, **organiza los pasos** y **coordina recursos** (ingredientes, tiempo, turnos) hasta encaminar el resultado.

- **Interpreta** la orden (qué pidió realmente el cliente).
- **Decide** qué receta o enfoque conviene.
- **Organiza** la secuencia de pasos.
- **Coordina** ingredientes, tiempo y carga de trabajo.

**No solo “cocina”**: **piensa y actúa** para cumplir un **objetivo** bajo restricciones reales.

::right::

<figure class="m-0 pr-2">
  <img
    src="/agent/latin-man-cooking-kitchen.jpg"
    alt="Chef especialista"
    class="rounded-lg object-cover w-full max-h-80 shadow-md"
  />
</figure>

<!--
Analogía: agente = quien interpreta el prompt, planifica, actúa y ajusta.
-->

---
layout: two-cols
layoutClass: gap-10 items-center
transition: fade-out
level: 2
---

# Multi-Agents

Los **multi-agentes** son como un **equipo multidisciplinario en cocina**: no hay un solo perfil que lo haga todo. Hay quien domina **salados**, quien lleva **postres y repostería**, quien aporta **otra tradición o estación** (como en un formato tipo ***MasterChef***, con especialidades y pruebas distintas en paralelo) y **todos coordinan** para cumplir **un mismo objetivo** (el servicio, el menú, la experiencia del comensal).

Cada “agente” aporta su criterio y sus herramientas; el valor está en **cómo se reparten tareas, se comunican y se alinean** sin trabar la cocina.

::right::

<figure class="m-0 pr-2">
  <img
    src="/multi-agents/chef-group-table.jpg"
    alt="Grupo de chefs de pie junto a una mesa de trabajo: equipo multidisciplinario reunido"
    class="rounded-lg object-cover w-full max-h-80 shadow-md"
  />
  <figcaption class="text-sm opacity-75 mt-2 text-left">Varios perfiles, un mismo equipo, como agentes distintos con un objetivo común</figcaption>
</figure>

<!--
Imagen: Unsplash (CET / ceteduvn). https://unsplash.com/photos/group-of-chef-standing-beside-table-47Q3QfM5Eh4
-->

---
layout: center
class: text-center
transition: fade-out
level: 2
---

# ¿Cómo empiezo?

<div class="mx-auto mt-8 max-w-2xl text-2xl leading-relaxed opacity-85">
No empiece por la arquitectura: empiece por una decisión operativa concreta.
</div>

---
transition: fade-out
level: 2
---

# Ideas para empezar a incluir la IA

<div class="grid grid-cols-3 gap-5 pt-6">
  <div v-click class="rounded-xl border border-slate-300/60 p-5 shadow-sm dark:border-white/15 dark:bg-white/5">
    <div class="text-xl font-bold">1. Reglas</div>
    <p class="mt-3 text-sm leading-relaxed opacity-80">
      Defina política de uso, datos que no salen del perímetro, revisión humana y responsabilidad.
    </p>
  </div>

  <div v-click class="rounded-xl border border-slate-300/60 p-5 shadow-sm dark:border-white/15 dark:bg-white/5">
    <div class="text-xl font-bold">2. Piloto</div>
    <p class="mt-3 text-sm leading-relaxed opacity-80">
      Escoja un caso acotado, visible y de bajo riesgo con voluntarios y budget claro.
    </p>
  </div>

  <div v-click class="rounded-xl border border-slate-300/60 p-5 shadow-sm dark:border-white/15 dark:bg-white/5">
    <div class="text-xl font-bold">3. Medición</div>
    <p class="mt-3 text-sm leading-relaxed opacity-80">
      Mida tiempo ahorrado, errores detectados y satisfacción del usuario interno.
    </p>
  </div>
</div>

<!--
Puente desde multi-agentes hacia práctica organizacional; ajustar ejemplos a la audiencia (Golabs / sector).
-->

---
layout: center
class: text-center
transition: fade-out
level: 2
---

# La IA empieza con un primer caso bien escogido

<div class="mx-auto mt-8 max-w-3xl text-left text-2xl leading-relaxed">

<v-clicks>

- Un problema real, repetitivo y medible.
- Datos y límites claros desde el día cero.
- Personas responsables de validar, aprender y escalar.

</v-clicks>

</div>

<!--
Cerrar la parte práctica: no vender una transformación enorme, sino un primer paso gobernado y medible.
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
  ¡Gracias!
</h1>

<div class="mt-2 text-xl opacity-70">Conversemos sobre cómo llevar la IA agéntica a su organización.</div>

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
      Escanee el código para guardar mis datos de contacto.
    </div>
  </div>

  <img
    src="/golabs/qr-code.png"
    alt="Código QR de contacto"
    class="h-52 w-52 rounded-lg bg-white p-3 shadow-xl"
  />
</div>

<!--
Cierre cálido: agradecer, dejar identidad clara y abrir un canal directo (QR) para continuar la conversación.
-->
