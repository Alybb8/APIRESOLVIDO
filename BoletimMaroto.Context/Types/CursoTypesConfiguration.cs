using BoletimModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoletimMaroto.Context.Types
{
    public class CursoTypesConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(q => q.Id);

            builder.Property(q => q.Nome).HasMaxLength(100);
            builder.Property(q => q.Situacao).HasMaxLength(100);

        }
    }
}
