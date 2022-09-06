using System;

namespace PrimeraEXErencia
{
    public class Triangulo : Poligono
    {
        double lado1;
        double lado2;
        double lado3;

        public Triangulo(double flado1, double flado2, double flado3) : base(3)
        {
            lado1 = flado1;
            lado2 = flado2;
            lado3 = flado3;
        }

        public override double CalculArea()
        {
            double result = 0;
            result = (lado1 + lado2 + lado3)/ 2;
            result = Math.Sqrt(result*(result-lado1)*(result-lado2)*(result-lado3));
            return result;
        }
    }
}