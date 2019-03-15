using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Database.Entities;
using PersonsBusinessRules;
public class StudentsService : IStudentsService
{
    private readonly IPersonsRepository _personsRespository;

    public StudentsService(IPersonsRepository personRepository)
    {
        _personsRespository = personRepository;
    }

    public List<StudentsDto> GetAllStudents()
    {
        var studentDtos = new List<StudentsDto>();

        foreach(var persons in _personsRespository.GetAllPersons())
        {
            studentDtos.Add(new StudentsDto {
                StudentId = persons.StudentId,
                Email = persons.Students.Email,
                Special = false
            });
            if (BusinessRules.Special(persons))
            {
                return studentDtos;
            }
        }

        return studentDtos;
    }
}