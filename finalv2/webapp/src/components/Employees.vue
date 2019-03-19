<template>
    <div>
        <h2 class='section-heading'>Employees</h2>
        <table>
            <thead>
                <tr>
                    <th>First</th>
                    <th>Middile I</th>
                    <th>Last</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="employee in employees" :key="employee.id">
                    <td>{{ employee.first }}</td>
                    <td>{{ employee.last}}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import Vue from 'vue';

    export default {
        name: 'Employees',
        
        data () {
            return {
                employees: []
            }
        },

        methods: {
            getEmployees: function() {
                let employeesApi = process.env.EMPLOYEES_API;

                Vue.axios.get(employeesApi).then(
                    (response) => {
                        console.log(response)
                        this.employees = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );  
            }
        },

        mounted() {
            this.getEmployees();
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