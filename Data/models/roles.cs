using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace reservasedufoscal.Data.models
{
    public class roles
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }

    }
}
