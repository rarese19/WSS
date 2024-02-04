<script setup lang="ts">
import TheWelcomeNav from '../components/Navbar.vue'
import { allStatiuni } from "@/Helpers/Axios";
import Statiuni from '../components/Statiuni.vue';
import { ref } from "vue";

const statiuni = ref([]);
const idStatiuneSelectata = ref(null); // Stochează ID-ul stațiunii selectate global

const handleAllStatiuni = async () => {
  statiuni.value = await allStatiuni();
};

await handleAllStatiuni();

// Metoda pentru a actualiza ID-ul stațiunii selectate
const updateSelectedStatiuneId = (newId) => {
  // Dacă ID-ul este același cu cel deja selectat, îl resetăm (ascundem pârtiile)
  if (idStatiuneSelectata.value === newId) {
    idStatiuneSelectata.value = null;
  } else {
    idStatiuneSelectata.value = newId;
  }
};
</script>

<template>
  <TheWelcomeNav />
  <div>
    <Statiuni
        v-for="statiune in statiuni"
        :key="statiune.id"
        :statiune="statiune"
        :idStatiuneSelectata="idStatiuneSelectata"
        @update-selected="updateSelectedStatiuneId"
    />
  </div>
</template>
