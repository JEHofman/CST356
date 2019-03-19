'use strict'
const merge = require('webpack-merge')
const prodEnv = require('./prod.env')

module.exports = merge(prodEnv, {
  NODE_ENV: '"development"',
  EMPLOYEES_API: '"http://localhost:5000/api/Employees"',
  SERVICES_API: '"http://localhost:5000/api/Services"',
  PROJECTS_API: '"http://localhost:5000/api/Projects"'
})
