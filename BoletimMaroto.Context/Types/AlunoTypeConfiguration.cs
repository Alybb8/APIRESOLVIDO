using BoletimModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoletimMaroto.Context.Types
{
    public class AlunoTypeConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(q => q.Id);

            builder.Property(q => q.Nome).HasMaxLength(50);
            builder.Property(q => q.Sobrenome).HasMaxLength(100);
            builder.Property(q => q.DataNascimento);
            builder.Property(q => q.Cpf);
            builder.Property(q => q.Curso).HasMaxLength(100);

        }
    }
}
