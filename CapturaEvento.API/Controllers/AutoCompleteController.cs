using CapturaEvento.Repository.Repositorio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Http.Cors;

namespace CapturaEvento.Controllers
{
    public class AutoCompleteController : ApiController
    {
        //[EnableCors(origins: "*", headers: "*", methods: "*")]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage Get(string entrada)
        {
            EventoRepository eventoRepositorio = new EventoRepository();

            List<string> lista = eventoRepositorio.listaEventosString(entrada);

            var json = JsonConvert.SerializeObject(lista);

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, lista);
        }
    }
}