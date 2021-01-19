namespace Alquiler_Salas
{
    partial class FrmAlquilarPart2
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salasDB_copiaDataSet = new Alquiler_Salas.SalasDB_copiaDataSet();
            this.salas_PedidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salas_PedidasTableAdapter = new Alquiler_Salas.SalasDB_copiaDataSetTableAdapters.Salas_PedidasTableAdapter();
            this.tableAdapterManager = new Alquiler_Salas.SalasDB_copiaDataSetTableAdapters.TableAdapterManager();
            this.salasTableAdapter = new Alquiler_Salas.SalasDB_copiaDataSetTableAdapters.SalasTableAdapter();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_accept = new System.Windows.Forms.Button();
            this.Btn_back = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salasDB_copiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salas_PedidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(605, 134);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 44;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(401, 134);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 43;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(605, 84);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 42;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(401, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(532, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(326, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(532, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(326, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(324, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Datos Personales";
            // 
            // salasDB_copiaDataSet
            // 
            this.salasDB_copiaDataSet.DataSetName = "SalasDB_copiaDataSet";
            this.salasDB_copiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salas_PedidasBindingSource
            // 
            this.salas_PedidasBindingSource.DataMember = "Salas_Pedidas";
            this.salas_PedidasBindingSource.DataSource = this.salasDB_copiaDataSet;
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
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "Salas";
            this.salasBindingSource.DataSource = this.salasDB_copiaDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Resumen de Sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Sala";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.SystemColors.Info;
            this.lblRoom.Location = new System.Drawing.Point(104, 84);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(13, 17);
            this.lblRoom.TabIndex = 47;
            this.lblRoom.Text = "_";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDate.Location = new System.Drawing.Point(104, 112);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(13, 17);
            this.lblDate.TabIndex = 49;
            this.lblDate.Text = "_";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(27, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Fecha";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTime.Location = new System.Drawing.Point(104, 137);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 17);
            this.lblTime.TabIndex = 51;
            this.lblTime.Text = "_";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(27, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 50;
            this.label12.Text = "Hora";
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.Indigo;
            this.btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accept.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accept.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_accept.Location = new System.Drawing.Point(329, 212);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(115, 40);
            this.btn_accept.TabIndex = 52;
            this.btn_accept.Text = "Aceptar";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // Btn_back
            // 
            this.Btn_back.BackColor = System.Drawing.Color.Indigo;
            this.Btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_back.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_back.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_back.Location = new System.Drawing.Point(30, 212);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(115, 40);
            this.Btn_back.TabIndex = 53;
            this.Btn_back.Text = "Volver";
            this.Btn_back.UseVisualStyleBackColor = false;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Indigo;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCancel.Location = new System.Drawing.Point(605, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 40);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancelar/Menú";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAlquilarPart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(762, 325);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FrmAlquilarPart2";
            this.Text = "Alquiler de Salas";
            this.Load += new System.EventHandler(this.FrmAlquilarPart2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salasDB_copiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salas_PedidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private SalasDB_copiaDataSet salasDB_copiaDataSet;
        private System.Windows.Forms.BindingSource salas_PedidasBindingSource;
        private SalasDB_copiaDataSetTableAdapters.Salas_PedidasTableAdapter salas_PedidasTableAdapter;
        private SalasDB_copiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SalasDB_copiaDataSetTableAdapters.SalasTableAdapter salasTableAdapter;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button Btn_back;
        public System.Windows.Forms.Label lblRoom;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCancel;
    }
}