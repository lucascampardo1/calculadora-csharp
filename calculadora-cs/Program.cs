

public class Program
{
    public static void Main(string[] args)
    {
        static int Adicao(int n1, int n2) => n1 + n2;
        static int Subtracao(int n1, int n2) => n1 - n2;
        static int Multiplicacao(int n1, int n2) => n1 * n2;
        static int Divisao(int n1, int n2)
        {
            if (n2 == 0)
            {
                Console.WriteLine("Operação inválida. Não é possível dividir por zero!");
                return 0;
            }
            return 0;
        }

        while (true)
        {
            Console.Write("Digite um número:");
            if (!int.TryParse(Console.ReadLine(), out int n1))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                continue;
            }

            Console.Write("Digite outro número:");
            if (!int.TryParse(Console.ReadLine(), out int n2))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                continue;
            }

            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("------------------------------");

            if (!int.TryParse(Console.ReadLine(), out int alternativa))
            {
                Console.WriteLine("Opção inválida. Por favor, insira um número entre 1 e 5.");
                continue;
            }
            switch (alternativa)
            {
                case 1:
                    Console.WriteLine("O resultado da adição é: " + Adicao(n1, n2));
                    break;
                case 2:
                    Console.WriteLine("O resultado da subtração é: " + Subtracao(n1, n2));
                    break;
                case 3:
                    Console.WriteLine("O resultado da multiplicação é: " + Multiplicacao(n1, n2));
                    break;
                case 4:
                    Console.WriteLine("O resultado da divisão é: " + Divisao(n1, n2));
                    break;
                case 5:
                    Console.WriteLine("Até a próxima!");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("Pressione 'S' para sair...");
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.S)
            {
                Console.WriteLine("Até a próxima!");
                return;
            }
        }
    }
}