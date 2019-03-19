<template>
  <div>
    <nav>
      <router-link class="spacing" v-for="routes in links" 
      v-bind:key="routes.id"
      :to="`${routes.page}`">
      
      {{routes.text}}
      </router-link>
    </nav>
  </div>
</template>

<script>
export default {
  name: 'Navigation',
  data() {
    return {
      links: [
        {
          id: 1,
          text: 'Home',
          page:'/Home'
        },
        {
          id: 2,
          text: 'AboutUs',
          page:'/AboutUs'
        },
        {
          id: 3,
          text: 'Employees',
          page:'/Employees'
        },
        {
          id: 4,
          text: 'Services',
          page:'/Services'
        },
        {
          id: 5,
          text: 'Projects',
          page:'/Projects'
        },
        {
          id: 6,
          text: 'Photos',
          page: '/Photos'
        }
      ]
    }
  }
}
</script>

<style> 
  .spacing { 
  Margin-right: 10px;
  float: left;
  display: block;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none; 
  border: 3px solid yellow;
  } 

nav{
  list-style-type: none;
  margin: 0;
  padding: 0;
  overflow: hidden;
  background-color: rgb(4, 3, 102);
  position: fixed;
  top: 0;
  width: 100%;
}

</style>