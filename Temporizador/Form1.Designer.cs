namespace Temporizador
{
    partial class Temeporizador
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
            this.components = new System.ComponentModel.Container();
            this.txtminutos = new System.Windows.Forms.TextBox();
            this.txtsegundo = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txttiempo = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.btntiempo = new System.Windows.Forms.Button();
            this.lblminutos = new System.Windows.Forms.Label();
            this.lblsegundos = new System.Windows.Forms.Label();
            this.bntpausar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtminutos
            // 
            this.txtminutos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtminutos.Location = new System.Drawing.Point(67, 37);
            this.txtminutos.Name = "txtminutos";
            this.txtminutos.Size = new System.Drawing.Size(77, 26);
            this.txtminutos.TabIndex = 1;
            // 
            // txtsegundo
            // 
            this.txtsegundo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundo.Location = new System.Drawing.Point(246, 38);
            this.txtsegundo.Name = "txtsegundo";
            this.txtsegundo.Size = new System.Drawing.Size(77, 26);
            this.txtsegundo.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txttiempo
            // 
            this.txttiempo.AutoSize = true;
            this.txttiempo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttiempo.Location = new System.Drawing.Point(132, 81);
            this.txttiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(41, 20);
            this.txttiempo.TabIndex = 4;
            this.txttiempo.Text = "00:00";
            // 
            // tiempo
            // 
            this.tiempo.Interval = 1000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // btntiempo
            // 
            this.btntiempo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntiempo.Location = new System.Drawing.Point(115, 120);
            this.btntiempo.Name = "btntiempo";
            this.btntiempo.Size = new System.Drawing.Size(75, 29);
            this.btntiempo.TabIndex = 5;
            this.btntiempo.Text = "Iniciar";
            this.btntiempo.UseVisualStyleBackColor = true;
            this.btntiempo.Click += new System.EventHandler(this.btntiempo_Click);
            // 
            // lblminutos
            // 
            this.lblminutos.AutoSize = true;
            this.lblminutos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminutos.Location = new System.Drawing.Point(6, 44);
            this.lblminutos.Name = "lblminutos";
            this.lblminutos.Size = new System.Drawing.Size(55, 20);
            this.lblminutos.TabIndex = 6;
            this.lblminutos.Text = "Minutos";
            // 
            // lblsegundos
            // 
            this.lblsegundos.AutoSize = true;
            this.lblsegundos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsegundos.Location = new System.Drawing.Point(169, 44);
            this.lblsegundos.Name = "lblsegundos";
            this.lblsegundos.Size = new System.Drawing.Size(71, 20);
            this.lblsegundos.TabIndex = 7;
            this.lblsegundos.Text = "Segundos";
            // 
            // bntpausar
            // 
            this.bntpausar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntpausar.Location = new System.Drawing.Point(115, 155);
            this.bntpausar.Name = "bntpausar";
            this.bntpausar.Size = new System.Drawing.Size(75, 29);
            this.bntpausar.TabIndex = 8;
            this.bntpausar.Text = "Pausar";
            this.bntpausar.UseVisualStyleBackColor = true;
            // 
            // Temeporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 262);
            this.Controls.Add(this.bntpausar);
            this.Controls.Add(this.lblsegundos);
            this.Controls.Add(this.lblminutos);
            this.Controls.Add(this.btntiempo);
            this.Controls.Add(this.txttiempo);
            this.Controls.Add(this.txtsegundo);
            this.Controls.Add(this.txtminutos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Temeporizador";
            this.Text = "Temporizador";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.TextBox txtminutos;
    
        private System.Windows.Forms.TextBox txtsegundo;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btntiempo;
        private System.Windows.Forms.Label txttiempo;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Label lblsegundos;
        private System.Windows.Forms.Label lblminutos;
        private System.Windows.Forms.Button bntpausar;
    }
}

