<template>
  <div class="home-page">
    <nav class="navbar">
      <div class="logo">WSS</div>
      <div v-if="username">
        Welcome back, {{ username }}! <br>
        <button @click="logout" class="logout-button">Logout</button>
      </div>
      <button v-else @click="goToLogin" class="login-button">Login</button>
      <button v-if="$route.name === 'Basket'" @click="goToHome" class="shoppingList-button">Back Home</button>
      <button v-else @click="gotoShoppingList" class="shoppingList-button">Shopping List</button>
    </nav>

    <section class="content">
      <h1 v-if="$route.name == 'home'">Bine ai venit la WSS!</h1>
    </section>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref, onMounted } from 'vue';
import { useRouter } from 'vue-router';
import ShoppingList from "@/views/ShoppingList.vue";
import router from "@/router";

export default defineComponent({
  name: 'HomePage',
  methods: {
    router() {
      return router
    }
  },
  components: {ShoppingList},
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

    const gotoShoppingList = () => {
      var token = localStorage.getItem('authToken');
      if (!token)
        console.log('eroare');
      else
        router.push('basket');
    };

    const goToHome = () => {
      router.push('/');
    }

    return { username, goToLogin, logout, gotoShoppingList, goToHome };
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
  padding: 2px 16px;
  margin-left: 40px;
  font-size: 16px;
  cursor: pointer;
  background-color: #007bff;
  color: white;
  border: none;
  border-radius: 5px;
  outline: none;
}

.shoppingList-button {
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
  background-color: #2c3e50;
  box-shadow: 0 2px 4px rgba(0,0,0,.1);
}

.logo {
  color: #ecf0f1;
}

.login-button, .logout-button, .shoppingList-button {
  background-color: #3498db;
  transition: background-color .3s ease;
}

.login-button:hover, .logout-button:hover {
  background-color: #2980b9;
}
</style>