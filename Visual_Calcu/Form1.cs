using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Calcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(operador1.Text); double valor2 = Convert.ToDouble(operador2.Text); double resultado = valor1 + valor2; operador3.Text = resultado.ToString();
            }
            catch (FormatException)
            {
            }
        }

        private void resta_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(operador1.Text); double valor2 = Convert.ToDouble(operador2.Text); double resultado = valor1 - valor2; operador3.Text = resultado.ToString();
            }
            catch (FormatException)
            {
            }
        }

        private void multiplica_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(operador1.Text); double valor2 = Convert.ToDouble(operador2.Text); double resultado = valor1 * valor2; operador3.Text = resultado.ToString();
            }
            catch (FormatException)
            {
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(operador1.Text); double valor2 = Convert.ToDouble(operador2.Text); double resultado = valor1 / valor2; operador3.Text = resultado.ToString();
            }
            catch (FormatException)
            {
            }
        }
    }
}
