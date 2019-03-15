using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;
using Database.Entities;
using Database;
using PersonsBusinessRules;

public class StudentServiceTests
{
    private StudentsService _studentService; // System Under Test (SUT)
    private IPersonsRepository _personRepository; // Mock

    [SetUp]
    public void Setup()
    {
        _personRepository = A.Fake<IPersonsRepository>();

        _studentService = new StudentsService(_personRepository);
    }

    [Test]
    public void ShouldReturnSpecialStudent()
    {
        var expectedPersonName = BusinessRules.specialKey;

        // Arrange
        A.CallTo(() => _personRepository.GetAllPersons()).Returns(
            new List<Persons> {
                new Persons {
                    First = "Angelina",
                    MiddleI = expectedPersonName,
                    Last = "Jolie",
                    Students = new Students {
                        Email = "Angelina@teamang.com",
                    }

                },
                new Persons {
                    First = "Brad",
                    MiddleI = "J",
                    Last = "Pitt",
                    Students = new Students {
                        Email = "brad@teambrad.com",
                    }
                }
            }
       );

        // Act
        var studentsDtos = _studentService.GetAllStudents();

        // Assert (FluentAssertions)
        studentsDtos.Single(pdto => pdto.Special).MiddleI.Should().Be(expectedPersonName);
    }

    [Test]
    public void ShouldNotReturnSpecialStudent()
    {
       A.CallTo(() => _personRepository.GetAllPersons()).Returns(
            new List<Persons> {
                new Persons {
                    First = "Mark",
                    MiddleI = "A",
                    Last = "Whalberg",
                    Students = new Students {
                        Email = "mark@markymark.com"
                    }

                },
                new Persons {
                    First = "Kim",
                    MiddleI = "B",
                    Last = "Kardashian",
                    Students = new Students {
                        Email = "kim@nobodycares.com"
                    }

                }
            }
       );

        var studentsDtos = _studentService.GetAllStudents();

        // Assert (FluentAssertions)
        studentsDtos.Any(pdto => pdto.Special).Should().BeFalse();
    }
}