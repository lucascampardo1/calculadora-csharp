Console.Write("Digite um número:");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Digite outro número:");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Qual operação deseja realizar?");

Console.WriteLine("------------------------------");
Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Sair");
Console.WriteLine("------------------------------");
int alternativa = int.Parse(Console.ReadLine());

if (alternativa == 1)
{
    int conta = n1 + n2;
    Console.WriteLine("O resultado da adição é: " + conta);
} else if (alternativa == 2)
{
    int conta = n1 - n2;
    Console.WriteLine("O resultado da subtração é: " + conta);
} else if (alternativa == 3)
{
    int conta = n1 * n2;
    Console.WriteLine("O resultado da multiplicação é: " + conta);
} else if (alternativa == 4)
{
    if (n2 == 0)
    {
        int conta = n1 / n2;
        Console.WriteLine("O resultado da divisão é: " + conta);
    }
    else
    {
        Console.WriteLine("Operação inválida. Não é possível dividir zero!");
    }
} else if (alternativa == 5)
{
    Console.WriteLine("Até a próxima!");
}

Console.WriteLine("Pressione espaço para sair...");
while (Console.ReadKey(true).Key != ConsoleKey.Spacebar)
{

}