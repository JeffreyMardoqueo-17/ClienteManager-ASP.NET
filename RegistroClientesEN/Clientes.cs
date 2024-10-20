using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroClientesEN
{
    public class Clientes
    {
        public int Id { get; set; }
       public string? Nombre { get; set; }
       public string? Apellido { get; set;}
       public string? Email { get; set; }
       public string? Pass { get; set; }
       public string? Telefono { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
