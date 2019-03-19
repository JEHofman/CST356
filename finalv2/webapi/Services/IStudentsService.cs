using System.Collections.Generic;
using Database.Entities;

public interface IServicesService
{
    List<ServicesDto> GetAllServices();
}