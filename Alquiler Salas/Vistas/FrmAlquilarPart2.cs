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
    public partial class FrmAlquilarPart2 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Usuario\Documents\Dev\Desktop\Alquiler Salas\Alquiler Salas\SalasDB copia.accdb");
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

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAlquilar fback = new FrmAlquilar();
            fback.ShowDialog();
            this.Close();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            int dni = 0;
            int tel = 0;
            try
            {
                 dni = Convert.ToInt32(txtDNI.Text);
                 tel = Convert.ToInt32(txtPhone.Text);
            }
            catch
            {
                lblAlert.Text = "Por favor, ingrese datos válidos.";
                

            }
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtLastName.Text) || dni == 0 || tel == 0 ||
             String.IsNullOrEmpty(lblRoom.Text) || String.IsNullOrEmpty(lblDate.Text) || String.IsNullOrEmpty(lblTime.Text))
             {
                lblAlert.Text = "Por favor, ingrese datos válidos.";
            }
             else
             {
                 con.Open();
                lblAlert.Text = "";
                String name = txtName.Text;
                String last_name = txtLastName.Text;
                String room = lblRoom.Text;
                String date = lblDate.Text;
                String time = lblTime.Text;
 
                //Hago la insercion
                String strinsert = "INSERT into Pedidos (Sala, Fecha, Hora, NombreCliente, ApellidoCliente, Dni, Telefono)" +
                     "Values(@room, @date, @time, @name, @lastname, @dni, @tel)";
                 OleDbCommand cmd = new OleDbCommand(strinsert, con);
                 //Establecemos los parámetros que se utilizarán en el comando Insert
                 cmd.Parameters.AddWithValue("room", room);
                 cmd.Parameters.AddWithValue("date", date);
                 cmd.Parameters.AddWithValue("time", time);
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

                 String strinsert2 = "INSERT into Salas_Pedidas (Sala, Fecha) Values(@room, @date)";
                 OleDbCommand cmd2 = new OleDbCommand(strinsert2, con);
                 cmd2.Parameters.AddWithValue("room", room);
                 cmd2.Parameters.AddWithValue("date", date);
                 try
                 {
                     cmd2.ExecuteNonQuery(); //Ejecutamos el query

                 }
                 catch (OleDbException ex)
                 {
                     MessageBox.Show("Error al insertar los datos: " + ex);
                 }
                 con.Close();
             }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que volver ir al menu?",
                             " ",MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //si la respuesta es SI lo mando al Menu
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
        }
    }
}
