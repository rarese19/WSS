<template>
  <div>
    <h1>Register</h1>
    <form @submit.prevent="register">
      <div>
        <label for="Nume">Nume:</label>
        <input type="text" id="nume" v-model="nume" required>
      </div>
      <div>
        <label for="Prenume">Prenume:</label>
        <input type="text" id="prenume" v-model="prenume" required>
      </div>
      <div>
        <label for="UserName">UserName:</label>
        <input type="text" id="userName" v-model="userName" required>
      </div>
      <div>
        <label for="email">Email:</label>
        <input type="email" id="email" v-model="email" required>
      </div>
      <div>
        <label for="password">Password:</label>
        <input type="password" id="password" v-model="password" required>
      </div>
      <button type="submit">Register</button>
    </form>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref } from 'vue';
import {register as authServiceRegister} from "@/Helpers/Axios";
import {useRouter} from "vue-router";
import router from "@/router";

export default defineComponent({
  name: 'RegisterPage',
  setup() {
    const nume = ref('');
    const prenume = ref('');
    const userName = ref('');
    const email = ref('');
    const password = ref('');

    const register = async () => {
      await authServiceRegister(nume.value, prenume.value, userName.value, email.value, password.value);
      if (nume.value) {
        await router.push({name: "/home"});
      }
    };

    return {nume, prenume, userName, email, password, register };
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