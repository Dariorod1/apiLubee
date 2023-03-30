using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using testLubee.Models;
using testLubee.Recursos;
namespace testLubee.Controllers
{
    [ApiController]
    [Route("contrato")]
    public class ContratoController : ControllerBase
    {
        [HttpGet]
        [Route("mostrarContrato")]

        public dynamic ListarContrato(int idContrato)
        {
            
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@idContrato",idContrato)
            };

            DataTable tContrato = DBDatos.Listar("traerContrato",parametros);

            string jsonContrato = JsonConvert.SerializeObject(tContrato);

            return new
            {
                //jsonContrato
                contrato = JsonConvert.DeserializeObject<List<Contrato>>(jsonContrato)
            };

        }

        [HttpGet]
        [Route("listar")]

        public dynamic listado()
        {
            DataTable tListado = DBDatos.Listar("ListarContrato");

            string jsonListado = JsonConvert.SerializeObject(tListado);

            return new
            {
                contrato = JsonConvert.DeserializeObject<List<Contrato>>(jsonListado)

            };
        }
    }
}
