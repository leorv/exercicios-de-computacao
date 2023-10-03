/* Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.Lembrando que, por definição, fatorial de 0 é 1.
*/

Console.WriteLine("Entre com um número:");

int N = int.Parse(Console.ReadLine());

int fatorial = 1;
for (int i = 0; i < N; i++)
{
    fatorial *= (N - i);
}

Console.WriteLine(fatorial.ToString());