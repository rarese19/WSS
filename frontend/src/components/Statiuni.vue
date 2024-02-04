<script setup lang="ts">
import SkiPartie from './SkiPartie.vue';
import { ref } from 'vue';
import { partiiStatiuni } from "@/Helpers/Axios";

const props = defineProps({
  statiune: Object,
  idStatiuneSelectata: Number
});

const emit = defineEmits(['update-selected']);

const partii = ref([]);
const arePartiiLoaded = ref(false);

const handleClickStatiune = async () => {
  // Dacă se face click pe aceeași stațiune, ascundem sau afișăm pârtiile
  if (arePartiiLoaded.value && props.idStatiuneSelectata === props.statiune.id) {
    arePartiiLoaded.value = false;
    emit('update-selected', null); // Resetăm ID-ul stațiunii selectate
  } else {
    partii.value = await partiiStatiuni(props.statiune.id);
    if (partii.value.length != 0)
      arePartiiLoaded.value = true;
    emit('update-selected', props.statiune.id); // Actualizăm ID-ul stațiunii selectate
  }
};
</script>

<template>
  <div>
    <h1>{{ props.statiune.nume }}</h1>
    <button @click="handleClickStatiune">
      {{ arePartiiLoaded && props.idStatiuneSelectata === props.statiune.id ? 'Less Info' : 'More Info' }}
    </button>
    <SkiPartie
        v-if="arePartiiLoaded && props.idStatiuneSelectata === props.statiune.id"
        :infoPartii="partii"
    />
  </div>
</template>
