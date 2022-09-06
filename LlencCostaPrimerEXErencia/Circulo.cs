using System;

namespace PrimeraEXErencia
{
    public class Circulo : Forma2D
    {
        double radio;

        public Circulo(double fradio)
        {
            radio = fradio;
        }

        public override double CalculArea()
        {
            double result = 0;
            result = Math.PI * (radio * radio);
            return result;
        }
    }
}