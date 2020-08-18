using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreSample.App.Entidades
{
    public class Caderno
    {
        public int Codigo { get; set; }
        public string Materia { get; set; }

        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
    }
}
