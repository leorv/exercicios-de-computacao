/* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, ocódigo de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
*/

using System.Globalization;

int code1 = 0;
int code2 = 0;
int number1 = 0;
int number2 = 0;
double value1 = 0;
double value2 = 0;

Console.WriteLine("Código da peça 1:");
code1 = int.Parse(Console.ReadLine());

Console.WriteLine("Número de peças 1:");
number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Valor unitário da peça 1:");
value1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Código da peça 2:");
code2 = int.Parse(Console.ReadLine());

Console.WriteLine("Número de peças 2:");
number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Valor unitário da peça 2:");
value2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double total = number1 * value1 + number2 * value2;
Console.WriteLine("VALOR A PAGAR: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));