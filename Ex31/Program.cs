// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

int A;
int B;

Console.WriteLine("Digite o valor de A:");
A = int.Parse(Console.ReadLine());


Console.WriteLine("Digite o valor de B:");
B = int.Parse(Console.ReadLine());

if (A > B)
{
   Console.WriteLine(" A é maior que B");
}
else
{
    Console.WriteLine("B é maior que A");
}