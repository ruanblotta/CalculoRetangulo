using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoRetangulo
{
    public class Retangulo
    {
        public double Altura;
        public double Largura;

        public void CalcArea()
        {
            // Area A = b * h
            double area = Altura * Largura;
            Console.WriteLine($"A área do retângulo é:" + area.ToString("F2"));
        }

        public void CalcPerimetro()
        {
            // Perímmetro P = 2 (b+h)
            double perimetro = 2 * (Altura + Largura);
            Console.WriteLine("O perímetro é: " + perimetro.ToString("F2"));
        }

        public void CalcDiagonal()
        {
            // Diagonal a² = b² + c²

            double diagonal = Math.Sqrt((Altura * Altura) + (Largura * Largura));
            Console.WriteLine("A diagonal é: " + diagonal.ToString("F2"));
        }
    }
}
