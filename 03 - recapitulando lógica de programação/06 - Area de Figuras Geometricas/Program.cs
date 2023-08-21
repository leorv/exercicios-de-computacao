/* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule emostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
*/

using System.Globalization;

Console.WriteLine("Entre com os 3 valores separados por um espaço. (A, B e C):");
string[] valores = Console.ReadLine().Split(' ');

double A  = double.Parse(valores[0], CultureInfo.InvariantCulture);
double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

double area_trianguloRetangulo = A * C / 2;
double area_circulo = Math.PI * C * C;
double area_trapezio = ((A + B) / 2) * C;
double area_quadrado = B * B;
double area_retangulo = A * B;

Console.WriteLine($"a) Área do triângulo retângulo: {area_trianguloRetangulo.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"b) Área do círculo: {area_circulo.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"c) Área do trapézio: {area_trapezio.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"d) Área do quadrado: {area_quadrado.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"e) Área do retângulo: {area_retangulo.ToString("F2", CultureInfo.InvariantCulture)}");
