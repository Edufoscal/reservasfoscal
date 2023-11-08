using Microsoft.EntityFrameworkCore;
using reservasedufoscal.Data.models;

namespace reservasedufoscal.Data
{
    public class firstDbcontext : DbContext
    {
     

        public firstDbcontext(DbContextOptions<firstDbcontext> options) : base(options)
        {
        }
        public DbSet<usuario> Usuarios { get; set; }
        public DbSet<tipoUsuario> tipoUsuarios { get; set; }
        public DbSet<espacios> espacios { get; set; }
        public DbSet<status> status { get; set; }
        public DbSet<roles> roles { get; set; }
        public DbSet<reserva> reserva { get; set; }
        public DbSet<penalizacion> penalizacion { get; set; }


    }
}


