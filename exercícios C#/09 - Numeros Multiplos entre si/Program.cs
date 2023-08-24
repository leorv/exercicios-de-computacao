/* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao saoMultiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados emordem crescente ou decrescente.
*/

Console.WriteLine("Entre com os dois números separados por um espaço.");

string[] numeros = Console.ReadLine().Split(' ');

int numero1 = int.Parse(numeros[0]);
int numero2 = int.Parse(numeros[1]);

if (numero1 % numero2 == 0)
{
    Console.WriteLine("Sao Multiplos");
} else if (numero2 % numero1 == 0)
{
    Console.WriteLine("Sao Multiplos");
} else
{
    Console.WriteLine("Nao sao multiplos");
}


