/* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe porhora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casasdecimais.
*/

using System.Globalization;

Console.WriteLine("Entre com o número do funcionário:");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o número de horas trabalhadas:");
int workedHours = int.Parse(Console.ReadLine());

Console.WriteLine("Valor (R$) por hora trabalhada:");
double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salary = workedHours * valuePerHour;
Console.WriteLine("SALARY = {0}", salary.ToString("F2", CultureInfo.InvariantCulture));


