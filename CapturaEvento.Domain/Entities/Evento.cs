using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapturaEvento.Domain.Entities
{
    [Table("Eventos")]
    public class Evento
    {
        public int id { get; set; }
        public string @event { get; set; }
        public TimeSpan timestamp { get; set; }
    }
}