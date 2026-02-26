using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_Primos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtnumero.Text, out int numero))
            {
                MessageBox.Show("Ingrese un número válido");
                return;
            }

            if (numero <= 1)
            {
                MessageBox.Show("El número NO es primo");
                return;
            }

            bool esPrimo = true;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
            {
                MessageBox.Show(" El número ES primo");
            }
            else
            {
                MessageBox.Show(" El número NO es primo");
            }
        }
    }
}
