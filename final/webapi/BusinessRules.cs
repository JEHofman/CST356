using System;
using Database.Entities;

namespace PersonsBusinessRules {
    public static class BusinessRules
    {
        public static bool Special(Persons person) =>
            person.MiddleI.ToLower().StartsWith(specialKey);


        public static string specialKey = "k";
    }
}