using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContadorNotas.Data;
namespace ContadorNotas.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/ContadorNotas")]
    public class ContadorNotasController : Controller
    {
        [HttpGet(template: "{valor}")]
        public IActionResult ContarNotas(int valor)
        {
            var contador = new ContadorNotas.Data.ContadorNotas();

            var resultado = contador.Contar(valor);

            return new ObjectResult(resultado);
        }
    }
}