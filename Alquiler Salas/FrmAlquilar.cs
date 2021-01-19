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

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if(consulta == false)
            {
                MessageBox.Show("Primero debe consultar la fecha");
            }
            else
            {
                /* String name = txtName.Text;
                 String last_name = txtLastName.Text;
                 String dni = txtDNI.Text;
                 String tel = txtPhone.Text;
                 String room = txtRoom.Text;
                 String date = dateTimePicker.Value.ToString("dd/MM/yyyy");
                 String time = cbTime.Text;
                //parseo la fecha a tipo fecha ya que luego cuando quiero traer el texto de la fecha trae otro formato
                String parseDate = DateTime.Parse(queryDate).ToString();

                 if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(last_name) || String.IsNullOrEmpty(dni) || String.IsNullOrEmpty(tel) ||
                     String.IsNullOrEmpty(room) || String.IsNullOrEmpty(date) || String.IsNullOrEmpty(time))
                 {
                     MessageBox.Show("No pueden haber campos vacios");
                 }
                 else
                 {
                     Boolean isAllowed = false;
                     //Hago la insercion
                     String strinsert = "INSERT into Pedidos (Sala, Fecha, Hora, IsAllowed, NombreCliente, ApellidoCliente, Dni, Telefono)" +
                         "Values(@room, @date, @time, @allowed, @name, @lastname, @dni, @tel)";
                     OleDbCommand cmd = new OleDbCommand(strinsert, con);
                     //Establecemos los parámetros que se utilizarán en el comando Insert
                     cmd.Parameters.AddWithValue("room", room);
                     cmd.Parameters.AddWithValue("date", date);
                     cmd.Parameters.AddWithValue("time", time);
                     cmd.Parameters.AddWithValue("allowed", isAllowed);
                     cmd.Parameters.AddWithValue("name", name);
                     cmd.Parameters.AddWithValue("lastname", last_name);
                     cmd.Parameters.AddWithValue("dni", dni);
                     cmd.Parameters.AddWithValue("tel", tel);

                     try
                     {
                         cmd.ExecuteNonQuery(); //Ejecutamos el query
                         MessageBox.Show("Sala reservada!");

                     }
                     catch (OleDbException ex)
                     {
                         MessageBox.Show("Error al insertar los datos: " + ex);
                     }

                     strinsert = "INSERT into Salas_Pedidas (Sala, Fecha) Values(@room, @date)";
                     OleDbCommand cmd2 = new OleDbCommand(strinsert, con);
                     cmd2.Parameters.AddWithValue("room", room);
                     cmd2.Parameters.AddWithValue("date", date);
                     try
                     {
                         cmd2.ExecuteNonQuery(); //Ejecutamos el query
                         MessageBox.Show("Sala_Pedidas!");

                     }
                     catch (OleDbException ex)
                     {
                         MessageBox.Show("Error al insertar los datos: " + ex);
                     }
                 }*/
            }

        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
          /*  txtDNI.Text = "";
            txtLastName.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtRoom.Text = "";*/
        }

        private void salasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selecciono una fila para llenar el contenido de que sala es elegida
            txtRoom.Text = salasDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            //Ver si la sala consultada esta disponible para el día de la fecha seleccionada
            consulta = true;

            String sala = txtRoom.Text;
            String queryDate = dateTimePicker.Value.ToString("dd/MM/yyyy")            
            String parseDate = DateTime.Parse(queryDate).ToString();

            //seteo colores verde para las disponibles y gris para los !disponibles
            int disponible = 0; //bool para saber si esta completamente libre esa sala
            foreach (DataGridViewRow row in salas_PedidasDataGridView.Rows)
            {
                if (Convert.ToString(row.Cells[1].Value) == sala && (Convert.ToString(row.Cells[2].Value)) == parseDate)
                {
                    MessageBox.Show("Sala esta reservada para el día elegido");
                    row.DefaultCellStyle.BackColor = Color.Red;
                    disponible = 0;
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
                MessageBox.Show("Sala disponible en cualquier fecha");
            }
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlquilarPart2 fA = new FrmAlquilarPart2();
            fA.ShowDialog();
            this.Close();
        }
    }
}
