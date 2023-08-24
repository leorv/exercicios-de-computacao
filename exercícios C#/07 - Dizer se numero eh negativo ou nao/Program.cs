/* 
 * Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não. 
 * 
 */

Console.WriteLine("Entre com o número:");
int numero = int.Parse(Console.ReadLine());

if (numero < 0)
{
    Console.WriteLine("NEGATIVO");
} else
{
    Console.WriteLine("POSITIVO");
}
