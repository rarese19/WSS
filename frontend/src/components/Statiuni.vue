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
  if (arePartiiLoaded.value && props.idStatiuneSelectata === props.statiune.id) {
    arePartiiLoaded.value = false;
    emit('update-selected', null);
  } else {
    partii.value = await partiiStatiuni(props.statiune.id);
    if (partii.value.length != 0)
      arePartiiLoaded.value = true;
    emit('update-selected', props.statiune.id);
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

<style scoped>
button {
  transition: background-color .3s ease;
  padding: 8px 16px;
  font-size: 16px;
  cursor: pointer;
  background-color: #007bff;
  color: white;
  border: none;
  border-radius: 5px;
  outline: none;
}

button:hover {
  background-color: #2980b9;
}
</style>