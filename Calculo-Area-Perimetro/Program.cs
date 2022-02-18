using System;

namespace Calculo_Area_Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = string.Empty;
            do
            {
                Console.WriteLine("Qual figura vamos calcular?");
                Console.WriteLine("0 - Retangulo");
                Console.WriteLine("1 - Quadrado");
                Console.WriteLine("2 - Circunferencia");
                Console.WriteLine("3 - Triangulo");
                int type = int.Parse(Console.ReadLine());

                if (type >= 4)
                {
                    Console.WriteLine("Número inválido");
                    Console.WriteLine("Deseja continuar?(s = sim ou n = não) ");
                    resp = Console.ReadLine();
                    if (resp != "s")
                        break;
                }

                Result.Operacao(type);

                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Deseja continuar?(s = sim ou n = não) ");
                resp = Console.ReadLine();
                if (resp != "s")
                    break;

            } while (true);

            Console.WriteLine("Adeus jovem padawan!");
        }
    }
}

class Result
{
    public static string CalculaAreaPerimetro(int valor1, int valor2, int valor3, int type)
    {
        double area = 0;
        double perimetro = 0;
        if (type == 0 || type == 1)
        {
            area = valor1 * valor2;
            perimetro = 2 * valor1 + 2 * valor2;
        }
        else if (type == 2)
        {
            area = 3.14 * (valor1 * valor2);
            perimetro = 2 * 3.14 * valor1;

            return string.Format("O perímetro é: {0}", perimetro);
        }
        else if (type == 3)
        {
            return string.Format("O perímetro é: {0}", valor1 + valor2 + valor3);
        }

        return $"A área é {area.ToString("F").Replace(",", ".")} e o Perímetro {perimetro.ToString("F").Replace(",", ".")}";
    }

    public static void Operacao(int type)
    {
        if (type == 0)
        {
            Console.WriteLine("Qual a base: ");
            int @base = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a Altura: ");
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine(Result.CalculaAreaPerimetro(@base, altura, 0, type));
        }
        else if (type == 1)
        {
            Console.WriteLine("Qual o tamanho de um dos lados: ");
            int lado = int.Parse(Console.ReadLine());
            Console.WriteLine(Result.CalculaAreaPerimetro(lado, lado, 0, type));
        }
        else if (type == 2)
        {
            Console.WriteLine("Digite o raio: ");
            int raio = int.Parse(Console.ReadLine());
            Console.WriteLine(Result.CalculaAreaPerimetro(raio, 0, 0, type));
        }
        else
        {
            Console.WriteLine("Digite o lado 1: ");
            int lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado 2: ");
            int lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado 3: ");
            int lado3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Result.CalculaAreaPerimetro(lado1, lado2, lado3, type));
        }
    }
}
