/* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrandoessas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/

Console.WriteLine("Entre com o número de iterações:");
int iteracoes = int.Parse(Console.ReadLine());

int dentro = 0;
int fora = 0;

for (int i = 0; i < iteracoes; i++)
{
    Console.Write("Digite um número:");
    int valor = int.Parse(Console.ReadLine());

    if (valor >= 10 && valor <= 20)
    {
        dentro++;
    }
    else
    {
        fora++;
    }
}
Console.WriteLine("{0} in", dentro);
Console.WriteLine("{0} out", fora);