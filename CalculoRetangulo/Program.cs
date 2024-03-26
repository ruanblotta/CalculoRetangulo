using System;

namespace CalculoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite a altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o largura do retângulo: ");
            double largura = double.Parse(Console.ReadLine());

            // Area A = b * h

            double area = altura * largura;
            Console.WriteLine($"A área do retângulo é: {area.ToString("F2")} ");

            // Perímmetro P = 2 (b+h)

            double perimetro = 2 * (altura + largura);
            Console.WriteLine("O perímetro é: " + perimetro.ToString("F2"));

            // Diagonal a² = b² + c²

            double diagonal = Math.Sqrt((altura * altura ) + (largura * largura));
            Console.WriteLine("A diagonal é: " + diagonal.ToString("F2"));
        }
    }
}
