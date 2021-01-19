using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquiler_Salas
{
    public partial class FrmPedidos : Form
    {
        //iniciamos la conexion
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Usuario\Documents\Dev\Desktop\Alquiler Salas\Alquiler Salas\SalasDB copia.accdb");

        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }



        private void pedidosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salasDB_copiaDataSet);

        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'salasDB_copiaDataSet.Pedidos' Puede moverla o quitarla según sea necesario.
            this.pedidosTableAdapter.Fill(this.salasDB_copiaDataSet.Pedidos);


        }
    }
}
