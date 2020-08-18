using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreSample.App.Entidades
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Caderno> Cadernos { get; set; }
    }
}
