<template>
  <div class="home-page">
    <nav class="navbar">
      <div class="logo">WSS</div>
      <div v-if="username">
        Welcome back, {{ username }}!
        <button @click="logout" class="logout-button">Logout</button>
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
      localStorage.removeItem('userName');
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
  font-size: 30px;
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

.logout-button {
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
.navbar {
  background-color: #2c3e50; /* Schimbă culoarea de fundal */
  box-shadow: 0 2px 4px rgba(0,0,0,.1); /* Adaugă o umbră pentru a crea adâncime */
}

.logo {
  color: #ecf0f1; /* Schimbă culoarea textului pentru logo */
}

.login-button, .logout-button {
  background-color: #3498db; /* Culoare mai vibrantă pentru butoane */
  transition: background-color .3s ease; /* Adaugă o tranziție pentru butoane */
}

.login-button:hover, .logout-button:hover {
  background-color: #2980b9; /* Schimbă culoarea la hover */
}
</style>