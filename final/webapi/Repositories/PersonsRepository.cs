using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Database;
using Database.Entities;
using System;

public class PersonsRepository : IPersonsRepository
{
    private readonly ECommerceContext _dbContext;

    public PersonsRepository(ECommerceContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Persons> GetAllPersons()
    {
        try
        {
            return _dbContext.Person.ToList();
        } 
        catch(Exception ex)
        {
            
            return new List<Persons>();
        }
    }
}