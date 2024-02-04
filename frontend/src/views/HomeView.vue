<script setup lang="ts">
import TheWelcomeNav from '../components/Navbar.vue'
import {allStatiuni} from "@/Helpers/Axios";
import {partiiStatiuni} from "@/Helpers/Axios";
import Statiuni from '../components/Statiuni.vue';
import SkiPartie from '../components/SkiPartie.vue';
import {ref} from "vue";

var statiuni = ref([]);
var partii = ref([]);
var idStatiuneSelectata = ref(null); // Stochează ID-ul stațiunii selectate

const areStatiuniLoaded = ref(false);
const arePartiiLoaded = ref(false);


const handleAllStatiuni = async () => {
  statiuni.value = await allStatiuni();
  areStatiuniLoaded.value = true;
};

await handleAllStatiuni();

const handleClickStatiune = async (id) => {
  idStatiuneSelectata.value = id; // Actualizează ID-ul stațiunii selectate
  partii.value = await partiiStatiuni(id);
  arePartiiLoaded.value = true;
};
</script>

<template>
  <TheWelcomeNav />
  <div v-if="areStatiuniLoaded">
    <Statiuni v-for="(statiune, index) in statiuni"
              :key="index"
              :nume="statiune.nume"
              :id="statiune.id"
              @click-statiune="handleClickStatiune" />
    <!-- Afișează partiile doar dacă idStatiuneSelectata are valoare și partii nu este gol -->
    <SkiPartie v-if="arePartiiLoaded && partii.length > 0"
               :infoPartii="partii" />

  </div>
</template>
