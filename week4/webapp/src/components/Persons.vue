<template>
<div>

<h2>People</h2>

<table>
  <tr>
    <th>First</th>
    <th>Middle Init.</th>
    <th>Last</th>
  </tr>
  <tr>
    <td>Robert</td>
    <td>E</td>
    <td>Lee</td>
  </tr>
  <tr>
    <td>Ghengis</td>
    <td>A</td>
    <td>Khan</td>
  </tr>
  <tr>
    <td>Sun</td>
    <td>E</td>
    <td>Tzu</td>
  </tr>
  <tr>
    <td>Adolf</td>
    <td>N/A</td>
    <td>Hitler</td>
  </tr>
  <tr>
    <td>David</td>
    <td>G</td>
    <td>Farragut</td>
  </tr>
  <tr>
    <td>Thomas</td>
    <td>K </td>
    <td>Jefferson</td>
  </tr>
</table>
</div>
</template>

<script>
export default {
  name: 'Home',
  data () {
    return {
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>
table {
  font-family: arial, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

td, th {
  border: 1px solid #dddddd;
  text-align: left;
  padding: 8px;
}

tr:nth-child(even) {
  background-color: #2d2bcc6b;
}

body {
  background-color: lightseagreen;
}

h1 {
  color: yellowgreen;
  text-align: center;
}

p {
  font-family: verdana;
  font-size: 20px;
}
</style>