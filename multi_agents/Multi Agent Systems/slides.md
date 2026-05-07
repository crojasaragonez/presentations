---
# try also 'default' to start simple
theme: seriph
# random image from a curated Unsplash collection by Anthony
# like them? see https://unsplash.com/collections/94734566/slidev
background: https://cover.sli.dev
# some information about your slides (markdown enabled)
title: IA Agéntica
info: |
  ## Slidev Starter Template
  Presentation slides for developers.

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
duration: 35min
---

# Agentic AI

La IA deja de conversar y empieza a trabajar.

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
    alt="Persona en cocina preparando ensalada o salsa con ingredientes: interpretar, decidir y actuar con lo disponible"
    class="rounded-lg object-cover w-full max-h-80 shadow-md"
  />
  <figcaption class="text-sm opacity-75 mt-2 text-left">Preparación activa: receta mental, pasos e ingredientes al mismo tiempo, como un agente ante un objetivo</figcaption>
</figure>

<!--
Analogía: agente = quien interpreta el prompt, planifica y orquesta. Imagen: Unsplash (Getty). Misma foto que https://unsplash.com/photos/CPvzjNGg0Dk; revisa términos Unsplash+ si aplica a tu uso.
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

---
transition: fade-out
level: 2
---

# Ideas para empezar a incluir la IA

<v-clicks>

- **Normar el uso cotidiano**: plantillas de prompt, política de uso de modelos externos, canal interno para dudas y incidentes.
- **Defina un budget para herramientas de AI internas**: y deje a su equipo escoger las herramientas.
- **Plan piloto con voluntarios**: comente qué funcionó, qué no, y por qué.
- **Elegir un caso acotado** con impacto visible y bajo riesgo (una tarea repetitiva, un documento tipo, un flujo interno), en lugar de un “programa IA” abstracto.
- **Definir reglas antes de herramientas**: qué datos no salen del perímetro, revisión humana obligatoria, y quién es responsable si algo falla.
- **Medir algo concreto**: tiempo ahorrado, errores detectados, satisfacción del usuario interno… sin métricas, es difícil justificar siguientes pasos.

</v-clicks>

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

# ¿Necesita ayuda para empezar?

<div class="mx-auto mt-8 max-w-3xl text-2xl leading-relaxed">
Puedo acompañarle a identificar casos de uso, diseñar pilotos seguros y convertir la IA en capacidades reales para su equipo.
</div>

<div class="mt-12 text-xl opacity-85">
  <div class="font-semibold">Carlos Luis Rojas Aragonés</div>
  <div>CTO · Golabs</div>
  <div class="mt-4">Hablemos al final o búsqueme en LinkedIn.</div>
</div>

<!--
Invitación final: dejar claro que el siguiente paso es conversar si la organización quiere apoyo.
-->
