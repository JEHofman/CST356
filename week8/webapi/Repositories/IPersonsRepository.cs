using System.Collections.Generic;
using Database.Entities;

public interface IPersonsRepository
{
    List<Persons> GetAllPersons();
}