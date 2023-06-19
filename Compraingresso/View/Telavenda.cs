using Compraingresso.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compraingresso.View
{
    public partial class Telavenda : Form
    {
        public Telavenda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Ingresso ingresso = new Ingresso();
            int valor = Convert.ToInt32(textBox2.Text);
            int qtd = Convert.ToInt32(textBox1.Text);
             string resul = ingresso.Calcular(valor, qtd).ToString();

            label4.Text = resul; 
        }
    }
}
