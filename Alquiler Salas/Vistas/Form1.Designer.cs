namespace Alquiler_Salas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Btn_pedidos = new System.Windows.Forms.Button();
            this.Btn_alquilar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackColor = System.Drawing.Color.Indigo;
            this.Btn_exit.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_exit.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_exit.Location = new System.Drawing.Point(290, 321);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(150, 58);
            this.Btn_exit.TabIndex = 11;
            this.Btn_exit.Text = "Salir";
            this.Btn_exit.UseVisualStyleBackColor = false;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Btn_pedidos
            // 
            this.Btn_pedidos.BackColor = System.Drawing.Color.Indigo;
            this.Btn_pedidos.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_pedidos.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_pedidos.Location = new System.Drawing.Point(290, 207);
            this.Btn_pedidos.Name = "Btn_pedidos";
            this.Btn_pedidos.Size = new System.Drawing.Size(150, 58);
            this.Btn_pedidos.TabIndex = 10;
            this.Btn_pedidos.Text = "Pedidos";
            this.Btn_pedidos.UseVisualStyleBackColor = false;
            this.Btn_pedidos.Click += new System.EventHandler(this.Btn_pedidos_Click);
            // 
            // Btn_alquilar
            // 
            this.Btn_alquilar.BackColor = System.Drawing.Color.Indigo;
            this.Btn_alquilar.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_alquilar.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_alquilar.Location = new System.Drawing.Point(290, 103);
            this.Btn_alquilar.Name = "Btn_alquilar";
            this.Btn_alquilar.Size = new System.Drawing.Size(150, 58);
            this.Btn_alquilar.TabIndex = 9;
            this.Btn_alquilar.Text = "Alquilar";
            this.Btn_alquilar.UseVisualStyleBackColor = false;
            this.Btn_alquilar.Click += new System.EventHandler(this.Btn_alquilar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(233, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sistema de Alquiler de Salas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(738, 431);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Btn_pedidos);
            this.Controls.Add(this.Btn_alquilar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sistema de Alquiler de Salas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Button Btn_pedidos;
        private System.Windows.Forms.Button Btn_alquilar;
        private System.Windows.Forms.Label label1;
    }
}

