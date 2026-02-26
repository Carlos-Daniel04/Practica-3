namespace Palabras_en_una_oracion
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
            this.lbloracion = new System.Windows.Forms.Label();
            this.txtoracion = new System.Windows.Forms.TextBox();
            this.btncontar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbloracion
            // 
            this.lbloracion.AutoSize = true;
            this.lbloracion.Location = new System.Drawing.Point(13, 20);
            this.lbloracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbloracion.Name = "lbloracion";
            this.lbloracion.Size = new System.Drawing.Size(135, 20);
            this.lbloracion.TabIndex = 0;
            this.lbloracion.Text = "Ingrese Una Oracion ";
            // 
            // txtoracion
            // 
            this.txtoracion.Location = new System.Drawing.Point(13, 56);
            this.txtoracion.Name = "txtoracion";
            this.txtoracion.Size = new System.Drawing.Size(332, 26);
            this.txtoracion.TabIndex = 1;
            // 
            // btncontar
            // 
            this.btncontar.Location = new System.Drawing.Point(16, 93);
            this.btncontar.Name = "btncontar";
            this.btncontar.Size = new System.Drawing.Size(100, 40);
            this.btncontar.TabIndex = 2;
            this.btncontar.Text = "Contar Letras";
            this.btncontar.UseVisualStyleBackColor = true;
            this.btncontar.Click += new System.EventHandler(this.btncontar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(132, 106);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(84, 20);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "Palabras = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 208);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btncontar);
            this.Controls.Add(this.txtoracion);
            this.Controls.Add(this.lbloracion);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Oraciones ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloracion;
        private System.Windows.Forms.TextBox txtoracion;
        private System.Windows.Forms.Button btncontar;
        private System.Windows.Forms.Label lblresultado;
    }
}

