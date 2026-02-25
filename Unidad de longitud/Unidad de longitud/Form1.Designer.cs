namespace Unidad_de_longitud
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
            this.lblvalor = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.cboentrada = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbosalida = new System.Windows.Forms.ComboBox();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblvalor.Location = new System.Drawing.Point(17, 34);
            this.lblvalor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(40, 20);
            this.lblvalor.TabIndex = 0;
            this.lblvalor.Text = "Valor";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(79, 37);
            this.txtvalor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(99, 26);
            this.txtvalor.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(187, 37);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(26, 20);
            this.label.TabIndex = 2;
            this.label.Text = "De";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(229, 115);
            this.txtresultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(132, 26);
            this.txtresultado.TabIndex = 3;
            // 
            // cboentrada
            // 
            this.cboentrada.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboentrada.FormattingEnabled = true;
            this.cboentrada.Location = new System.Drawing.Point(229, 35);
            this.cboentrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboentrada.Name = "cboentrada";
            this.cboentrada.Size = new System.Drawing.Size(139, 28);
            this.cboentrada.TabIndex = 4;
            this.cboentrada.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(391, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "A";
            // 
            // cbosalida
            // 
            this.cbosalida.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosalida.FormattingEnabled = true;
            this.cbosalida.Location = new System.Drawing.Point(423, 37);
            this.cbosalida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbosalida.Name = "cbosalida";
            this.cbosalida.Size = new System.Drawing.Size(139, 28);
            this.cbosalida.TabIndex = 6;
            // 
            // btnconvertir
            // 
            this.btnconvertir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertir.Location = new System.Drawing.Point(23, 97);
            this.btnconvertir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(132, 49);
            this.btnconvertir.TabIndex = 7;
            this.btnconvertir.Text = "Convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(579, 251);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.cbosalida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboentrada);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lblvalor);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Convertidor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.ComboBox cboentrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbosalida;
        private System.Windows.Forms.Button btnconvertir;
    }
}

