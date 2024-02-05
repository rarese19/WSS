<template>
  <div class="register-container">
    <div class="register-form">
      <h1>Register</h1>
      <form @submit.prevent="register">
        <div>
          <label for="nume">Nume:</label>
          <input type="text" id="nume" v-model="nume" required>
        </div>
        <div>
          <label for="prenume">Prenume:</label>
          <input type="text" id="prenume" v-model="prenume" required>
        </div>
        <div>
          <label for="userName">UserName:</label>
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
      await router.push({name: "home"});
    };

    return {nume, prenume, userName, email, password, register };
  },
});
</script>

<style scoped>
.register-container {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  background-color: #282828;
}

.register-form {
  background: #2c3e50;
  padding: 40px;
  border-radius: 10px;
  box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
  width: 400px;
  max-width: 90%;
  font-weight: bold;
  color: white;
}

.register-form h1 {
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
