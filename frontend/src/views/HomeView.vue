<script setup lang="ts">
import TheWelcomeNav from '../components/Navbar.vue'
import { allStatiuni } from "@/Helpers/Axios";
import Statiuni from '../components/Statiuni.vue';
import { ref } from "vue";

const statiuni = ref([]);
const idStatiuneSelectata = ref(null);

const handleAllStatiuni = async () => {
  statiuni.value = await allStatiuni();
};

await handleAllStatiuni();


const updateSelectedStatiuneId = (newId) => {
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

<style scoped>
input[type="email"], input[type="password"], input[type="text"] {
  width: 25%;
  padding: 5px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
}

form {
  margin-top: 20px;
}
</style>
