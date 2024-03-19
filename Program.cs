using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JmFormasGeometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma forma geométrica (Retângulo, Quadrado, Losango e Trapézio: ");
            string forma = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite a base da forma: ");
            double bhase = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da forma: ");
            double altura = double.Parse(Console.ReadLine());

            switch (forma)
            {
                case "Quadrado":
                    double area = bhase * altura;
                    Console.WriteLine("A área da forma é: " + area);
                    break;
                case "Retângulo":
                    double area2 = bhase * altura;
                    Console.WriteLine("A área da forma é: " + area2);
                    break;
                case "Trapézio":
                    double area3 = (bhase + bhase) * (altura / 2);
                    Console.WriteLine("A área da forma é: " + area3);
                    break;
                case "Losango":
                    double area4 = (bhase * altura) / 2;
                    Console.WriteLine("A área da forma é: " + area4);
                    break;
                default:
                    Console.WriteLine("ERRO");
                    break;     
            }

            Console.ReadKey();
        }
    }
}
