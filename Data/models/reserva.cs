using System.ComponentModel.DataAnnotations;

namespace reservasedufoscal.Data.models
{
    public class reserva
    {
        [Key]
        public int id { get; set; }
        public usuario usuario { get; set; }
        public DateTime fechainicio { get; set; }
        public DateTime fechafin {  get; set; }
        public string observacion { get; set; }

        public espacios espacio { get; set; }
        public int npersonas { get; set; }
        public status status { get; set; }

    }
}
