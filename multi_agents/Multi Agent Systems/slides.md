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
transition: fade-out
---

# Conceptos

Para entender qué es *realmente* un agente de IA hace falta tejer muchas piezas: modelos, diseño de interacción, arquitectura, operación y gobernanza. **Solo el vocabulario ya cansa** — en la siguiente diapositiva proponemos una analogía para ordenarlo.

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

Para ordenar todo ese vocabulario sin ahogarnos en definiciones, vamos a usar **un restaurante** como imagen común: en las siguientes diapositivas veremos cómo encajan ahí los conceptos — **un solo escenario** en lugar de una lista suelta de términos.

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

En el restaurante, un **LLM** equivale a tener a alguien que **se ha leído, en la práctica, los libros y textos sobre cocina que hay en internet** —como si hubiera absorbido una biblioteca entera de gastronomía en línea. Eso **no reemplaza** la cocina ni el servicio, pero **aporta un valor excepcional**: una base de conocimiento y de lenguaje difícil de igualar con un solo experto humano.

::right::

<figure class="m-0 pr-2">
  <img
    src="/llm/cookbooks-stack.jpg"
    alt="Pila de libros de cocina en una estantería: metáfora del conocimiento textual que condensa un LLM"
    class="rounded-lg object-cover w-full max-h-80 shadow-md"
  />
  <figcaption class="text-sm opacity-75 mt-2 text-left">Conocimiento de cocina acumulado como en una biblioteca —el tipo de material del que aprende un LLM</figcaption>
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

El **prompt** es, en el restaurante, **la orden del cliente**: lo que se pide con palabras en ese momento —clara o ambigua, corta o larga— y que orienta qué debe salir de la cocina (o qué debe responder el equipo). Sin pedido no hay plato concreto; con un pedido mal formulado, el resultado suele decepcionar aunque la cocina sea excelente.

::right::

<figure class="m-0 pr-2">
  <img
    src="/prompt/customer-order.jpg"
    alt="Mesero tomando el pedido a una clienta en un bar: la petición explícita que guía el servicio"
    class="rounded-lg object-cover w-full max-h-80 shadow-md"
  />
  <figcaption class="text-sm opacity-75 mt-2 text-left">El pedido en palabras —equivalente al prompt que recibe el modelo</figcaption>
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

El **agente** es el rol que, frente al pedido y con el conocimiento a mano, **no se limita a ejecutar un solo gesto**: **interpreta la orden**, **decide qué “receta” (estrategia) aplica**, **organiza los pasos** y **coordina recursos** —ingredientes, tiempo, turnos— hasta encaminar el resultado.

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
  <figcaption class="text-sm opacity-75 mt-2 text-left">Preparación activa: receta mental, pasos e ingredientes al mismo tiempo —como un agente ante un objetivo</figcaption>
</figure>

<!--
Analogía: agente = quien interpreta el prompt, planifica y orquesta. Imagen: Unsplash (Getty) — misma foto que https://unsplash.com/photos/CPvzjNGg0Dk; revisa términos Unsplash+ si aplica a tu uso.
-->

---
layout: two-cols
layoutClass: gap-10 items-center
transition: fade-out
level: 2
---

# Multi-Agents

Los **multi-agentes** son como un **equipo multidisciplinario en cocina**: no hay un solo perfil que lo haga todo. Hay quien domina **salados**, quien lleva **postres y repostería**, quien aporta **otra tradición o estación** —como en un formato tipo ***MasterChef***, con especialidades y pruebas distintas en paralelo— y **todos coordinan** para cumplir **un mismo objetivo** (el servicio, el menú, la experiencia del comensal).

Cada “agente” aporta su criterio y sus herramientas; el valor está en **cómo se reparten tareas, se comunican y se alinean** sin trabar la cocina.

::right::

<figure class="m-0 pr-2">
  <img
    src="/multi-agents/chef-group-table.jpg"
    alt="Grupo de chefs de pie junto a una mesa de trabajo: equipo multidisciplinario reunido"
    class="rounded-lg object-cover w-full max-h-80 shadow-md"
  />
  <figcaption class="text-sm opacity-75 mt-2 text-left">Varios perfiles, un mismo equipo —como agentes distintos con un objetivo común</figcaption>
