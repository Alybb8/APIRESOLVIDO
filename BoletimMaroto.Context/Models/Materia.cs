using BoletimMaroto.Context.Models.Associatives;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoletimModels
{
    public class Materia
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Situacao { get; set; }

    

        public virtual ICollection<CursoMateria> CursoMateria { get; set; } = new HashSet<CursoMateria>();
        public virtual ICollection<Nota> ParaNota { get; set; } = new HashSet<Nota>();

    }
}
