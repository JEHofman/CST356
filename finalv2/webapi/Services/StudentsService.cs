using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Database.Entities;
using EmployeesBusinessRules;
public class ServicesService : IServicesService
{
    private readonly IEmployeesRepository _employeesRespository;

    public ServicesService(IEmployeesRepository employeeRepository)
    {
        _employeesRespository = employeeRepository;
    }

    public List<ServicesDto> GetAllServices()
    {
        var serviceDtos = new List<ServicesDto>();

        foreach(var employees in _employeesRespository.GetAllEmployees())
        {
            serviceDtos.Add(new ServicesDto {
                First = employees.First,
                Last = employees.Last,
                Special = BusinessRules.Special(employees)
            });
            if (BusinessRules.Special(employees))
            {
                return serviceDtos;
            }
        }

        return serviceDtos;
    }
}