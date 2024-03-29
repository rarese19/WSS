import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import loginPage from '@/views/LoginView.vue';
import registerPage from '@/views/RegisterView.vue'
import shoppingList from '@/views/ShoppingList.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView
    },
    {
      path: '/about',
      name: 'about',
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import('../views/AboutView.vue')
    },
    {
      path: '/login',
      name: 'Login',
      component: loginPage
    },
    {
      path: '/register',
      name: 'Register',
      component: registerPage
    },
    {
      path: '/basket',
      name: 'Basket',
      component: shoppingList
    }
  ]
})

export default router
