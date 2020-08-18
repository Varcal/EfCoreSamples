using EfCoreSample.App.Entidades;
using EfCoreSample.App.Mappings;
using Microsoft.EntityFrameworkCore;

namespace EfCoreSample.App.Contexts
{
    public class MySqlContext: DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Caderno> Cadernos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connStr = @"Server=localhost;Database=ZabbixDb;Uid=root;Pwd=Admin@123;";
            optionsBuilder.UseMySql(connStr);
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
