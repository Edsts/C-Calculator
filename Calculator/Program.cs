using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibeMenu();
        }

        static void ExibeMenu()
        {
            Console.Clear();

            Console.WriteLine("=== Bem-vindo à calculadora de fundamentos de C# ===");
            Console.WriteLine(" Digite a operação que deseja executar: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair da calculadora");

            Console.Beep();
            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: FecharCalculadora(); break;
            }
        }

        static void FecharCalculadora()
        {
            Console.WriteLine("Até logo =) ..... ");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            System.Environment.Exit(0);
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.Beep();

            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());
            Console.Beep();

            Console.WriteLine($"O resultado da soma é {primeiroValor + segundoValor}");

            Console.ReadKey();

            ExibeMenu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.Beep();

            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());
            Console.Beep();

            Console.WriteLine($"O resultado da subtração é {primeiroValor - segundoValor}");

            Console.ReadKey();

            ExibeMenu();

        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.Beep();

            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());
            Console.Beep();

            Console.WriteLine($"O resultado da subtração é {primeiroValor / segundoValor}");

            Console.ReadKey();

            ExibeMenu();

        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.Beep();

            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());
            Console.Beep();

            Console.WriteLine($"O resultado da subtração é {primeiroValor * segundoValor}");

            Console.ReadKey();

            ExibeMenu();

        }
    }
}
