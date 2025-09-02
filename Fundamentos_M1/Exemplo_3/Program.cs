using Exemplo_3.Models;
using System;

Calculadora Calc = new Calculadora();

Calc.Somar(5, 7);
Calc.Subtrair(10, 7);
Calc.Multiplicar(2, 5);
Calc.Dividir(8, 4);
Calc.Potencia(3, 2);
Calc.Seno(30);
Calc.Coseno(30);
Calc.Tangente(30);
Calc.RaizQuadrada(9);

int num = 10;
num++;
Console.WriteLine(num);
num--;
Console.WriteLine(num);