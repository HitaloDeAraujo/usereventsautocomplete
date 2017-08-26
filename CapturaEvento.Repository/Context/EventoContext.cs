using CapturaEvento.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturaEvento.Repository.Context
{
    class EventoContext : DbContext
    {
        public EventoContext(): base("Eventos")
        {

        }

        public DbSet<Evento> Eventos { get; set; }
    }
}