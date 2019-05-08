namespace day2.EF.CodeFirst
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {

        public ModelContext()
            : base("name=ModelContext") { }
        public virtual DbSet<City> cities { get; set; }
        public virtual DbSet<Country> countries { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserVist> UserVist { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }


    }


}