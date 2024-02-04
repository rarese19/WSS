<template>
  <div v-if="infoPartii && infoPartii.length">
    <h2>Partii pentru stațiune:</h2>
    <ul>
      <li v-for="(partie, index) in infoPartii" :key="index">
        {{ partie.nume }} - {{ partie.dificultate }}
      </li>
    </ul>
  </div>
  <div v-else>
    <p>Nu există pârtii de afișat pentru această stațiune.</p>
  </div>
</template>

<script setup>
const props = defineProps({
  infoPartii: Array
});
</script>

<style scoped>
.partii-container {
  padding: 1rem;
  margin-top: 1rem;
  border: 1px solid #ccc;
  border-radius: 8px;
}

h2 {
  margin-bottom: 0.5rem;
}

li {
  margin-bottom: 1rem;
}

h3 {
  margin: 0;
  color: #333;
}

p {
  margin: 0.25rem 0;
  font-size: 0.9rem;
}
</style>
