using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_de_longitud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboentrada.Items.Add("Metros");
            cboentrada.Items.Add("Centímetros");
            cboentrada.Items.Add("Pulgadas");
            cbosalida.Items.Add("Metros");
            cbosalida.Items.Add("Centímetros");
            cbosalida.Items.Add("Pulgadas");
            cboentrada.SelectedIndex = 0;
            cbosalida.SelectedIndex = 1;
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            double valor;
            if (!double.TryParse(txtvalor.Text, out valor))
            {
                MessageBox.Show("Ingrese un valor numérico válido");
                return;
            }

            string unidadEntrada = cboentrada.SelectedItem.ToString();
            string unidadSalida = cbosalida.SelectedItem.ToString();

            double valorEnMetros = 0;

            if (unidadEntrada == "Metros")
                valorEnMetros = valor;
            else if (unidadEntrada == "Centímetros")
                valorEnMetros = valor / 100;
            else if (unidadEntrada == "Pulgadas")
                valorEnMetros = valor * 0.0254;

            double resultado = 0;

            if (unidadSalida == "Metros")
                resultado = valorEnMetros;
            else if (unidadSalida == "Centímetros")
                resultado = valorEnMetros * 100;
            else if (unidadSalida == "Pulgadas")
                resultado = valorEnMetros / 0.0254;

            txtresultado.Text = resultado.ToString("F2");
        }
    }
}
