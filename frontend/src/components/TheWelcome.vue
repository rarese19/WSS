<template>
  <div class="home-page">
    <nav class="navbar">
      <div class="logo">WSS</div>
      <div v-if="username">
        Welcome back, {{ username }}!
        <button @click="logout">Logout</button>
      </div>
      <button v-else @click="goToLogin" class="login-button">Login</button>
    </nav>
    <!-- Conținutul paginii de home -->
    <section class="content">
      <h1>Bine ai venit la WSS!</h1>
    </section>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref, onMounted } from 'vue';
import { useRouter } from 'vue-router';

export default defineComponent({
  name: 'HomePage',
  setup() {
    const router = useRouter();
    const username = ref(localStorage.getItem('userName'));

    const goToLogin = () => {
      router.push('/login');
    };

    const logout = () => {
      localStorage.removeItem('userName'); // Șterge numele de utilizator din localStorage
      localStorage.removeItem('authToken');
      location.reload();
    };

    return { username, goToLogin, logout };
  }
});
</script>

<style scoped>
.navbar {
  display: flex;
  justify-content: space-between;
  align-items: center;
  background-color: #333;
  color: #fff;
  padding: 10px 20px;
}

.logo {
  font-size: 24px;
  font-weight: bold;
}

.login-button {
  padding: 8px 16px;
  font-size: 16px;
  cursor: pointer;
  background-color: #007bff;
  color: white;
  border: none;
  border-radius: 5px;
  outline: none;
}

.content {
  text-align: center;
  margin-top: 20px;
}
</style>