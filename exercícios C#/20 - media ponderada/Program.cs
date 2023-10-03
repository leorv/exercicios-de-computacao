/* Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
peso 5.
*/

using System.Globalization;

Console.WriteLine("Entre com o número de testes:");
int numeroDeTestes = int.Parse(Console.ReadLine());

double[] medias = new double[numeroDeTestes];

for (int i = 0; i < numeroDeTestes; i++)
{
    Console.WriteLine();
    Console.WriteLine("Entre com os valores, utilize ponto como separador de decimais.");
    Console.Write("Valor 1: ");
    double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Valor 2: ");
    double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Valor 3: ");
    double num3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    medias[i] = (num1 * 2 + num2 * 3 + num3 * 5) / 10;

}

Console.WriteLine("Resultados");
Console.WriteLine();

foreach (double media in medias)
{
    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
}