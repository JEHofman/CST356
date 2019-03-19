<template>
    <div>
        <h2 class='section-heading'>Services</h2>
        <table>
            <thead>
                <tr>
                    <th>Item</th>
                    <th>Type</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="service in services" :key="service.id">
                    <td>{{ service.name }}</td>
                    <td>{{ service.address}}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import Vue from 'vue';

    export default {
        name: 'Services',
        
        data () {
            return {
                services: []
            }
        },

        methods: {
            getServices: function() {
                let servicesApi = process.env.SERVICES_API;

                Vue.axios.get(servicessApi).then(
                    (response) => {
                        console.log(response)
                        this.services = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );  
            }
        },

        mounted() {
            this.getServices();
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