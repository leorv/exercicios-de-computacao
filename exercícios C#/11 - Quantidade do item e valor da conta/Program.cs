/* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. Aseguir, calcule e mostre o valor da conta a pagar.

1   cachorro quente     4,00
2   x-salada            4,50
3   x-bacon             5,00
4   torrada simples     2,00
5   refrigerante        1,50
*/

using System.Globalization;

Console.Write("Código do item: ");
int codigo = int.Parse(Console.ReadLine());

Console.Write("Quantidade: ");
int quantidade = int.Parse(Console.ReadLine());

double total;

if (codigo == 1)
{
    // cachorro quente
    total = 4 * quantidade;
} else if (codigo == 2)
{
    // x-salada
    total = 4.5 * quantidade;
} else if (codigo == 3)
{
    // x-bacon
    total = 5 * quantidade;
} else if (codigo == 4)
{
    // torrada simples
    total = 2 * quantidade;
} else {
    // refirgerante
    total = 1.5 * quantidade;
}

Console.WriteLine("Total a pagar: R$ {0}", total.ToString("F2"));