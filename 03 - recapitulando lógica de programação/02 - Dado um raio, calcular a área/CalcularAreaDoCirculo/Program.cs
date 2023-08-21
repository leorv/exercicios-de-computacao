using System.Globalization;

Console.WriteLine("Calcular a área do círculo.");

Console.WriteLine("Raio:");

float raio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

float area = (float)(Math.PI * raio * raio);

Console.WriteLine("Área: {0}", area.ToString("F4", CultureInfo.InvariantCulture));
