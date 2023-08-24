/* Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadasde um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence oponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

Se o ponto estiver na origem, escreva a mensagem “Origem”.

Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for asituação.*/

Console.WriteLine("Entre com as coordenadas de um ponto definido por X e Y num plano, separe por um espaço.");
string[] pontos = Console.ReadLine().Split(' ');

int coordX = int.Parse(pontos[0]);
int coordY = int.Parse(pontos[1]);

if (coordX > 0 && coordY > 0)
{
    Console.WriteLine("Q1");
}
else if (coordX < 0 && coordY > 0)
{
    Console.WriteLine("Q2");
}
else if (coordX < 0 && coordY < 0)
{
    Console.WriteLine("Q3");
}
else if (coordX > 0 && coordY < 0)
{
    Console.WriteLine("Q4");
}
else if (coordX == 0 && coordY == 0)
{
    Console.WriteLine("ORIGEM");
}
else if (coordX == 0)
{
    Console.WriteLine("EIXO Y");
}
else
{
    Console.WriteLine("EIXO X");
}