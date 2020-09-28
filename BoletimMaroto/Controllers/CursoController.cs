using BoletimMaroto.Context.Util;
using BoletimModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimMaroto.Controllers
{
    [ApiController]
    [Route("curso")]
    public class CursoController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public ActionResult GetCursos(string nomeCurso)
        {
            new Util<Curso>().GetAllCursos(nomeCurso);
            return Ok();
        }

        [HttpPost]
        [Route("cadastro")]
        public ActionResult PostCursos(Curso curso)
        {
            new Util<Curso>().AddCurso(curso);
            return Ok();
        }

        [HttpPut]
        [Route("update")]
        public ActionResult UpdateCursos(int id, string nome)
        {
            new Util<Curso>().UpdateCurso(id, nome);
            return Ok();
        }

        [HttpDelete]
        [Route("exclude")]
        public ActionResult ExcludeCurso(string name)
        {
            new Util<Curso>().ExcludeCursoByName(name);
            return Ok();
        }
    }
}
