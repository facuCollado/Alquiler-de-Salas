namespace Alquiler_Salas
{
    partial class FrmAlquilar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Btn_back = new System.Windows.Forms.Button();
            this.btnConsult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tablaSalasPedidas = new System.Windows.Forms.DataGridView();
            this.salas_PedidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salasDB_copiaDataSet = new Alquiler_Salas.SalasDB_copiaDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_continue = new System.Windows.Forms.Button();
            this.tablaSalas = new System.Windows.Forms.DataGridView();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salas_PedidasTableAdapter = new Alquiler_Salas.SalasDB_copiaDataSetTableAdapters.Salas_PedidasTableAdapter();
            this.tableAdapterManager = new Alquiler_Salas.SalasDB_copiaDataSetTableAdapters.TableAdapterManager();
            this.salasTableAdapter = new Alquiler_Salas.SalasDB_copiaDataSetTableAdapters.SalasTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSalasPedidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salas_PedidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasDB_copiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_back
            // 
            this.Btn_back.BackColor = System.Drawing.Color.Indigo;
            this.Btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_back.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_back.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_back.Location = new System.Drawing.Point(770, 288);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(115, 40);
            this.Btn_back.TabIndex = 3;
            this.Btn_back.Text = "Volver";
            this.Btn_back.UseVisualStyleBackColor = false;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // btnConsult
            // 
            this.btnConsult.BackColor = System.Drawing.Color.Indigo;
            this.btnConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsult.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsult.ForeColor = System.Drawing.SystemColors.Info;
            this.btnConsult.Location = new System.Drawing.Point(724, 190);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(75, 28);
            this.btnConsult.TabIndex = 38;
            this.btnConsult.Text = "Consultar";
            this.btnConsult.UseVisualStyleBackColor = false;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(636, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Hora de entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(636, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fecha";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(785, 93);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(100, 20);
            this.txtRoom.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(638, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sala";
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00"});
            this.cbTime.Location = new System.Drawing.Point(764, 139);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(121, 21);
            this.cbTime.TabIndex = 40;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(685, 56);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 41;
            // 
            // tablaSalasPedidas
            // 
            this.tablaSalasPedidas.AllowUserToAddRows = false;
            this.tablaSalasPedidas.AllowUserToDeleteRows = false;
            this.tablaSalasPedidas.AllowUserToResizeColumns = false;
            this.tablaSalasPedidas.AllowUserToResizeRows = false;
            this.tablaSalasPedidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSalasPedidas.GridColor = System.Drawing.Color.DarkViolet;
            this.tablaSalasPedidas.Location = new System.Drawing.Point(30, 65);
            this.tablaSalasPedidas.Name = "tablaSalasPedidas";
            this.tablaSalasPedidas.ReadOnly = true;
            this.tablaSalasPedidas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaSalasPedidas.Size = new System.Drawing.Size(243, 267);
            this.tablaSalasPedidas.TabIndex = 41;
            // 
            // salas_PedidasBindingSource
            // 
            this.salas_PedidasBindingSource.DataMember = "Salas_Pedidas";
            this.salas_PedidasBindingSource.DataSource = this.salasDB_copiaDataSet;
            // 
            // salasDB_copiaDataSet
            // 
            this.salasDB_copiaDataSet.DataSetName = "SalasDB_copiaDataSet";
            this.salasDB_copiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(345, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Salas habilitadas para alquilar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(25, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Salas reservadas y su fecha";
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.Indigo;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_continue.Location = new System.Drawing.Point(639, 288);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(115, 40);
            this.btn_continue.TabIndex = 44;
            this.btn_continue.Text = "Continuar";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // tablaSalas
            // 
            this.tablaSalas.AllowUserToAddRows = false;
            this.tablaSalas.AllowUserToDeleteRows = false;
            this.tablaSalas.AllowUserToResizeColumns = false;
            this.tablaSalas.AllowUserToResizeRows = false;
            this.tablaSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSalas.GridColor = System.Drawing.Color.DarkViolet;
            this.tablaSalas.Location = new System.Drawing.Point(350, 65);
            this.tablaSalas.Name = "tablaSalas";
            this.tablaSalas.ReadOnly = true;
            this.tablaSalas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaSalas.Size = new System.Drawing.Size(246, 267);
            this.tablaSalas.TabIndex = 39;
            this.tablaSalas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salasDataGridView_CellClick);
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "Salas";
            this.salasBindingSource.DataSource = this.salasDB_copiaDataSet;
            // 
            // salas_PedidasTableAdapter
            // 
            this.salas_PedidasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PedidosTableAdapter = null;
            this.tableAdapterManager.Salas_PedidasTableAdapter = this.salas_PedidasTableAdapter;
            this.tableAdapterManager.SalasTableAdapter = this.salasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Alquiler_Salas.SalasDB_copiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salasTableAdapter
            // 
            this.salasTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(27, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(596, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "*Debido a la situacion sanitaria actual de pandemia, una sala deberá tener una re" +
    "serva por día.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(37, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(454, 34);
            this.label7.TabIndex = 46;
            this.label7.Text = "Esto para poder descontaminar y tomar las medidas necesarias para que\r\nlos recint" +
    "os esten totalmente sanitizados.";
            // 
            // FrmAlquilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(911, 413);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tablaSalasPedidas);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.tablaSalas);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_back);
            this.Name = "FrmAlquilar";
            this.Text = "Alquiler de Salas";
            this.Load += new System.EventHandler(this.FrmAlquilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSalasPedidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salas_PedidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasDB_copiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_back;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label1;
        private SalasDB_copiaDataSet salasDB_copiaDataSet;
        private System.Windows.Forms.BindingSource salas_PedidasBindingSource;
        private SalasDB_copiaDataSetTableAdapters.Salas_PedidasTableAdapter salas_PedidasTableAdapter;
        private SalasDB_copiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SalasDB_copiaDataSetTableAdapters.SalasTableAdapter salasTableAdapter;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView tablaSalasPedidas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.DataGridView tablaSalas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}