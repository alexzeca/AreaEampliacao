using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CO13
{
    class AreaEampliacao
    {
        static void Main(string[] args)
        {
            Triangulo T = new Triangulo(3, 6);
            Console.WriteLine("Area = {0}", T.Area());
            double[] Med = new double[2];
            Med = T.Ampliacao(3);

            Console.WriteLine("Base Ampliada = {0}", Med[0]);
            Console.WriteLine("Altura Ampliada = {0}", Med[1]);

            Console.ReadLine();
        }
    }
}
