<template>
  <div id="app">
  <span v-on:click='goToHome'>Home</span> 
  <span v-on:click='goToPersons'>Persons</span> 
  <span v-on:click='goToStudents'>Students</span>
    
    <router-view/>
  </div>
</template>

<script>

  export default {

    name: 'App',

    methods: {

      goToHome: function() {

        this.$router.push({ path: 'home' })

      },

      goToPersons: function() {

        this.$router.push({ path: 'persons' })

      },

      goToStudents: function() {

        this.$router.push({ path: 'students' })

      }

    }

  }

</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
