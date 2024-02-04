<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
// Import the functions you need from the SDKs you need
import { getMessaging, getToken, onMessage } from 'firebase/messaging'
import { initializeApp } from "firebase/app";
import { getAnalytics } from "firebase/analytics";
import { store } from './Helpers/Authenticated'
import { useToast } from 'vue-toastification'
import axios from "axios";

const toast = useToast();

// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
  apiKey: "AIzaSyB0CFbiglrZvYZ1Oz7sRmgexLWIvmbd9yY",
  authDomain: "winter-sports-rentals.firebaseapp.com",
  projectId: "winter-sports-rentals",
  storageBucket: "winter-sports-rentals.appspot.com",
  messagingSenderId: "173446246997",
  appId: "1:173446246997:web:627203b24ecd69a7f89adc",
  measurementId: "G-6VM5W82NR8"
};
//BC0W2ery_fxyiK_TG6ydOYaLDhfFpFt4R5ycy1fft7Nkk66ISEfI
// Initialize Firebase
const app = initializeApp(firebaseConfig);
const messaging = getMessaging()
const analytics = getAnalytics(app);
onMessage(messaging, (payload) => {
  toast.info(payload.notification?.body);
})

getToken(messaging, {
  vapidKey:
      'BC0W2ery_fxyiK_TG6ydOYaLDhfFpFt4R5ycy1fft7Nkk66ISEfI'
})
    .then((currentToken) => {
      if (currentToken) {
        if (store.isAuthenticated === true) {
          axios.patch(`User/device-token/${currentToken}`);
          localStorage.setItem('device_token',currentToken);
        }
      } else {
        console.log('No registration token available. Request permission to generate one.')
      }
    })
    .catch((err) => {
      console.log('An error occurred while retrieving token. ', err)
    })
</script>

<template>
  <Suspense>
    <RouterView />
  </Suspense>
</template>

<style scoped>

</style>
