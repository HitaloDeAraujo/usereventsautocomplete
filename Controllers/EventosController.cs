using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using CapturaEvento.Repository.Repositorio;
using CapturaEvento.Domain.Entities;
using System.Web.Http.Cors;

namespace CapturaEvento.Controllers
{
    public class EventosController : ApiController
    {
        static List<string> lista = new List<string>();
        EventoRepository eventoRepositorio = new EventoRepository();

        //[EnableCors(origins: "*", headers: "*", methods: "*")]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage Get(string nomeEvento)
        {
            Evento evento = new Evento();

            evento.@event = nomeEvento;
            evento.timestamp = new TimeSpan();

            eventoRepositorio.Salvar(evento);

            return Request.CreateResponse(System.Net.HttpStatusCode.OK);
        }
    }
}