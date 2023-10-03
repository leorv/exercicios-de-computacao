/* Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelosegundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
*/

using System.Globalization;

Console.WriteLine("Entre com o número N:");

int n = int.Parse(Console.ReadLine());

for  (int i = 0; i < n; i++)
{
    string[] numeros = Console.ReadLine().Split(' ');

    float num1 = float.Parse(numeros[0]);
    float num2 = float.Parse(numeros[1]);

    if (num2 == 0)
    {
        Console.WriteLine("Divisão impossível.");
    }
    else
    {
        float result = num1 / num2;
        Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
    }
}