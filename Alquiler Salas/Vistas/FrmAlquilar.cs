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
using Alquiler_Salas.Clases;
namespace Alquiler_Salas
{
    public partial class FrmAlquilar : Form
    {
        //iniciamos la conexion
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Usuario\Documents\Dev\Desktop\Alquiler Salas\Alquiler Salas\SalasDB copia.accdb");
        List<Salas> salas = new List<Salas>(); //almacenará una lista de objetos salas
        List<Salas_Pedidas> salas_pedidas = new List<Salas_Pedidas>(); //almacenará una lista de objetos salas_pedidas
        //var para determinar que debe consultar primero la fecha
        Boolean consulta = false;
        public FrmAlquilar()
        {
            InitializeComponent();
        }
        private void FrmAlquilar_Load(object sender, EventArgs e)
        {
            delete_yesterdayRooms();
            loadTablaSalas();
            loadTablaSalasPedidas();
            dateTimePicker.MinDate = DateTime.Now;

        }

        public void loadTablaSalas()
        {
            con.Open();
            //leo todos los datos de la tabla
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Salas", con);
            //creo un reader, que permite ejecutar la consulta
            OleDbDataReader r = cmd.ExecuteReader();

            int col = r.FieldCount; //traigo el num de cant de columnas

            if (r.HasRows)//si tiene una o más filas
            {
                while (r.Read()) //recorro todas las filas
                {
                    Salas s = new Salas();
                    //s.Id = r.GetInt32(0);
                    s.Sala = r.GetString(1);
                    s.Capacidad = r.GetInt32(2);

                    salas.Add(s); //le agrego los objetos a la List
                }
                startTablaSalas(); //inicializo la tabla
                fillTablaSalas();//Muestro los datos
            }
            else
            {
                MessageBox.Show("No hay datos en la BD");
            }
            r.Close();

            con.Close();
        }

        public void loadTablaSalasPedidas()
        {
            con.Open();
            //leo todos los datos de la tabla
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Salas_Pedidas", con);
            //creo un reader, que permite ejecutar la consulta
            OleDbDataReader r = cmd.ExecuteReader();

            int col = r.FieldCount; //traigo el num de cant de columnas

            if (r.HasRows)//si tiene una o más filas
            {
                while (r.Read()) //recorro todas las filas
                {
                    Salas_Pedidas sp = new Salas_Pedidas();
                    //sp.Id = r.GetInt32(0);
                    sp.Sala = r.GetString(1);
                    sp.Fecha = r.GetString(2);

                    salas_pedidas.Add(sp); //le agrego los objetos a la List
                }
                startTablaSalasPedidas(); //inicializo la tabla
                fillTablaSalasPedidas();//Muestro los datos
            }
            else
            {
                MessageBox.Show("No hay datos en la BD");
            }
            r.Close();
            con.Close();
        }

        public void startTablaSalas()
        {
            //Inicializo la grilla
            tablaSalas.AllowUserToAddRows = false;
            tablaSalas.AllowUserToDeleteRows = false;
            tablaSalas.AllowUserToOrderColumns = false;
            tablaSalas.ReadOnly = true;
            tablaSalas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaSalas.EditMode = DataGridViewEditMode.EditProgrammatically;
            tablaSalas.MultiSelect = false;
            tablaSalas.AutoResizeColumns();
            //tablaSalas.Columns.Add("id", "ID");
            tablaSalas.Columns.Add("sala", "Sala");
            tablaSalas.Columns.Add("capacidad", "Capacidad");
        }

        public void fillTablaSalas()
        {
            for (int i = 0; i < salas.Count(); i++)
            {
                tablaSalas.Rows.Add
                (salas[i].Sala,
                salas[i].Capacidad
                    );
            }
            salas.Clear();

            tablaSalas.Columns[0].FillWeight = 100;
            tablaSalas.Columns[1].FillWeight = 100;
            tablaSalas.BackgroundColor = Color.MediumOrchid;
            tablaSalas.GridColor = Color.MediumOrchid;
        }

        public void startTablaSalasPedidas()
        {
            //Inicializo la grilla
            tablaSalasPedidas.AllowUserToAddRows = false;
            tablaSalasPedidas.AllowUserToDeleteRows = false;
            tablaSalasPedidas.AllowUserToOrderColumns = false;
            tablaSalasPedidas.ReadOnly = true;
            tablaSalasPedidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaSalasPedidas.EditMode = DataGridViewEditMode.EditProgrammatically;
            tablaSalasPedidas.MultiSelect = false;
            tablaSalasPedidas.AutoResizeColumns();
            //tablaSalasPedidas.Columns.Add("id", "ID");
            tablaSalasPedidas.Columns.Add("sala", "Sala");
            tablaSalasPedidas.Columns.Add("fecha", "Fecha");
        }

        public void fillTablaSalasPedidas()
        {
            for (int i = 0; i < salas_pedidas.Count(); i++)
            {
                tablaSalasPedidas.Rows.Add
                (salas_pedidas[i].Sala,
                salas_pedidas[i].Fecha
                    );
            }
            salas_pedidas.Clear();

            tablaSalasPedidas.Columns[0].FillWeight = 100;
            tablaSalasPedidas.Columns[1].FillWeight = 100;
            tablaSalasPedidas.BackgroundColor = Color.MediumOrchid;
            tablaSalasPedidas.GridColor = Color.MediumOrchid;
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
        public void delete_yesterdayRooms()
        {
            //con esto elimino de las salas pedidas las que fueron reservadas el día anterior, para que esten disponibles nuevamente
            con.Open();
            DateTime today = DateTime.Now.AddDays(-1);
            String yesterday = today.ToString("dd/MM/yyyy");
            String strQuery = "DELETE FROM Salas_Pedidas WHERE Fecha = @yesterday";
            OleDbCommand cmd = new OleDbCommand(strQuery, con);
            //Establecemos los parámetros que se utilizarán en el comando Insert
            cmd.Parameters.AddWithValue("yesterday", yesterday);

            try
            {
                cmd.ExecuteNonQuery(); //Ejecutamos el query
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex);
            }
            con.Close();
        }
 
        private void salasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selecciono una fila para llenar el txt de la sala que sala es elegida
            txtRoom.Text = tablaSalas.CurrentRow.Cells[0].Value.ToString();
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
               // String parseDate = DateTime.Parse(queryDate).ToString();

                int disponible = 0; //bool para saber si esta completamente libre esa sala
                foreach (DataGridViewRow row in tablaSalasPedidas.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == sala && (Convert.ToString(row.Cells[1].Value)) == queryDate)
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
                //le paso los valores elegidos hacia el siguiente form
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
