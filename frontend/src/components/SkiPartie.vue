<template>
  <div v-if="infoPartii && infoPartii.length">
    <h2>Partii pentru stațiune:</h2>
    <ul>
      <li v-for="(partie, index) in infoPartii" :key="index">
        {{ partie.nume }} - dificultate: {{ partie.gradDificultate }}
      </li>
    </ul>
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

ul {
  list-style-type: none; /* Elimină bullet-urile listei */
  padding: 0;
}

li {
  background-color: #2c3e50; /* Adaugă o culoare de fundal pentru fiecare element al listei */
  margin-bottom: 10px;
  padding: 10px;
  border-radius: 5px; /* Rotunjește colțurile */
  box-shadow: 0 2px 4px rgba(0,0,0,.1); /* Adaugă o umbră ușoară */
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
