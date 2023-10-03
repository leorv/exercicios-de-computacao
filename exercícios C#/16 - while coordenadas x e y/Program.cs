/* Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistemacartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelomenos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
*/

bool valorNulo = false;

while (valorNulo == false)
{
    Console.Write("Insira as coordenadas: ");
    string[] pontos = Console.ReadLine().Split(' ');

    int X = int.Parse(pontos[0]);
    int Y = int.Parse(pontos[1]);

    if (X > 0 && Y > 0)
    {
        Console.WriteLine("Primeiro quadrante");
    }
    else if (X < 0 && Y > 0)
    {
        Console.WriteLine("Segundo quadrante");
    }
    else if (X < 0 && Y < 0)
    {
        Console.WriteLine("Terceiro quadrante");
    }
    else if (X > 0 && Y < 0)
    {
        Console.WriteLine("Quarto quadrante");
    }
    else
    {
        valorNulo = true;
    }
}

Console.WriteLine("Foi inserido um valor nulo.");
