using System.Numerics;

Console.WriteLine("Hello, World!");
float n1, n2, n3, media;


Console.WriteLine("Digite a nota1");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota2");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota3");
n3 = float.Parse(Console.ReadLine());


media = (n1 + n2 + n3) / 3;

Console.WriteLine("A média é: " + media);
