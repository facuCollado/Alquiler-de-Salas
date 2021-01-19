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
            ((System.ComponentModel.ISupportInitialize)(this.salasDB_copiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salas_PedidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(274, 102);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 44;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(93, 109);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 43;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(274, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 42;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(203, 105);
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
            this.label7.Location = new System.Drawing.Point(41, 112);
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
            this.label6.Location = new System.Drawing.Point(208, 68);
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
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(88, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "------Datos Personales------";
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
            // FrmAlquilarPart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(435, 227);
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
            this.Text = "FrmAlquilarPart2";
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
    }
}