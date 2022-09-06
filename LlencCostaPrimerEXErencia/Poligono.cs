using System;

namespace PrimeraEXErencia
{
    public class Poligono : Forma2D
    {
        int numLados = 0;

        public Poligono(int fnumLados)
        {
            numLados = fnumLados;
        }       

		public int NumLados { get; set; }

        public override double CalculArea()
        {
            double result = 0;
            return result;
        }
    }
}
