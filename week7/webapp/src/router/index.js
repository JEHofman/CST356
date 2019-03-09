import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'
import Persons from '@/components/Persons'
import Students from '@/components/Students'
import Callback from '@/components/Callback'

Vue.use(Router)

export default new Router({
  mode: 'history',
  routes: [
    {
      path: '/home',
      component: Home
    },

    {
      path: '/persons',
      component: Persons
    },

    {
      path: '/students',
      component: Students
    },

    {
      path: '/callback',
      component: Callback
    }
  ]
})
