using BoletimMaroto.Context.Models.Associatives;
using BoletimModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoletimMaroto.Context
{
    public class BoletimMarotoContext : DbContext
    {
        public BoletimMarotoContext()
        {
        }
        public BoletimMarotoContext(DbContextOptions<BoletimMarotoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NT-04809\\SQLEXPRESS; Initial Catalog=BoletimMaroto;Integrated Secutiry=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BoletimMarotoContext).Assembly);

            modelBuilder.Entity<Nota>()
                .HasOne(q => q.Alunos)
                .WithMany(b => b.ParaNota)
                .HasForeignKey(p => p.IdAluno);

            modelBuilder.Entity<Nota>()
                .HasOne(q => q.Materia)
                .WithMany(q => q.ParaNota)
                .HasForeignKey(q => q.IdMateria);

            modelBuilder.Entity<CursoMateria>()
                .HasKey(sc => new { sc.CursoId, sc.MateriaId });
           
        }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Nota> Nota { get; set; }
    }
}
