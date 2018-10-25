using EPM.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPM.BLL.Interfaces
{
    public interface IProjectService
    {
        IEnumerable<ProjectDTO> GetAllProject();
        ProjectDTO GetProjectById(int id);
        void CreateProject(ProjectDTO item);
        void DeleteProjectById(int id);
        void ChangeProject(ProjectDTO item);
        void CloseProjectById(int id);
        void Dispose();
    }
}
