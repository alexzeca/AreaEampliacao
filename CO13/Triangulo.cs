using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CO13
{
    class Triangulo
    {
        private double Base;
        private double Altura;

        public Triangulo()
        {
            Base = 0;
            Altura = 0;
        }

        public Triangulo(double B, double H)
        {
            Base = B;
            Altura = H;
        }

        public double Area()
        {
            return Base * Altura / 2;
        }

        public double [] Ampliacao(double x)
        {
            double[] Medidas = new double[2];
            Medidas[0] = Base * x;
            Medidas[1] = Altura * x;
            return Medidas;
        }
    }
}
