using System.Collections.Generic;
using Database.Entities;

public interface IEmployeesRepository
{
    List<Employees> GetAllEmployees();
}