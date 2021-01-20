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
    public partial class FrmPedidos : Form
    {
        //iniciamos la conexion
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Usuario\Documents\Dev\Desktop\Alquiler Salas\Alquiler Salas\SalasDB copia.accdb");
        List<Pedidos> pedidos= new List<Pedidos>(); //almacenará una lista de objetos pedidos
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            con.Open();
            //leo todos los datos de la tabla
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Pedidos", con);
            //creo un reader, que permite ejecutar la consulta
            OleDbDataReader r = cmd.ExecuteReader();

            int col = r.FieldCount; //traigo el num de cant de columnas

            if (r.HasRows)//si tiene una o más filas
            {
                while (r.Read()) //recorro todas las filas
                {
                    Pedidos c = new Pedidos();
                    c.Id = r.GetInt32(0);
                    c.Sala = r.GetString(1);
                    c.Fecha = r.GetString(2);
                    c.Hora = r.GetString(3);
                    c.NombreCliente = r.GetString(4);
                    c.ApellidoCliente = r.GetString(5);
                    c.Dni = r.GetString(6);
                    c.Telefono = r.GetInt32(7);

                    pedidos.Add(c); //le agrego los objetos a la List
                }
                startTablaPedidos();
                fillTablaPedidos();//Muestro los datos
            }
            else
            {
                MessageBox.Show("No hay datos en la BD");
            }
            r.Close();

            con.Close();
        }

        public void startTablaPedidos()
        {
            //Inicializamos la grilla
            tablaPedidos.AllowUserToAddRows = false;
            tablaPedidos.AllowUserToDeleteRows = false;
            tablaPedidos.AllowUserToOrderColumns = false;
            tablaPedidos.ReadOnly = true;
            tablaPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaPedidos.EditMode = DataGridViewEditMode.EditProgrammatically;
            tablaPedidos.MultiSelect = false;
            tablaPedidos.AutoResizeColumns();
            tablaPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            tablaPedidos.Columns.Add("id","ID");
            tablaPedidos.Columns.Add("sala", "Sala");
            tablaPedidos.Columns.Add("fecha", "Fecha");
            tablaPedidos.Columns.Add("hora", "Hora");
            tablaPedidos.Columns.Add("nombrecliente", "NombreCliente");
            tablaPedidos.Columns.Add("apellidocliente", "ApellidoCliente");
            tablaPedidos.Columns.Add("dni", "DNI");
            tablaPedidos.Columns.Add("telefono", "Telefono");

        }
        public void fillTablaPedidos()
        {
            for (int i = 0; i < pedidos.Count(); i++)
            {
                tablaPedidos.Rows.Add
                (pedidos[i].Id,
                pedidos[i].Sala,
                pedidos[i].Fecha,
                pedidos[i].Hora,
                pedidos[i].NombreCliente,
                pedidos[i].ApellidoCliente,
                pedidos[i].Dni,
                pedidos[i].Telefono
                    );
            }
            pedidos.Clear();
        }

        public void updateTablaPedidos()
        {

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
    }
}
