using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Database;
using Database.Entities;
using System;

public class EmployeesRepository : IEmployeesRepository
{
    private readonly ECommerceContext _dbContext;

    public EmployeesRepository(ECommerceContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Employees> GetAllEmployees()
    {
        try
        {
            return _dbContext.Employee.ToList();
        } 
        catch(Exception ex)
        {
            
            return new List<Employees>();
        }
    }
}