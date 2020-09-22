using BoletimModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoletimMaroto.Context.Models.Associatives
{
    public class CursoMateria
    {
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
    }
}
