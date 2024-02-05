<template>
  <div class="login-container">
    <div class="login-form">
      <h1>Login</h1>
      <form @submit.prevent="login">
        <div>
          <label for="email">Email:</label>
          <input type="email" id="email" v-model="email" required>
        </div>
        <div>
          <label for="password">Password:</label>
          <input type="password" id="password" v-model="password" required>
        </div>
        <button type="submit">Login</button>
        <button type="button" class="register" @click="redirect">Register</button>
      </form>
    </div>
  </div>

</template>

<script lang="ts">
import { defineComponent, ref } from 'vue';
import {login as authServiceLogin} from "@/Helpers/Axios";
import { useRouter } from 'vue-router';


export default defineComponent({
  name: 'LoginPage',
  setup() {
    const email = ref('');
    const password = ref('');
    const router = useRouter();
    var token;

    const login = async () => {
      await authServiceLogin(email.value, password.value);
      console.log(email.value, password.value);
      token = localStorage.getItem('authToken');
      if (token) {
        await router.push({name: "home"});
      }
    };

    const redirect = async() => {
      router.push("/register");
    }

    return { email, password, login, redirect };
  },
});
</script>

<style scoped>
.login-container {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  background-color: #282828;
}

.login-form {
  background: #2c3e50;
  padding: 40px;
  border-radius: 10px;
  box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
  width: 400px;
  max-width: 90%;
  font-weight: bold;
  color: white;
}

.login-form h1 {
  font-size: 24px;
  text-align: center;
  color: white;
  margin-bottom: 24px;
  font-weight: bold;
  letter-spacing: 1px;
}

button {
  padding: 10px 20px;
  font-size: 18px;
  cursor: pointer;
  background-color: #0056b3;
  color: white;
  border: none;
  border-radius: 5px;
  outline: none;
  width: 100%;
  margin-top: 10px;
  box-shadow: 0 2px 5px rgba(0, 0, 0, 0.2);
  transition: background-color 0.3s ease;
}

button:hover {
  background-color: #003d82;
}

button:active {
  background-color: #003366;
}

button.register {
  background-color: #28a745;
}

button.register:hover {
  background-color: #218838;
}

button.register:active {
  background-color: #1e7e34;
}

input[type="email"], input[type="password"], input[type="text"] {
  width: 100%;
  padding: 10px;
  margin: 10px 0;
  display: block;
  border: 1px solid #ccc;
  border-radius: 5px;
  box-sizing: border-box;
}
</style>


