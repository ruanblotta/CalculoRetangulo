using System;

namespace CalculoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Digite a altura do retângulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o largura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());

            retangulo.CalcArea();
            retangulo.CalcPerimetro();
            retangulo.CalcDiagonal();
        }
    }
}
