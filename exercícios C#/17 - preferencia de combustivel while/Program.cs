bool fim = false;

int alcool = 0;
int gasolina = 0;
int diesel = 0;

while(fim == false)
{
    Console.WriteLine("1 - Álcool");
    Console.WriteLine("2 - Gasolina");
    Console.WriteLine("3 - Diesel");
    Console.WriteLine("4 - Fim");

    int escolha = int.Parse(s: Console.ReadLine());
    if (escolha == 1)
    {
        alcool++;
    } else if (escolha == 2)
    {
        gasolina++;
    } else if (escolha == 3)
    {
        diesel++;
    } else if (escolha == 4)
    {
        fim = true;
    }
    else
    {
        Console.WriteLine("Informe um número válido.");
        Console.ReadLine();
    }
    Console.Clear();
}
Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine("Álcool = {0}", alcool);
Console.WriteLine("Gasolina = {0}", gasolina);
Console.WriteLine("Diesel = {0}", diesel);