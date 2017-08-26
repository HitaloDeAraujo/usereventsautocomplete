using CapturaEvento.Domain.Entities;
using CapturaEvento.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturaEvento.Repository.Repositorio
{
    public class EventoRepository
    {
        EventoContext db;

        public EventoRepository()
        {
            db = new EventoContext();
        }

        public void Salvar(Evento evento)
        {
            db.Eventos.Add(evento);

            db.SaveChanges();
        }

        public List<Evento> ObterEventos()
        {
            List<Evento> listaEventos;

            listaEventos = db.Eventos.ToList();

            return listaEventos;
        }

        public List<string> listaEventosString(string entrada)
        {
            List<string> listaEventos;

            listaEventos = db.Eventos.Where(x => x.@event.Contains(entrada)).Select(x => x.@event).ToList();

            return listaEventos;
        }
    }
}