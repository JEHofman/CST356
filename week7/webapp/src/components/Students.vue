<template>
    <div>
        <h2 class='section-heading'>Students</h2>
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
                    <td>{{ student.email }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import Vue from 'vue';

    export default {
        name: 'Students',
        props: ['auth'],
        
        data () {
            return {
                students: []
            }
        },

        methods: {
            getAuthHeader: function() {
                            return {
                                headers: {
                                    Authorization: 'Bearer ' + this.auth.accessToken
                                }
                            }
                        },

            getStudents: function() {
                let url = process.env.STUDENTS_API;

                Vue.axios.get(url, this.getAuthHeader()).then(
                    (response) => {
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