using EPM.BLL.DTO;
using EPM.BLL.Interfaces;
using EPM.DAL.Entities;
using EPM.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPM.BLL.Services
{
    public class ProjectService : IProjectService
    {
        IUnitOfWork DataBase { get; set; }

        public ProjectService(IUnitOfWork uow)
        {
            DataBase = uow;
        }

        public void CreateProject(ProjectDTO item)
        {
            Project project = new Project
            {
                Title = item.Title,
                Description = item.Description,
                StartDate = item.StartDate,
                EndDate = item.EndDate,
                EmploymentType = item.EmploymentType,
                State = item.State
            };
        }

        public void ChangeProject(ProjectDTO item)
        {
            throw new NotImplementedException();
        }

        public void CloseProjectById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteProjectById(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectDTO> GetAllProject()
        {
            throw new NotImplementedException();
        }

        public ProjectDTO GetProjectById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
