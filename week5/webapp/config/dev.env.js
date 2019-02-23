'use strict'
const merge = require('webpack-merge')
const prodEnv = require('./prod.env')

module.exports = merge(prodEnv, {
  NODE_ENV: '"development"',
  PERSONS_API: '"http://192.168.99.100:8080/api/Persons"',
  STUDENTS_API: '"http://192.168.99.100:8080/api/Students"'
})
