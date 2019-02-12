<template>
<div>

<h2 class='section-heading'>Students</h2>

<table>
  <thead>
    <tr>
      <th>Student ID</th>
      <th>Email Address</th>
    </tr>
  </thead>
  <tbody>
    <tr v-for="student in students" :key="student.id">
      <td>{{ student.id }}</td>
      <td>{{ student.email }}</td>
    </tr>
  </tbody>
</table>
 
</div>
</template>

<script>
export default {
  name: 'Students',
    mounted() {
      this.students = getStudents();
      },
    data () {
      return {
      students: []
        }
      }
    }
   function getStudents() {
    return JSON.parse(testStudents).students;
    }
    var testStudents = {
      "students": [
      {"id": "674801678","email": "Sumguy@SDU.edu"},
      {"id": "785890182","email": "Sumgirl@SDU.edu"},
      {"id": "315758789","email": "AnotherGuy@SDU.edu"},
      {"id": "432678754","email": "ADifferentGuy@SDU.edu"},
      {"id": "437854870","email": "NewGirl@SDU.edu"},
      {"id": "789548795","email": "QuestionMark@SDU.edu"}
      ]
    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
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