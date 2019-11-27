using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePratico
{
    public class Triangulo
    {
        //Triangulo retângulo obedece o Teorema de Pitágoras.
        public bool ValidarTrianguloRetangulo(double a, double b, double c)
        {
            bool resultado = false;

            if (CalcularHipotenusa(a,b) == c || CalcularHipotenusa(a,c) == b || CalcularHipotenusa(b,c) == a)
            {
                resultado = true;
            }

            return resultado;
        }

        //3 Lados do triângulo têm a mesma medida
        public bool ValidarTrianguloEquilatero(double a, double b, double c)
        {
            bool resultado = false;

            if ( a == b && a == c)
            {
                resultado = true;
            }

            return resultado;
        }

        //Função importante para cálculo do Teorema de Pitágoras
        public double CalcularHipotenusa(double a, double b)
        {
            return Math.Sqrt((a*a)+(b*b));
        }

        //Teorema de Heron, usa os lados para o cálculo ao invés de base e altura
        public double CalcularAreaTriangulo(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            return Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
        }

        //Retorna se as  3 medida pertencem a um triângulo.
        public bool ValidarTriangulo(double a, double b, double c)
        {
            bool resultado = false;

            if ((Math.Abs(a - b) < c && c < a + b) &&
                (Math.Abs(a - c) < b && b < a + c) &&
                (Math.Abs(b - c) < a && a < b + b) )
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
