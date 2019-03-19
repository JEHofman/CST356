using System.Collections.Generic;
using Database.Entities;

public interface IProjectsRepository
{
    List<Projects> GetAllProjects();
}