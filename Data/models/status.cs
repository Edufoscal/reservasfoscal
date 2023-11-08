using System.ComponentModel.DataAnnotations;

namespace reservasedufoscal.Data.models
{
    public class status
    {
        [Key]
        public int id { get; set; }
        public string tipo { get; set; }
        public string nombre { get; set; }

    }
}
