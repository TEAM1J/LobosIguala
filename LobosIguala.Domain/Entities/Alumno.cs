using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobosIguala.Domain.Entities
{
    public class Alumno
    {
        //DATOS PERSONALES DEL ALUMNO
        public int Id { get; set; }

        [Required (ErrorMessage ="El nombre es obligatorio")]
        [StringLength(50, ErrorMessage ="El nombre debe tener maximo 50 caracteres")]
        public string Nombre { get; set; } = string.Empty;


        [Required(ErrorMessage = "Los apellidos son obligatorio")]
        [StringLength(50, ErrorMessage = "Los apellidos deben tener maximo 50 caracteres")]
        public string Apellidos { get; set; } = string.Empty;


        [Required(ErrorMessage= "La curp  es obligatoria")]
        [StringLength(18, ErrorMessage = "La curp debe tener maximo 18 caracteres")]
        public string Curp { get; set; } = string.Empty;


        [Required(ErrorMessage = "La fecha de nacimiento es obligatorio")]

        public DateTime FechaDeNacimiento { get; set; }



        public Categoria Categoria { get; set; }   //Propiedad de navegacion
        public int CategoriaId { get; set; } //FK


        //PADRE O TUTOR

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre debe tener maximo 50 caracteres")]
        public string NombreDelTutor { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido  es obligatorio")]
        [StringLength(50, ErrorMessage = "El apellido  debe tener maximo 50 caracteres")]
        public string ApellidosDelTutor { get; set; } = string.Empty;

        [Required(ErrorMessage = "El parentesco  es obligatorio")]

        public string Parentesco { get; set; } = string.Empty;


        [Required(ErrorMessage = "El telefono es obligatorio")]
        [StringLength(10, ErrorMessage = "El telefono debe tener maximo 10 caracteres")]
        public string Telefono { get; set; } = string.Empty;

        //DOMICILIO

        [Required(ErrorMessage= "La direccion es obligatoria")]
        [StringLength(50, ErrorMessage =  "La  direccion debe tener maximo 50 caracteres")]
        public string Direccion { get; set; } = string.Empty;

        [Required(ErrorMessage = "La colonia es obligatorio")]
        [StringLength(50, ErrorMessage = "La colonia debe tener maximo 50 caracteres")]
        public string Colonia { get; set; } = string.Empty;

        [Required(ErrorMessage = "El codigo postal es obligatorio")]
        [StringLength(5, ErrorMessage = "El codigo postal debe tener maximo 5 caracteres")]
        public string CodigoPostal { get; set; } = string.Empty;


        public List<Pago> Pagos { get; set; } = new();






    }
}
