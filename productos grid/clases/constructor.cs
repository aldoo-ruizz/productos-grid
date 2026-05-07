using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productos_grid.clases
{
    public class constructor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidopaterno { get; set; }
        public string Apellidomaterno { get; set; }

        public constructor(int id, string nombre, string apellidopaterno, string apellidomaterno)
        {
            Id = id;
            Nombre = nombre;
            Apellidopaterno = apellidopaterno;
            Apellidomaterno = apellidomaterno;

        }
    }
}