</figure>

<!--
Imagen: Unsplash (CET / ceteduvn) — https://unsplash.com/photos/group-of-chef-standing-beside-table-47Q3QfM5Eh4
-->

---
transition: slide-up
level: 2
---

# Navigation

Hover on the bottom-left corner to see the navigation's controls panel, [learn more](https://sli.dev/guide/ui#navigation-bar)

## Keyboard Shortcuts

|                                                     |                             |
| --------------------------------------------------- | --------------------------- |
| <kbd>right</kbd> / <kbd>space</kbd>                 | next animation or slide     |
| <kbd>left</kbd>  / <kbd>shift</kbd><kbd>space</kbd> | previous animation or slide |
| <kbd>up</kbd>                                       | previous slide              |
| <kbd>down</kbd>                                     | next slide                  |

<!-- https://sli.dev/guide/animations.html#click-animation -->
<img
  v-click
  class="absolute -bottom-9 -left-7 w-80 opacity-50"
  src="https://sli.dev/assets/arrow-bottom-left.svg"
  alt=""
/>
<p v-after class="absolute bottom-23 left-45 opacity-30 transform -rotate-10">Here!</p>

---
layout: two-cols
layoutClass: gap-16
---

# Table of contents

You can use the `Toc` component to generate a table of contents for your slides:

```html
<Toc minDepth="1" maxDepth="1" />
```

The title will be inferred from your slide content, or you can override it with `title` and `level` in your frontmatter.

::right::

<Toc text-sm minDepth="1" maxDepth="2" />

---
layout: image-right
image: https://cover.sli.dev
---

# Code

Use code snippets and get the highlighting directly, and even types hover!

```ts [filename-example.ts] {all|4|6|6-7|9|all} twoslash
// TwoSlash enables TypeScript hover information
// and errors in markdown code blocks
// More at https://shiki.style/packages/twoslash
import { computed, ref } from 'vue'

const count = ref(0)
const doubled = computed(() => count.value * 2)

doubled.value = 2
```

<arrow v-click="[4, 5]" x1="350" y1="310" x2="195" y2="342" color="#953" width="2" arrowSize="1" />

<!-- This allow you to embed external code blocks -->
<<< @/snippets/external.ts#snippet

<!-- Footer -->

