namespace Inicio_Y_Fin
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
            this.lblinicio = new System.Windows.Forms.Label();
            this.txtinicio = new System.Windows.Forms.TextBox();
            this.lblfin = new System.Windows.Forms.Label();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.listprimos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.Location = new System.Drawing.Point(53, 33);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(40, 20);
            this.lblinicio.TabIndex = 0;
            this.lblinicio.Text = "Inicio";
            // 
            // txtinicio
            // 
            this.txtinicio.Location = new System.Drawing.Point(100, 32);
            this.txtinicio.Name = "txtinicio";
            this.txtinicio.Size = new System.Drawing.Size(86, 26);
            this.txtinicio.TabIndex = 1;
            // 
            // lblfin
            // 
            this.lblfin.AutoSize = true;
            this.lblfin.Location = new System.Drawing.Point(244, 35);
            this.lblfin.Name = "lblfin";
            this.lblfin.Size = new System.Drawing.Size(37, 20);
            this.lblfin.TabIndex = 2;
            this.lblfin.Text = "Final";
            // 
            // txtfinal
            // 
            this.txtfinal.Location = new System.Drawing.Point(285, 33);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(86, 26);
            this.txtfinal.TabIndex = 3;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(171, 75);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(110, 36);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.Text = "Buscar Primos";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // listprimos
            // 
            this.listprimos.FormattingEnabled = true;
            this.listprimos.ItemHeight = 20;
            this.listprimos.Location = new System.Drawing.Point(150, 117);
            this.listprimos.Name = "listprimos";
            this.listprimos.Size = new System.Drawing.Size(150, 204);
            this.listprimos.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 365);
            this.Controls.Add(this.listprimos);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.lblfin);
            this.Controls.Add(this.txtinicio);
            this.Controls.Add(this.lblinicio);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Inico Y Final";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.TextBox txtinicio;
        private System.Windows.Forms.Label lblfin;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.ListBox listprimos;
    }
}

