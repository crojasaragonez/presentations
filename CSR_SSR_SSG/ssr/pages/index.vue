<template>
  <div class="container mx-auto">
    <h1 class="text-3xl text-center my-5">Server-Side Rendering (SSR) Example</h1>
    <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 xl:grid-cols-5 gap-5">
      <div v-for="pokemon in pokemons" :key="pokemon.id" class="m-4">
        <div class="rounded overflow-hidden shadow-lg hover:shadow-xl transition-shadow duration-300">
          <div class="p4">
            <p class="text-center text-gray-700 text-base">
              ID: {{ pokemon.id }}
            </p>
          </div>
          <img :src="pokemon.picture" :alt="`Image of ${pokemon.name}`" class="w-full" loading="lazy">
          <div class="px-6 py-4">
            <div class="text-center font-bold text-xl mb-2 capitalize">{{ pokemon.name }}</div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';

interface Pokemon {
  id: number;
  name: string;
  picture: string;
}

export default Vue.extend({
  async asyncData() {
    try {
      const response = await fetch('https://pokeapi.co/api/v2/pokemon?limit=15');
      const data = await response.json();
      const pokemons: Pokemon[] = data.results.map((pokemon: Pokemon, index: number) => ({
        id: index + 1,
        name: pokemon.name,
        picture: `https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/${index + 1}.png`
      }));
      return { pokemons } ;
    } catch (error) {
      console.error('Error fetching Pokemon data:', error);
    }
  }
})
</script>
