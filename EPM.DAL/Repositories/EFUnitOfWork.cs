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
    public class EFUnitOfWork : IUnitOfWork
    {
        private DataContext _context;
        private GenericRepository<Employee> _employeeRepository;
        private GenericRepository<Project> _projectRepository;
        private GenericRepository<ParticipationHistory> _participationHistoryRepository;

        public EFUnitOfWork(string connectionString)
        {
            _context = new DataContext(connectionString);
        }

        public GenericRepository<Employee> EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new GenericRepository<Employee>(_context);
                }
                return _employeeRepository;
            }
        }

        public GenericRepository<Project> ProjectRepository
        {
            get
            {
                if (_projectRepository == null)
                {
                    _projectRepository = new GenericRepository<Project>(_context);
                }
                return _projectRepository;
            }
        }

        public GenericRepository<ParticipationHistory> ParticipationHistoryRepository
        {
            get
            {
                if (_participationHistoryRepository == null)
                {
                    _participationHistoryRepository = new GenericRepository<ParticipationHistory>(_context);
                }
                return _participationHistoryRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
