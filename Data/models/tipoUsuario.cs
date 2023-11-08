using System.ComponentModel.DataAnnotations;

namespace reservasedufoscal.Data.models
{
    public class tipoUsuario
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public roles rol { get; set; }


    }
}
