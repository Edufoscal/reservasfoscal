using System.ComponentModel.DataAnnotations;

namespace reservasedufoscal.Data.models
{
    public class penalizacion
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public usuario usuarios { get; set; }
        public status status { get; set; }  
        public reserva reserva { get; set; }

    }
}
