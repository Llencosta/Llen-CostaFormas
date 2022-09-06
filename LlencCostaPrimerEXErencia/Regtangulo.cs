using System;

namespace PrimeraEXErencia
{
    public class Regtangulo : Poligono
    {
        double lado1;
        double lado2;

        public Regtangulo(double flado1, double flado2) : base(4)
        {
            lado1 = flado1;
            lado2 = flado2; 
        }

        public override double CalculArea()
        {
            double result = 0;
            result = lado1 * lado2;
            return result;
        }
    }
}
