using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_Salas.Clases
{
    class Salas_Pedidas
    {
        private int id;
        private string sala;
        private string fecha;

        public int Id { get => id; set => id = value; }
        public string Sala { get => sala; set => sala = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
