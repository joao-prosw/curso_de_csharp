using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_de_csharp.Common.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"Resultado: {x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"Resultado: {x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"Resultado: {x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"Resultado: {x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"Resultado: {x} ^ {y} = {potencia}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            Console.WriteLine($"Seno de {angulo} = {Math.Round(Math.Sin(radiano), 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(Math.Cos(radiano), 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(Math.Tan(radiano), 4)}");
        }

        public void RaizQuadrada(double x)
        {
            Console.WriteLine($"Raíz quadrada de {x} = {Math.Sqrt(x)}");
        }
    }
}