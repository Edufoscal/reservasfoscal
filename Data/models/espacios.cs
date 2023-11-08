using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace reservasedufoscal.Data.models
{
    public class espacios
    {
        [Key]
        public int id { get; set; }
        public string tipologia { get; set; }
        public DateTime horainicio { get; set; }
        public DateTime horafin { get; set; }
        public Boolean activo { get; set; }
        public string nombre { get; set; }
        public int capacidad { get; set; }



    }
}
