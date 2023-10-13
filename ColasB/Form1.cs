using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColasB
{

    public partial class Form1 : Form
    {
        Cola miCola = new Cola();
        private Cola mujerCola = new Cola();
        private Cola hombreCola = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (string.IsNullOrWhiteSpace(input) || input.Length < 2)
            {
                MessageBox.Show("Entrada invalida. Debe ser 'F' o 'M' seguido de un numero.", "Error");
                return;
            }
            char genero = Char.ToUpper(input[0]);

            Nodo nuevoNodo = new Nodo { Nombre = input };

            if (genero == 'F' || genero == 'M')
            {
                if (genero == 'F')
                {
                    mujerCola.Encolar(nuevoNodo);
                    listBoxMujer.Items.Add(input);
                }
                else
                {
                    hombreCola.Encolar(nuevoNodo);
                    listBoxHombre.Items.Add(input);
                }

                textBox1.Clear();
            }
        }

        private void btnDesencolarMujer_Click(object sender, EventArgs e)
        {
            if (mujerCola.Inicio != null)
            {
                Nodo desencolarNodo = mujerCola.Inicio;
                mujerCola.Desencolar();
                listBoxMujer.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("No hay Mujeres en la cola");
            }




        }

        private void btnDesencolarHombre_Click(object sender, EventArgs e)
        {
            if (hombreCola.Inicio != null) {
                Nodo desencolarNodo = hombreCola.Inicio;
                hombreCola.Desencolar();
                listBoxHombre.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("No hay Hombres en la cola");
            }
        }
    }
}
