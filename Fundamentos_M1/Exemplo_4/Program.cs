using Curso_de_csharp.Common.Models;

int[] testeArray = new int[] { 72, 64, 17, 50 };

Console.WriteLine("Percorrendo array com um for Simples:");
for (int i = 0; i < testeArray.Length; i++)
{
    Console.WriteLine($"#{i + 1} - {testeArray[i]}");
}

Console.WriteLine("\n----------------------------\n\nPercorrendo array com um foreach:");

int contadorForEach = 0;
foreach (int valor in testeArray)
{
    Console.WriteLine($"#{contadorForEach + 1} - {valor}");
    contadorForEach++;
}

// Array.Resize(ref testeArray, testeArray.Length * 2); <- Redimensionamento de Array
/*int[] arrayInteirosDobrado = new int[testeArray.Length * 2]; <- [1]
Array.Copy(testeArray, arrayInteirosDobrado, testeArray.Length); <- [1]

Console.WriteLine("Percorrendo array com um for Simples:");
for (int i = 0; i < arrayInteirosDobrado.Length; i++)
{
    Console.WriteLine($"#{i + 1} - {arrayInteirosDobrado[i]}");
}

Console.WriteLine("\n----------------------------\n\nPercorrendo array com um foreach:");

contadorForEach = 0;
foreach (int valor in arrayInteirosDobrado)
{
    Console.WriteLine($"#{contadorForEach + 1} - {valor}");
    contadorForEach++;
}
^^^^^^^^^ Cópia de Array [1] ^^^^^^^^^
*/