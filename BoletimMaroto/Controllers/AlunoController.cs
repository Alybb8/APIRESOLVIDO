using BoletimMaroto.Context.Util;
using BoletimModels;
using Microsoft.AspNetCore.Mvc;


namespace BoletimMaroto.Controllers
{
    [ApiController]
    [Route("Alunos")]
    public class AlunoController : ControllerBase
    {
        [HttpPost]
        [Route("cadastro")]//inserir alunos
        public ActionResult AddAlunos(Aluno aluno)
        {
            new Util<Aluno>().AddAlunos(aluno);
            return Ok();
        }

        [HttpPut]
        [Route("atualizar")]
        public ActionResult Update(int id, string aluno)
        {
            new Util<Aluno>().UpdateAluno(id, aluno);
            return Ok();
        }

        [HttpGet]
        [Route("listar")]
        public ActionResult Get(string aluno)
        {
            new Util<Aluno>().GetAlunos(aluno);
            return Ok();
        }

        [HttpDelete]
        [Route("delete")]
        public ActionResult Del(int idAluno)
        {
            new Util<Aluno>().ExcludeAlunoById(idAluno);
            return Ok();
        }
    }
}
