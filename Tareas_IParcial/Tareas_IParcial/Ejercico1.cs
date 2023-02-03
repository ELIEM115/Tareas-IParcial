using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareas_IParcial
{
    public partial class Ejercico1 : Form
    {
        public Ejercico1()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            if(Numero1TextBox.Text == "")
            {
                errorProvider1.SetError(Numero1TextBox, "Ingrese un Numero");
                return;
            }
            errorProvider1.Clear();

            Par0Impar();
            Positivo0Negativo();
        }

        private void Par0Impar()
        {
            int numero = Convert.ToInt32(Numero1TextBox.Text);

            if (numero % 2 == 0)

                Par0ImparLabel.Text = "El numero es Par";
            
            else

                Par0ImparLabel.Text = "El numero es Impar";


        }
        private void Positivo0Negativo()
        {
            int numero = Convert.ToInt32(Numero1TextBox.Text);
            if (numero > 0)
                MessageBox.Show("El Numero es Positivo");
            else
                MessageBox.Show("El numero es Negativo");

        }

    }
}
