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
            Forma2D f2d = new Forma2D();             
            Random random = new Random();
            int r = (random.Next(3)+1);
            switch (r) {

                case 1:
            
                    f2d = new Triangulo(random.Next(20), random.Next(20), random.Next(20));
                    break;
                case 2:            
                    f2d = new Regtangulo(random.Next(20), random.Next(40));
                    break;
                case 3:
                    f2d = new Circulo(random.Next(10));
                    break;
            }
            ListaFormas.Add(f2d);
            actualitzarLista();
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
