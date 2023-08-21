/* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos.
*/

Console.WriteLine("Entrada:");

int valor1 = int.Parse(s: Console.ReadLine());
int valor2 = int.Parse(s: Console.ReadLine());

Console.WriteLine("Saída:");
Console.WriteLine($"Soma: {valor1 + valor2}");