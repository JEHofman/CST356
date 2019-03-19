using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;
using Database.Entities;
using Database;
using EmployeesBusinessRules;

public class ServiceServiceTests
{
    private ServicesService _serviceService; // System Under Test (SUT)
    private IEmployeesRepository _employeeRepository; // Mock

    [SetUp]
    public void Setup()
    {
        _employeeRepository = A.Fake<IEmployeesRepository>();

        _serviceService = new ServicesService(_employeeRepository);
    }

    [Test]
    public void ShouldReturnSpecialService()
    {
        var expectedEmployeeName = BusinessRules.specialKey;

        // Arrange
        A.CallTo(() => _employeeRepository.GetAllEmployees()).Returns(
            new List<Employees> {
                new Employees {
                    First = expectedEmployeeName,
                    Last = "Robison",
                    Services = new Services {
                        Item = "Repair/Remodel",
                    }

                }
            }
       );

        // Act
        var servicesDtos = _serviceService.GetAllServices();

        // Assert (FluentAssertions)
        servicesDtos.Single(pdto => pdto.Special).First.Should().Be(expectedEmployeeName);
    }

    [Test]
    public void ShouldNotReturnSpecialService()
    {
       A.CallTo(() => _employeeRepository.GetAllEmployees()).Returns(
            new List<Employees> {
                 new Employees {
                    First = "Dianna",
                    Last = "Robison",
                    Services = new Services {
                        Item = "Admin",
                    }
                }
            }
       );

        var servicesDtos = _serviceService.GetAllServices();

        // Assert (FluentAssertions)
        servicesDtos.Any(pdto => pdto.Special).Should().BeFalse();
    }
}