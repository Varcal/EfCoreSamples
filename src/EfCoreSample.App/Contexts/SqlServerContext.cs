using EfCoreSample.App.Entidades;
using EfCoreSample.App.Mappings;
using Microsoft.EntityFrameworkCore;

namespace EfCoreSample.App.Contexts
{
    public class SqlServerContext: DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Caderno> Cadernos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=EfCoreSamplesDb;Trusted_Connection=true;";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new CadernoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
