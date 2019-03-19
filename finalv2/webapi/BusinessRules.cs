using System;
using Database.Entities;

namespace EmployeesBusinessRules {
    public static class BusinessRules
    {
        public static bool Special(Employees employee) =>
            employee.First.StartsWith(specialKey);


        public static string specialKey = "Ray";
    }
}