using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_Salas.Clases
{
    class Salas
    {
        private int id;
        private string sala;
        private int capacidad;

        public int Id { get => id; set => id = value; }
        public string Sala { get => sala; set => sala = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
    }
}
