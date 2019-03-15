using System;
using Database.Entities;

namespace PersonsBusinessRules {
    public static class BusinessRules
    {
        public static bool Special(Persons person) =>
            person.MiddleI.ToUpper().StartsWith(specialKey);


        public static string specialKey = "K";
    }
}