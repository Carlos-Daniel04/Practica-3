using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_Y_Fin
{
    public partial class Form1 : Form
    {
        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            listprimos.Items.Clear();

            if (!int.TryParse(txtinicio.Text, out int inicio) ||
                !int.TryParse(txtfinal.Text, out int fin))
            {
                MessageBox.Show("Ingrese valores numéricos válidos");
                return;
            }

            if (inicio > fin)
            {
                MessageBox.Show("El inicio no puede ser mayor que el fin");
                return;
            }

            for (int numero = inicio; numero <= fin; numero++)
            {
                if (EsPrimo(numero))
                {
                    listprimos.Items.Add(numero);
                }
            }

            if (listprimos.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron números primos en el rango");
            }
        }
    }
}
