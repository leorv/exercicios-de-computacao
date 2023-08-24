/* Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dosseguintes intervalos ([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver emnenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.*/


Console.WriteLine("Insira um número qualquer:");
int numero = int.Parse(Console.ReadLine());

if (numero >= 0 && numero <= 25)
{
    Console.WriteLine("INTERVALO [0,25]");
}
else if (numero > 25 &&  numero <= 50)
{
    Console.WriteLine("INTERVALO (25,50]");
}
else if (numero > 50 && numero <= 75)
{
    Console.WriteLine("INTERVALO (50,75]");
}
else if (numero > 75 && numero <= 100)
{
    Console.WriteLine("INTERVALO [75,100]");
}
else
{
    Console.WriteLine("Número fora dos intervalos válidos.");
}