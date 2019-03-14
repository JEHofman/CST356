using System.Collections.Generic;
using Database.Entities;

public interface IStudentsService
{
    List<StudentsDto> GetAllStudents();
}