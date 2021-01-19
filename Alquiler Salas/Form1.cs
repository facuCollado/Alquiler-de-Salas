using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquiler_Salas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_alquilar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlquilar alquilar = new FrmAlquilar();
            alquilar.ShowDialog();
            this.Close();
        }

        private void Btn_pedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPedidos pedidos = new FrmPedidos();
            pedidos.ShowDialog();
            this.Close();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
