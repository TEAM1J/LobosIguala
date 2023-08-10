using LobosIguala.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobosIguala.Data
{
    public class LobosIgualaDbContext : DbContext

    {
        public LobosIgualaDbContext(DbContextOptions<LobosIgualaDbContext>options)
        : base(options)
        { 
        }

        //Crear los DbSets
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        //Establecer la cadena de conexion con el servidor de Data Base

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog=SistemaLobosDbContext");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}

    

