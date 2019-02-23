<template>
    <div>
        <h2 class='section-heading'>Persons</h2>
        <table>
            <thead>
                <tr>
                    <th>StudentId</th>
                    <th>Email</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students" :key="student.id">
                    <td>{{ student.studentId }}</td>
                    <td>{{ person.email }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import Vue from 'vue';

    export default {
        name: 'Students',
        
        data () {
            return {
                students: []
            }
        },

        methods: {
            getPersons: function() {
                let studentsApi = process.env.STUDENTS_API;

                Vue.axios.get(students.Api).then(
                    (response) => {
                        console.log(response)
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );  
            }
        },

        mounted() {
            this.getStudents();
        }
    }
</script>

<style scoped>

    table {
        border-collapse: collapse;
    }

    table, th, td {
        border: 1px solid black;
        padding: 10px;
    }

</style>