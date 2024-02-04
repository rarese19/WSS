<script setup lang="ts">
const props = defineProps<{
  id: string,
  nume: string,
  partie: []
}>();

const emit = defineEmits<{
  (e: 'click-statiune', id:string)
}>();
</script>

<template>
    <h1>{{ props.nume }}</h1>
    <button @click="emit('click-statiune', props.id)">More Info</button>

</template>

<style scoped>

</style>