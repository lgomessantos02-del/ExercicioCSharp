// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int N;


Console.WriteLine("Escolha um Número:");
N = int.Parse(Console.ReadLine());

if (N <= 10)
{
    Console.Write("f1");
}
else if (N > 100)
{
    Console.Write("f2");
}
else
{
    Console.Write("f3");
}