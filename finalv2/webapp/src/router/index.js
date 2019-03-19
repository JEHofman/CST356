import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'
import AboutUs from '@/components/AboutUs'
import Employees from '@/components/Employees'
import Services from '@/components/Services'
import Projects from '@/components/Projects'
import Photos from '@/components/Photos'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/home',
      component: Home
    },

    {
      path: '/aboutus',
      component: AboutUs
    },

    {
      path: '/employees',
      component: Employees
    },
    {
      path: '/projects',
      component: Projects
    },
    {
      path: '/services',
      component: Services
    },
    {
      path: '/photos',
      component: Photos
    }
  ]
})
