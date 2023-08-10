using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobosIguala.Domain.Entities
{
    public class Alumno
    {
        //DATOS PERSONALES DEL ALUMNO
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Curp { get; set; } = string.Empty;
        public DateTime FechaDeNacimiento { get; set; }


        public Categoria Categoria { get; set; }   //Propiedad de navegacion
        public int CategoriaId { get; set; } //FK


        //PADRE O TUTOR
        public string NombreDelTutor { get; set; } = string.Empty;
        public string ApellidosDelTutor { get; set; } = string.Empty;
        public string Parentesco { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;

        //DOMICILIO
        public string Direccion { get; set; } = string.Empty;
        public string Colonia { get; set; } = string.Empty;
        public string CodigoPostal { get; set; } = string.Empty;

        public List<Pago> Pagos { get; set; } = new();






    }
}
