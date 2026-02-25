using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class Temeporizador : Form
    {
        public Temeporizador()
        {
            InitializeComponent();
        }

        int minutos;
        int segundos;
        int minutosIniciales;
        int segundosIniciales;
        bool enPausa = false;
        private void btntiempo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblminutos.Text, out minutos) ||
                !int.TryParse(lblsegundos.Text, out segundos))
            {
                MessageBox.Show("Ingrese valores numéricos");
                return;
            }

            if (segundos < 0 || segundos > 59)
            {
                MessageBox.Show("Los segundos deben estar entre 0 y 59");
                return;
            }

            minutosIniciales = minutos;
            segundosIniciales = segundos;

            txttiempo.Text = $"{minutos:D2}:{segundos:D2}";
            tiempo.Start();
            enPausa = false;
        }
        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (!enPausa)
            {
                tiempo.Stop();
                enPausa = true;
            }
            else
            {
                tiempo.Start();
                enPausa = false;
            }
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            if (minutos == 0 && segundos == 0)
                tiempo.Stop();
            MessageBox.Show("se acabo el tiempo");
            return;
            
            if (segundos == 0)
            {
                minutos--;
                segundos = 59;
            }
            else
            {
                segundos--;
            }
            txttiempo.Text = $"{minutos:D2}:{segundos:D2}";
        }

        
         
    }  
}