using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;

            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            // telegrama urgente?
            if (chkUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else
            {
                tipoTelegrama = 'o';
            }

            //Obtengo el número de palabras que forma el telegrama
            string[] palabras = textoTelegrama.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // Evito palabras vacías por espacios extra
            numPalabras = palabras.Length;

            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o') // Telegrama ordinario
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10); // Coste base + palabras adicionales
                }
                txtPrecio.Text = coste.ToString() + " euros";
            }
            if (tipoTelegrama == 'u') // Telegrama urgente
            {
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10); // Coste base + palabras adicionales
                }
                txtPrecio.Text = coste.ToString() + " euros";
            }
        }
    }
}
