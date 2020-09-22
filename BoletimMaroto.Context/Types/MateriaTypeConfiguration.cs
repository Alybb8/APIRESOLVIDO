using BoletimModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BoletimMaroto.Context.Types
{
    public class MateriaTypeConfiguration : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder.HasKey(q => q.Id);

            builder.Property(q => q.Descricao).HasMaxLength(100);
            builder.Property(q => q.DataCadastro);
            builder.Property(q => q.Situacao).HasMaxLength(100);


        }
    }
}
