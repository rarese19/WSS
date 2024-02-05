<script setup lang="ts">
import { defineProps } from 'vue';

const props = defineProps({
  produs: Object
});
const formatPret = (pret: number) => {
  return pret.toFixed(2);
};
</script>

<template>
  <div>
    <h2>{{ produs.nume }}</h2>
    <p>{{ formatPret(produs.pret) }} Lei</p>
  </div>
</template>

<style scoped>
</style>
