using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraEXErencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Forma2D> ListaFormas = new List<Forma2D>();

        private void CrearForma_Click(object sender, EventArgs e)
        {
             
            Random random = new Random();
            int r = (random.Next(3)+1);
            if (r == 1)
            {
                Triangulo triangulo = new Triangulo(random.Next(20), random.Next(20), random.Next(20));
                ListaFormas.Add(triangulo);
                actualitzarLista();

            }
            if(r == 2)
            {
                Regtangulo rectangulo = new Regtangulo(random.Next(20), random.Next(40));
                ListaFormas.Add(rectangulo);
                actualitzarLista();
            }
            if (r == 3)
            {
                Circulo circulo = new Circulo(random.Next(10));
                ListaFormas.Add(circulo);
                actualitzarLista();
            }
        }

        private void ListaDeFormas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaFormas.RemoveAt(ListaDeFormas.SelectedIndex);
            actualitzarLista();


        }

        private void actualitzarLista()
        {
            ListaDeFormas.Items.Clear();
            for (int i = 0; i < ListaFormas.Count; i++)
            {
                ListaDeFormas.Items.Add(ListaFormas[i].CalculArea().ToString());
            }
        }
    }
}
