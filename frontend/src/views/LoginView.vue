<template>
  <div>
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
      <button type="button" @click="redirect">Register</button>
    </form>
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
button {
padding: 8px 16px;
font-size: 16px;
cursor: pointer;
background-color: #007bff;
color: white;
border: none;
border-radius: 5px;
outline: none;
}
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
