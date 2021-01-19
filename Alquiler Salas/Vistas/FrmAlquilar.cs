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
    public partial class FrmAlquilar : Form
    {
        //iniciamos la conexion
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Usuario\Documents\Dev\Desktop\Alquiler Salas\Alquiler Salas\SalasDB copia.accdb");
        //var global para determinar que debe consultar primero la fecha
        Boolean consulta = false;
        public FrmAlquilar()
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

        private void salas_PedidasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salas_PedidasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salasDB_copiaDataSet);

        }

        private void FrmAlquilar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'salasDB_copiaDataSet.Salas_Pedidas' Puede moverla o quitarla según sea necesario.
            this.salasTableAdapter.Fill(this.salasDB_copiaDataSet.Salas);
            // TODO: esta línea de código carga datos en la tabla 'salasDB_copiaDataSet.Salas_Pedidas' Puede moverla o quitarla según sea necesario.
            this.salas_PedidasTableAdapter.Fill(this.salasDB_copiaDataSet.Salas_Pedidas);

            bool estaConectado = false;
            try
            {
                con.Open();
                estaConectado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar: \n" + ex);
                estaConectado = false;
            }


        }


        private void salasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selecciono una fila para llenar el contenido de que sala es elegida
            txtRoom.Text = salasDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            //Ver si la sala esta disponible para el día de la fecha seleccionada
            if (String.IsNullOrEmpty(txtRoom.Text))
            {
                MessageBox.Show("Seleccione una sala para ver su disponibilidad");
            }
            else
            {
                consulta = true;
                String sala = txtRoom.Text;
                String queryDate = dateTimePicker.Value.ToString("dd/MM/yyyy");
                String parseDate = DateTime.Parse(queryDate).ToString();

                int disponible = 0; //bool para saber si esta completamente libre esa sala
                foreach (DataGridViewRow row in salas_PedidasDataGridView.Rows)
                {
                    if (Convert.ToString(row.Cells[1].Value) == sala && (Convert.ToString(row.Cells[2].Value)) == parseDate)
                    {
                        MessageBox.Show("Sala reservada en el día elegido.");
                        row.DefaultCellStyle.BackColor = Color.Red;
                        disponible = 0;
                        btn_continue.Enabled = false;
                        break;
                    }
                    else
                    {
                        disponible += 1;
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
                if (disponible != 0)
                {
                    MessageBox.Show("Sala disponible en esa fecha.");
                    btn_continue.Enabled = true;
                }
            }
            
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtRoom.Text) || String.IsNullOrEmpty(cbTime.Text) ||
                String.IsNullOrEmpty(dateTimePicker.Value.ToString()))
            {
                MessageBox.Show("No pueden haber campos vacios!");
            }
            else
            {
               
                this.Hide();
                FrmAlquilarPart2 fnext = new FrmAlquilarPart2();
                fnext.lblRoom.Text = txtRoom.Text;
                fnext.lblDate.Text = dateTimePicker.Value.ToString("dd/MM/yyyy");
                fnext.lblTime.Text = cbTime.Text;

                fnext.ShowDialog();
                this.Close();
            }

        }
    }
}
