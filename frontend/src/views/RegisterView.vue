<template>
  <div>
    <h1>Register</h1>
    <form @submit.prevent="register">
      <div>
        <label for="Nume">Nume:</label>
        <input id="nume" v-model="nume" required>
      </div>
      <div>
        <label for="Prenume">Prenume:</label>
        <input id="prenume" v-model="prenume" required>
      </div>
      <div>
        <label for="UserName">UserName:</label>
        <input id="userName" v-model="userName" required>
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
      console.log(email.value, password.value);
    };

    return {nume, prenume, userName, email, password, register };
  },
});
</script>
