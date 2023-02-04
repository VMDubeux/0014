using ProjetoQuatorze;
using System;
using System.Globalization;

namespace Exercicio
{
    class ProjetoQuatorze
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Informe a altura do retângulo: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a largura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write($"ÁREA: {r.Area().ToString("F2", CultureInfo.InvariantCulture)}.");
            Console.WriteLine();
            Console.Write($"PERÍMETRO: {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}.");
            Console.WriteLine();
            Console.Write($"DIAGONAL: {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}