using EPM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPM.DAL.EF
{
    public class DataContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Entities.DayOfWeek> DaysOfWeek { get; set; }        
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<ParticipationHistory> ParticipationHistories { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<State> States { get; set; }

        static DataContext()
        {
            Database.SetInitializer(new EPMDbInitializer());
        }

        public DataContext(string connectionString)
            : base(connectionString)
        { }
    }

    public class EPMDbInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext db)
        {
            db.DaysOfWeek.Add(new Entities.DayOfWeek { Id = 0, DayName = "Undefined" });
            db.DaysOfWeek.Add(new Entities.DayOfWeek { Id = 1, DayName = "Monday" });
            db.DaysOfWeek.Add(new Entities.DayOfWeek { Id = 1, DayName = "Tuesday" });
            db.DaysOfWeek.Add(new Entities.DayOfWeek { Id = 1, DayName = "Wednesday" });
            db.DaysOfWeek.Add(new Entities.DayOfWeek { Id = 1, DayName = "Thursday" });
            db.DaysOfWeek.Add(new Entities.DayOfWeek { Id = 1, DayName = "Friday" });
            db.DaysOfWeek.Add(new Entities.DayOfWeek { Id = 1, DayName = "Saturday" });
            db.DaysOfWeek.Add(new Entities.DayOfWeek { Id = 1, DayName = "Sunday" });

            db.EmploymentTypes.Add(new EmploymentType { Id = 0, Name = "Undefined" });
            db.EmploymentTypes.Add(new EmploymentType { Id = 1, Name = "Shedule" });
            db.EmploymentTypes.Add(new EmploymentType { Id = 2, Name = "Percent" });

            db.Positions.Add(new Position { PositionId = 0, PositionName = "Undefined" });
            db.Positions.Add(new Position { PositionId = 0, PositionName = "Developer" });
            db.Positions.Add(new Position { PositionId = 0, PositionName = "Tester" });
            db.Positions.Add(new Position { PositionId = 0, PositionName = "Designer" });
            db.Positions.Add(new Position { PositionId = 0, PositionName = "Manager" });

            db.Roles.Add(new Role { RoleId = 0, RoleName = "Undefined" });
            db.Roles.Add(new Role { RoleId = 1, RoleName = "Administrator" });
            db.Roles.Add(new Role { RoleId = 2, RoleName = "Resource Manager" });
            db.Roles.Add(new Role { RoleId = 3, RoleName = "Project Manager" });
            db.Roles.Add(new Role { RoleId = 4, RoleName = "Developer" });

            db.States.Add(new State { StateId = 0, StateName = "Closed" });
            db.States.Add(new State { StateId = 1, StateName = "Open" });

            db.SaveChanges();
        }
    }
}
