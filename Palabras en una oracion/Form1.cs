using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palabras_en_una_oracion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncontar_Click(object sender, EventArgs e)
        {
            string oracion = txtoracion.Text.Trim();

            if (string.IsNullOrEmpty(oracion))
            {
                lblresultado.Text = "Palabras: 0";
                return;
            }

            string[] palabras = oracion.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );

            lblresultado.Text = "Palabras: " + palabras.Length;
        }
    }
}
