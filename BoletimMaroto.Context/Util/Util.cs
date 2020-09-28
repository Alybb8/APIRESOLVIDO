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

        public List<Aluno> GetAlunos(string alunos)
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                return boletimMaroto.Aluno.Where(x => x.Nome.Equals(alunos)).ToList();
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

        public List<Curso> GetAllCursos(string nomeCurso)
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                return boletimMaroto.Curso.Where(x=>x.Nome.Equals(nomeCurso)).ToList();
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

        public List<Nota> GetInfosByName(string nomeAluno)//imprimindo Nota por nome, não sei se faz sentido Id?
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                return boletimMaroto.Nota.Where(x => x.Alunos.Equals(nomeAluno)).ToList();
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

        public string ExcludeMateriaByName(string descricao)
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                var excludeMateria = boletimMaroto.Materia.FirstOrDefault(x => x.Descricao == descricao);
                if (excludeMateria != null)
                {
                    boletimMaroto.Materia.Remove(excludeMateria);
                    boletimMaroto.SaveChanges();
                    return ReturnMessages.Success;
                }
                else
                    return ReturnMessages.NoSuccess;
            }
        }

        public string ExcludeNota(int id)
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                var excludeNota = boletimMaroto.Nota.FirstOrDefault(x => x.Id == id);
                if (excludeNota != null)
                {
                    boletimMaroto.Nota.Remove(excludeNota);
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

        public bool UpdateAluno(int idAluno, string novoAluno)
        {
            boletimMaroto = new BoletimMarotoContext();//cria conexão com o banco
            using (boletimMaroto)//fecha a conexão com o banco
            {
                var aluno = boletimMaroto.Aluno.FirstOrDefault(q => q.Id == idAluno);//selecionando o primeiro Id que é igual ao idAluno e retornando o objeto
                if (aluno != null)//se não for nulo
                {
                    aluno.Nome = novoAluno;//substitui o dado do aluno
                    boletimMaroto.Update(aluno);//insere o update
                    return true;
                }
                else
                    return false;
            }
        }

        public bool UpdateCurso(int idCurso, string nomeCurso)
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                var curso = boletimMaroto.Curso.FirstOrDefault(q => q.Id == idCurso);
                if (curso != null)
                {
                    curso.Nome = nomeCurso;
                    boletimMaroto.Update(curso);
                    return true;
                }
                else
                    return false;
            }
        }

        public bool UpdateMateria(int idCurso, string descricao)
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                var materia = boletimMaroto.Materia.FirstOrDefault(q => q.Id == idCurso);
                if (materia != null)
                {
                    materia.Descricao = descricao;
                    boletimMaroto.Update(materia);
                    return true;
                }
                else
                    return false;
            }
        }

        public bool UpdateNota(int idNota, int notaAluno)
        {
            boletimMaroto = new BoletimMarotoContext();
            using (boletimMaroto)
            {
                var nota = boletimMaroto.Nota.FirstOrDefault(q => q.Id == idNota);
                if (nota != null)
                {
                    nota.NotaDoAluno = notaAluno;
                    boletimMaroto.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
