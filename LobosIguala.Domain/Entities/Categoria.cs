using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobosIguala.Domain.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        public Horario Horario { get; set; }  //Propiedad de navegacion
        public int HorarioId { get; set; }   //FK

        public Entrenador Entrenador { get; set; } //PROPIEDAD DE NAVEGACION    
        public int EntrenadorId { get; set; }   // FK





        // establecer relacion con alumnos
        //1 categoria puede tener muchos alumnos
        public List<Alumno> Alumnos { get; set; } = new();

        public override string ToString()
        {
            return $"{this.Nombre}{this.HorarioId}";
        }

    }
}
