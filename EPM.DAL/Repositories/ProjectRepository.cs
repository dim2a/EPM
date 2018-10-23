using EPM.DAL.EF;
using EPM.DAL.Entities;
using EPM.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPM.DAL.Repositories
{
    public class ProjectRepository : IRepository<Project>
    {
        private DataContext db;

        public ProjectRepository(DataContext context)
        {
            this.db = context;
        }

        public IEnumerable<Project> GetAll()
        {
            return db.Projects;
        }

        public Project GetById(int id)
        {
            try
            {
                return db.Projects.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Create(Project item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> Find(Func<Project, bool> predicate)
        {
            throw new NotImplementedException();
        }
        
        public void Update(Project item)
        {
            throw new NotImplementedException();
        }
    }
}
