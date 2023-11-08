using System.ComponentModel.DataAnnotations;

namespace reservasedufoscal.Data.models
{
    public class usuario
    {   
        [Key]
        public int id { get; set; }
        public tipoUsuario TipoUsuario { get; set; }
        public string correo { get; set;}
        public int celular {  get; set;}
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string identificacion { get; set; }
        public int numeroEmpleado { get; set; }

    }
}
