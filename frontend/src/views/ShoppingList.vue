<script setup lang="ts">
import { onMounted, ref } from 'vue';
import TheWelcomeNav from '../components/Navbar.vue';
import ProduseUser from '../components/ProduseUser.vue';
import { produseUser } from '@/Helpers/Axios';

const produse = ref([]);


const userId = localStorage.getItem('authToken');

onMounted(async () => {
  produse.value = await produseUser(userId);
});
</script>

<template>
  <TheWelcomeNav />
  <div>
    <ProduseUser
        v-for="produs in produse"
        :key="produs.id"
    :produs="produs"/>
  </div>
</template>
