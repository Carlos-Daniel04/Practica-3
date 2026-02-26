using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_Perfectos
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

            if (numero <= 0)
            {
                MessageBox.Show("El número debe ser mayor que 0");
                return;
            }

            int sumaDivisores = 0;

            for (int i = 1; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    sumaDivisores += i;
                }
            }

            if (sumaDivisores == numero)
            {
                MessageBox.Show("El número ES perfecto");
            }
            else
            {
                MessageBox.Show("El número NO es perfecto");
            }
        }
    }
}
