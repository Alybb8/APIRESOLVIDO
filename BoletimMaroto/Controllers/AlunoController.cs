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

    }
}
