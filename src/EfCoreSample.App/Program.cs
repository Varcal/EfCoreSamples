using System;
using System.Linq;
using EfCoreSample.App.Contexts;
using EfCoreSample.App.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EfCoreSample.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SqlServerContext())
            {
                //context.Alunos.Add(new Aluno()
                //{
                //    Nome = "Cleber Varçal"
                //});

                //context.SaveChanges();

                var caderno = context
                    .Cadernos.Include(x=>x.Aluno)
                    .ToList();
                
                
                var aluno = context.Alunos
                    .Include(x=>x.Cadernos)
                    .Where(x=>x.Nome == "");
                


                
            }
        }
    }
}
