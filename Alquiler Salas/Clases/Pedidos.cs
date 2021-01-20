using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_Salas.Clases
{
    class Pedidos
    {
        private int id;
        private string sala;
        private string fecha;
        private string hora;
        private string nombrecliente;
        private string apellidocliente;
        private int dni;
        private int telefono;

        public int Id { get => id; set => id = value; }
        public string Sala { get => sala; set => sala= value; }
        public string  Hora { get => hora; set => hora= value; }
        public string Fecha { get => fecha; set => fecha= value; }
        public string NombreCliente { get => nombrecliente; set => nombrecliente = value; }
        public string ApellidoCliente { get => apellidocliente; set => apellidocliente = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
