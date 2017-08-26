using System;
using System.Net.Http;
using System.Web.Http;
using CapturaEvento.Repository.Repositorio;
using CapturaEvento.Domain.Entities;
using System.Net;

namespace CapturaEvento.Controllers
{
    public class EventosController : ApiController
    {
        EventoRepository eventoRepositorio = new EventoRepository();

        //[EnableCors(origins: "*", headers: "*", methods: "*")]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage Get(string nomeEvento)
        {
            Evento evento = new Evento();

            evento.@event = nomeEvento;
            evento.timestamp = DateTime.Now.TimeOfDay;

            eventoRepositorio.Salvar(evento);

            return Request.CreateResponse<Evento>(HttpStatusCode.OK, evento);
        }
    }
}