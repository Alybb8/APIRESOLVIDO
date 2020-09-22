using BoletimMaroto.Context.Models.Associatives;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoletimModels
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Situacao { get; set; }

      

        public virtual ICollection<CursoMateria> CursoMateria { get; set; } = new HashSet<CursoMateria>();
    }
}
