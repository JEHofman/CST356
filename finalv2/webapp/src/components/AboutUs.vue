<template>
<div>

<h3>Ray Robison - CEO</h3>

<img src="../assets/Ray.jpg" alt="Ray" width="531" height="299" >

<p>Starting out as an electrical contractor, Ray decided to branch off and create
   Statewide Electric. Statewide Electric specialized in residential and 
   commercial electrical installation, service, and repair and was based out of 
   Reno, Nevada. Statewide quickly grew to cover all of Nevada, California, and Idaho.
   </p>

<p>Soon Statewide Electric covered more than electric. Statewide is now capable
  of full house remodeling and repair, covering all aspects from plumbing and tilework, 
  to framing and home expansion. Whatever your project, big or small, Statewide is capable 
  of tackling the most challenging of home renovation projects.</p>

</div>
</template>

<script>
export default {
  name: 'AboutUs',
  data () {
    return {
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>
body {
  background-color: rgb(221, 243, 242);
}

h1 {
  color: yellowgreen;
  text-align: center;
}

p {
  font-family: verdana;
  font-size: 20px;
}

img {
  transform: rotate(90deg);
  float: left;
}

div {
  clear: both;
  padding:20px;
  margin-top:30px;
}
</style>