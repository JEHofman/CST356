<template>
    <div>
        <h2 class='section-heading'>Projects</h2>
        <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Address</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="project in projects" :key="project.id">
                    <td>{{ project.name }}</td>
                    <td>{{ project.address}}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import Vue from 'vue';

    export default {
        name: 'Projects',
        
        data () {
            return {
                projects: []
            }
        },

        methods: {
            getProjects: function() {
                let projectsApi = process.env.PROJECTS_API;

                Vue.axios.get(projectsApi).then(
                    (response) => {
                        console.log(response)
                        this.projects = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );  
            }
        },

        mounted() {
            this.getProjects();
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