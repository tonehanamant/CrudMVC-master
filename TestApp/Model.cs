namespace CrudMVC
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelBD")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Departments)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Department>()
                .Property(e => e.Qualification)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Salary)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Contact)
                .IsUnicode(false);
        }
    }
}
