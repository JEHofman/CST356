using System.Collections.Generic;
using Database.Entities;

namespace Database
{
    public static class InMemory
    {
        public static List<Services> services = new List<Services> {
            new Services {
                Item = "Kitchen",
                Type = "Remodel",
            },
            new Services {
                Item = "Bathroom",
                Type = "Remodel",
            },
            new Services {
                Item = "Electrical",
                Type = "Repair",
            },
            new Services {
                Item = "Plumbing",
                Type = "Repair",
            },
            new Services {
                Item = "Home",
                Type = "Repair/Remodel",
            },
            new Services {
                Item = "Exterior",
                Type = "Weatherproofing/Remodel",
            },
        };
        public static List<Employees> employees = new List<Employees> {
            new Employees {
                First = "Ray",
                Last = "Robison"
            },
           new Employees {
                First = "Dianna",
                Last = "Robison"
            },
             new Employees {
                First = "Kyle",
                Last = "Robison"
            },
        };
         public static List<Projects> projects = new List<Projects> {
            new Projects {
                Name = "Vancouver House",
                Address = "7312 NE 71st St Vancouver, WA 98662"
            },
           new Projects {
                Name = "Hayes House",
                Address = "4304 NW Hayes Road Woddland, WA 98674"
            },
        };
    }
}