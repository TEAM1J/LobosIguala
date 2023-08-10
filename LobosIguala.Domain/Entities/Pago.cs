using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobosIguala.Domain.Entities
{
    public class Pago
    {
        public int Id { get; set; }
        public Alumno Alumno { get; set; }
        public int AlumnoId { get; set; }
        public string Concepto { get; set; } = string.Empty;
        public decimal Importe { get; set; }
        public DateTime FechaDePago { get; set; }


    }
}
