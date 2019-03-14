using System.Collections.Generic;
using Database.Entities;

namespace Database
{
    public static class InMemory
    {
        public static List<Students> students = new List<Students> {
            new Students {
                StudentId = 674801678,
                Email = "Sumguy@SDU.edu",
            },
          new Students {
                StudentId = 785890182,
                Email = "Sumgirl@SDU.edu",
            },
            new Students {
                StudentId = 315758789,
                Email = "AnotherGuy@SDU.edu",
            },
            new Students {
                StudentId = 432678754,
                Email = "ADifferentGuy@SDU.edu",
            },
            new Students {
                StudentId = 437854870,
                Email = "NewGirl@SDU.edu",
            },
            new Students {
                StudentId = 789548795,
                Email = "QuestionMark@SDU.edu",
            },
        };
        public static List<Persons> persons = new List<Persons> {
            new Persons {
                First = "Robert",
                MiddleI = "E",
                Last = "Lee"
            },
           new Persons {
                First = "Ghengis",
                MiddleI = "A",
                Last = "Khan"
            },
             new Persons {
                First = "Sun",
                MiddleI = "E",
                Last = "Tzu"
            },
             new Persons {
                First = "Adolf",
                MiddleI = "N/A",
                Last = "Hitler"
            },
             new Persons {
                First = "David",
                MiddleI = "G",
                Last = "Farragut"
            },
             new Persons {
                First = "Thomas",
                MiddleI = "K",
                Last = "Jefferson"
            },
        };
    }
}