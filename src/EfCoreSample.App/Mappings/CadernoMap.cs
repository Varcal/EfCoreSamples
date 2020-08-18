using System;
using System.Collections.Generic;
using System.Text;
using EfCoreSample.App.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreSample.App.Mappings
{
    public class CadernoMap: IEntityTypeConfiguration<Caderno>
    {
        public void Configure(EntityTypeBuilder<Caderno> builder)
        {
            builder.ToTable("Caderno");

            builder.HasKey(x => x.Codigo);

            builder.Property(x => x.Materia)
                .HasColumnName("NomeMateria")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.AlunoId)
                .HasColumnName("AlunoId")
                .HasColumnType("int")
                .IsRequired();


            builder.HasOne(x => x.Aluno)
                .WithMany(x=>x.Cadernos)
                .HasForeignKey(x => x.AlunoId);
        }
    }
}
