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
    public partial class FrmAlquilarPart2 : Form
    {
        public FrmAlquilarPart2()
        {
            InitializeComponent();
        }

        private void salas_PedidasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salas_PedidasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salasDB_copiaDataSet);

        }

        private void FrmAlquilarPart2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'salasDB_copiaDataSet.Salas' Puede moverla o quitarla según sea necesario.
            this.salasTableAdapter.Fill(this.salasDB_copiaDataSet.Salas);
            // TODO: esta línea de código carga datos en la tabla 'salasDB_copiaDataSet.Salas_Pedidas' Puede moverla o quitarla según sea necesario.
            this.salas_PedidasTableAdapter.Fill(this.salasDB_copiaDataSet.Salas_Pedidas);

        }
    }
}
