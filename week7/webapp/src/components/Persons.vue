<template>
    <div>
        <h2 class='section-heading'>Persons</h2>
        <table>
            <thead>
                <tr>
                    <th>First</th>
                    <th>Middile I</th>
                    <th>Last</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="person in persons" :key="person.id">
                    <td>{{ person.first }}</td>
                    <td>{{ person.middile }}</td>
                    <td>{{ person.last}}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import Vue from 'vue';

    export default {
        name: 'Persons',
        props: ['auth'],
        
        data () {
            return {
                persons: []
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

            getPersons: function() {
                let url = process.env.PERSONS_API;

                Vue.axios.get(url, this.getAuthHeader()).then(
                    (response) => {
                        this.persons = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );  
            }
        },

        mounted() {
            this.getPersons();
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