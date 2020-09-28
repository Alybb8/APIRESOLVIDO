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
    [Route("Materia")]
    public class MateriaController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public ActionResult GetMateria()
        {
            new Util<Materia>().PrintMaterias();
            return Ok();
        }

        [HttpPost]
        [Route("adicionar")]
        public ActionResult PostMateria(Materia materia)
        {
            new Util<Materia>().AddMateria(materia);
            return Ok();
        }

        [HttpDelete]
        [Route("excluir")]
        public ActionResult DeleteMateria(string descricao)
        {
            new Util<Materia>().ExcludeMateriaByName(descricao);
            return Ok();
        }

        [HttpPut]
        [Route("update")]
        public ActionResult UpdateMateria(int id, string descricao)
        {
            new Util<Materia>().UpdateMateria(id, descricao);
            return Ok();
        }
    }
}
