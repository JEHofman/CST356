using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Database;
using Database.Entities;
using System;

public class ProjectsRepository : IProjectsRepository
{
    private readonly ECommerceContext _dbContext;

    public ProjectsRepository(ECommerceContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Projects> GetAllProjects()
    {
        try
        {
            return _dbContext.Project.ToList();
        } 
        catch(Exception ex)
        {
            
            return new List<Projects>();
        }
    }
}