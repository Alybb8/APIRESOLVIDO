using System;
using System.Collections.Generic;

namespace BoletimModels
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Curso { get; set; }

        public virtual ICollection<Nota> ParaNota { get; set; } = new HashSet<Nota>();

    }
}
