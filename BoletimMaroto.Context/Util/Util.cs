using BoletimModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoletimMaroto.Context.Util
{
    public class Util<T>
    {
        //--------------
        //      post
        //--------------
        private BoletimMarotoContext boletimMaroto;//criou a conexão com o banco, mas n startou

        public void AddAlunos(Aluno aluno)//adicionando um novo aluno no banco, esse é o método, n tem retorno pois só adiciona
        {
            boletimMaroto = new BoletimMarotoContext();//instanciei o banco e comecei a conexão com o banco
            using (boletimMaroto)//quando terminar as etapas irá desconectar do banco
            {
                boletimMaroto.Aluno.Add(aluno);//adicionando aluno
                boletimMaroto.SaveChanges();//salvando
            }
        }

        public void AddMateria(Materia materia)
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                boletimMaroto.Materia.Add(materia);
                boletimMaroto.SaveChanges();
            }
        }

        public void AddNota(Nota nota)
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                boletimMaroto.Nota.Add(nota);
                boletimMaroto.SaveChanges();
            }
        }

        public void AddCurso(Curso curso)
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                boletimMaroto.Curso.Add(curso);
                boletimMaroto.SaveChanges();
            }
        }

        //---------------
        //      get
        //---------------

        public List<Materia> PrintMateria(int materia)//imprimindo uma matéria em específico
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                return boletimMaroto.Materia.Where(x => x.Id.Equals(materia)).ToList();
            }
        }

        public List<Materia> PrintMaterias()//imprimindo todas as matérias
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                return boletimMaroto.Materia.ToList();
            }
        }

        public List<Aluno> GetAlunos(int alunos)
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                return boletimMaroto.Aluno.Where(x => x.Id.Equals(alunos)).ToList();
            }
        }

        public List<Aluno> GetAllAlunos()
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                return boletimMaroto.Aluno.ToList();
            }
        }

        public List<Curso> GetAllCursos()
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                return boletimMaroto.Curso.ToList();
            }
        }

        public List<Nota> GetInfos()//imprimindo tudo
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                return boletimMaroto.Nota.ToList();
            }
        }

        public List<Nota> GetInfosByName(string nome)//imprimindo Nota por nome, não sei se faz sentido Id?
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                return boletimMaroto.Nota.Where(x => nome.Equals(nome)).ToList();
            }
        }

        //----------------
        //      exclude
        //----------------

        public string ExcludeAlunoById(int idAluno)
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                var excludedAluno = boletimMaroto.Aluno.FirstOrDefault(x => x.Id == idAluno);
                if (excludedAluno != null)
                {
                    boletimMaroto.Aluno.Remove(excludedAluno);//necessário pois se não só remove o campo de Id
                    boletimMaroto.SaveChanges();
                    return ReturnMessages.Success;
                }
                else
                    return ReturnMessages.NoSuccess;
            }
        }

        public string ExcludeCursoByName(string name)
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                var excludeCurso = boletimMaroto.Curso.FirstOrDefault(x => x.Nome == name);
                if (excludeCurso != null)
                {
                    boletimMaroto.Curso.Remove(excludeCurso);
                    boletimMaroto.SaveChanges();
                    return ReturnMessages.Success;
                }
                else
                    return ReturnMessages.NoSuccess;
            }
        }

        //----------------
        //      update
        //----------------

        //public bool UpdateAluno(int idAluno, string novoAluno)
        //{
        //    boletimMaroto = new BoletimMarotoContext();
        //    using (boletimMaroto)
        //    {
        //        var aluno = boletimMaroto.Aluno.FirstOrDefault(q => q.Id == idAluno);

        //        if (aluno != null)
        //        {
        //            aluno.Nome = novoAluno;
        //            boletimMaroto.Update(aluno);
        //        }
        //    }
        //}

    }
}
