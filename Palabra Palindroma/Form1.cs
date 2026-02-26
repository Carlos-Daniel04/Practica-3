using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palabra_Palindroma
{
    public partial class palindroma : Form
    {
        public palindroma()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            string palabra = txtpalabra.Text.ToLower().Trim();
            if (palabra == "")
            {
                MessageBox.Show("Ingrese una palabra");
                return;
            }
            char[] letra = palabra.ToCharArray();
            Array.Reverse(letra);
            string palabrainvertida = new string(letra);

            if (palabra == palabrainvertida)
            {
                MessageBox.Show("La palabra es palindroma");
            }
            else
            {
                MessageBox.Show("La palbra no es palindroma");
            }
            


        }
    }
}
