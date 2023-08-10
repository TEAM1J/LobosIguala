using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobosIguala.Domain.Entities
{
    public class Horario
    {
        public int Id { get; set; }

        public string Hora { get; set; } = string.Empty;


        public List<Categoria> Categorias { get; set; } = new();

        public override string ToString()
        {
            return $"{Hora}";
        }


    }
}
