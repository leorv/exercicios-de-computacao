
Console.WriteLine("Informe um número inteiro:");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Números ímpares:");
for (int i = 1; i <= numero; i++)
{
    if (i % 2 != 0) Console.WriteLine(i);
}