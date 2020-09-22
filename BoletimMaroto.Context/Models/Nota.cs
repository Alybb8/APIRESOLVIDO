

using System.Collections;
using System.Collections.Generic;

namespace BoletimModels
{
    public class Nota
    {
        public int Id { get; set; }
        public int IdAluno { get; set; }
        public virtual Aluno Alunos { get; set; }
        public int IdMateria { get; set; }
        public virtual Materia Materia { get; set; }
        public int NotaDoAluno { get; set; }

       
    }
} 
