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
    [Route("Nota")]
    public class NotaController : ControllerBase
    {
        [HttpGet]
        [Route("listarnotaspornome")]
        public ActionResult GetSpecificNotas(string alunos)
        {
            new Util<Nota>().GetInfosByName(alunos);
            return Ok();
        }

        [HttpGet]
        [Route("listarnotasgerais")]
        public ActionResult GetAllNotas()
        {
            new Util<Nota>().GetInfos();
            return Ok();
        }

        [HttpPost]
        [Route("postandonotas")]
        public ActionResult PostNotas(Nota nota)
        {
            new Util<Nota>().AddNota(nota);
            return Ok();
        }

        [HttpPut]
        [Route("updatenotas")]
        public ActionResult UpdateNotas(int notaId, int novaNota)
        {
            new Util<Nota>().UpdateNota(notaId, novaNota);
            return Ok();
        }

        [HttpDelete]
        [Route("excludenotas")]
        public ActionResult ExcludeNotas(int notaId)
        {
            new Util<Nota>().ExcludeNota(notaId);
            return Ok();
        }

    }
}