[Learn more](https://sli.dev/features/line-highlighting)

<!-- Inline style -->
<style>
.footnotes-sep {
  @apply mt-5 opacity-10;
}
.footnotes {
  @apply text-sm opacity-75;
}
.footnote-backref {
  display: none;
}
</style>

<!--
Notes can also sync with clicks

[click] This will be highlighted after the first click

[click] Highlighted with `count = ref(0)`

[click:3] Last click (skip two clicks)
-->

---
level: 2
---

# Shiki Magic Move

Powered by [shiki-magic-move](https://shiki-magic-move.netlify.app/), Slidev supports animations across multiple code snippets.

Add multiple code blocks and wrap them with <code>````md magic-move</code> (four backticks) to enable the magic move. For example:

````md magic-move {lines: true}
```ts {*|2|*}
// step 1
const author = reactive({
  name: 'John Doe',
  books: [
    'Vue 2 - Advanced Guide',
    'Vue 3 - Basic Guide',
    'Vue 4 - The Mystery'
  ]
})
```

```ts {*|1-2|3-4|3-4,8}
// step 2
export default {
  data() {
    return {
      author: {
        name: 'John Doe',
        books: [
          'Vue 2 - Advanced Guide',
          'Vue 3 - Basic Guide',
          'Vue 4 - The Mystery'
        ]
      }
    }
  }
}
```

```ts
// step 3
export default {
  data: () => ({
    author: {
      name: 'John Doe',
      books: [
        'Vue 2 - Advanced Guide',
        'Vue 3 - Basic Guide',
        'Vue 4 - The Mystery'
      ]
    }
  })
}
```

Non-code blocks are ignored.

```vue
<!-- step 4 -->
<script setup>
const author = {
  name: 'John Doe',
  books: [
    'Vue 2 - Advanced Guide',
    'Vue 3 - Basic Guide',
    'Vue 4 - The Mystery'
  ]
}
</script>
```
````

---

# Components

<div grid="~ cols-2 gap-4">
<div>

You can use Vue components directly inside your slides.

We have provided a few built-in components like `<Tweet/>` and `<Youtube/>` that you can use directly. And adding your custom components is also super easy.

```html
<Counter :count="10" />
```

<!-- ./components/Counter.vue -->
<Counter :count="10" m="t-4" />

Check out [the guides](https://sli.dev/builtin/components.html) for more.

</div>
<div>

```html
<Tweet id="1390115482657726468" />
```

<Tweet id="1390115482657726468" scale="0.65" />

</div>
</div>

<!--
Presenter note with **bold**, *italic*, and ~~striked~~ text.

Also, HTML elements are valid:
<div class="flex w-full">
  <span style="flex-grow: 1;">Left content</span>
  <span>Right content</span>
</div>
-->

---
class: px-20
---

# Themes

Slidev comes with powerful theming support. Themes can provide styles, layouts, components, or even configurations for tools. Switching between themes by just **one edit** in your frontmatter:

<div grid="~ cols-2 gap-2" m="t-2">

```yaml
---
theme: default
---
```

```yaml
---
theme: seriph
---
```

<img border="rounded" src="https://github.com/slidevjs/themes/blob/main/screenshots/theme-default/01.png?raw=true" alt="">

<img border="rounded" src="https://github.com/slidevjs/themes/blob/main/screenshots/theme-seriph/01.png?raw=true" alt="">

</div>

Read more about [How to use a theme](https://sli.dev/guide/theme-addon#use-theme) and
check out the [Awesome Themes Gallery](https://sli.dev/resources/theme-gallery).

---

# Clicks Animations

You can add `v-click` to elements to add a click animation.

<div v-click>

This shows up when you click the slide:

```html
<div v-click>This shows up when you click the slide.</div>
```

</div>

<br>

<v-click>

The <span v-mark.red="3"><code>v-mark</code> directive</span>
also allows you to add
<span v-mark.circle.orange="4">inline marks</span>
, powered by [Rough Notation](https://roughnotation.com/):

```html
<span v-mark.underline.orange>inline markers</span>
```

</v-click>

<div mt-20 v-click>

[Learn more](https://sli.dev/guide/animations#click-animation)

</div>

---

# Motions

Motion animations are powered by [@vueuse/motion](https://motion.vueuse.org/), triggered by `v-motion` directive.

```html
<div
  v-motion
  :initial="{ x: -80 }"
  :enter="{ x: 0 }"
  :click-3="{ x: 80 }"
  :leave="{ x: 1000 }"
>
  Slidev
</div>
```

<div class="w-60 relative">
  <div class="relative w-40 h-40">
    <img
      v-motion
      :initial="{ x: 800, y: -100, scale: 1.5, rotate: -50 }"
      :enter="final"
      class="absolute inset-0"
      src="https://sli.dev/logo-square.png"
      alt=""
    />
    <img
      v-motion
      :initial="{ y: 500, x: -100, scale: 2 }"
      :enter="final"
      class="absolute inset-0"
      src="https://sli.dev/logo-circle.png"
      alt=""
    />
    <img
      v-motion
      :initial="{ x: 600, y: 400, scale: 2, rotate: 100 }"
      :enter="final"
      class="absolute inset-0"
      src="https://sli.dev/logo-triangle.png"
      alt=""
    />
  </div>

  <div
    class="text-5xl absolute top-14 left-40 text-[#2B90B6] -z-1"
    v-motion
    :initial="{ x: -80, opacity: 0}"
    :enter="{ x: 0, opacity: 1, transition: { delay: 2000, duration: 1000 } }">
    Slidev
  </div>
</div>

<!-- vue script setup scripts can be directly used in markdown, and will only affects current page -->
<script setup lang="ts">
const final = {
  x: 0,
  y: 0,
  rotate: 0,
  scale: 1,
  transition: {
    type: 'spring',
    damping: 10,
    stiffness: 20,
    mass: 2
  }
}
</script>

<div
  v-motion
  :initial="{ x:35, y: 30, opacity: 0}"
  :enter="{ y: 0, opacity: 1, transition: { delay: 3500 } }">

[Learn more](https://sli.dev/guide/animations.html#motion)

</div>

---

# $\LaTeX$

$\LaTeX$ is supported out-of-box. Powered by [$\KaTeX$](https://katex.org/).

<div h-3 />

Inline $\sqrt{3x-1}+(1+x)^2$

Block
$$ {1|3|all}
\begin{aligned}
\nabla \cdot \vec{E} &= \frac{\rho}{\varepsilon_0} \\
\nabla \cdot \vec{B} &= 0 \\
\nabla \times \vec{E} &= -\frac{\partial\vec{B}}{\partial t} \\
\nabla \times \vec{B} &= \mu_0\vec{J} + \mu_0\varepsilon_0\frac{\partial\vec{E}}{\partial t}
\end{aligned}
$$

[Learn more](https://sli.dev/features/latex)

---

# Diagrams

You can create diagrams / graphs from textual descriptions, directly in your Markdown.

<div class="grid grid-cols-4 gap-5 pt-4 -mb-6">

```mermaid {scale: 0.5, alt: 'A simple sequence diagram'}
sequenceDiagram
    Alice->John: Hello John, how are you?
    Note over Alice,John: A typical interaction
```

```mermaid {theme: 'neutral', scale: 0.8}
graph TD
B[Text] --> C{Decision}
C -->|One| D[Result 1]
C -->|Two| E[Result 2]
```

```mermaid
mindmap
  root((mindmap))
    Origins
      Long history
      ::icon(fa fa-book)
      Popularisation
        British popular psychology author Tony Buzan
    Research
      On effectiveness<br/>and features
      On Automatic creation
        Uses
            Creative techniques
            Strategic planning
            Argument mapping
    Tools
      Pen and paper
      Mermaid
```

```plantuml {scale: 0.7}
@startuml

package "Some Group" {
  HTTP - [First Component]
  [Another Component]
}

node "Other Groups" {
  FTP - [Second Component]
  [First Component] --> FTP
}

cloud {
  [Example 1]
}

database "MySql" {
  folder "This is my folder" {
    [Folder 3]
  }
  frame "Foo" {
    [Frame 4]
  }
}

[Another Component] --> [Example 1]
[Example 1] --> [Folder 3]
[Folder 3] --> [Frame 4]

@enduml
```

</div>

Learn more: [Mermaid Diagrams](https://sli.dev/features/mermaid) and [PlantUML Diagrams](https://sli.dev/features/plantuml)

---
foo: bar
dragPos:
  square: 691,32,167,_,-16
---

# Draggable Elements

Double-click on the draggable elements to edit their positions.

<br>

###### Directive Usage

```md
<img v-drag="'square'" src="https://sli.dev/logo.png">
```

<br>

###### Component Usage

```md
<v-drag text-3xl>
  <div class="i-carbon:arrow-up" />
  Use the `v-drag` component to have a draggable container!
</v-drag>
```

<v-drag pos="663,206,261,_,-15">
  <div text-center text-3xl border border-main rounded>
    Double-click me!
  </div>
</v-drag>

<img v-drag="'square'" src="https://sli.dev/logo.png">

###### Draggable Arrow

```md
<v-drag-arrow two-way />
```

<v-drag-arrow pos="67,452,253,46" two-way op70 />

---
src: ./pages/imported-slides.md
hide: false
---

---

# Monaco Editor

Slidev provides built-in Monaco Editor support.

Add `{monaco}` to the code block to turn it into an editor:

```ts {monaco}
import { ref } from 'vue'
import { emptyArray } from './external'

const arr = ref(emptyArray(10))
```

Use `{monaco-run}` to create an editor that can execute the code directly in the slide:

```ts {monaco-run}
import { version } from 'vue'
import { emptyArray, sayHello } from './external'

sayHello()
console.log(`vue ${version}`)
console.log(emptyArray<number>(10).reduce(fib => [...fib, fib.at(-1)! + fib.at(-2)!], [1, 1]))
```

---
layout: center
class: text-center
---

# Learn More

[Documentation](https://sli.dev) · [GitHub](https://github.com/slidevjs/slidev) · [Showcases](https://sli.dev/resources/showcases)

<PoweredBySlidev mt-10 />
