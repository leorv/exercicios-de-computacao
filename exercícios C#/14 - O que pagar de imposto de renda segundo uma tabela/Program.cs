/* Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabemque nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, semqualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.

Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule emostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.Renda                   Impostode 0 a 2000             isentode 2000.01 a 3000       8%de 3000.01 a 4500       18%de 4500 pra cima        28%Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa desalário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa éde 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso comduas casas decimais.*/

using System.Globalization;

Console.WriteLine("Informe a renda:");
double renda = double.Parse(Console.ReadLine());

double imposto;
double valorAPagar;
if (renda >= 0 && renda <= 2000)
{
    imposto = 0;
}
else if (renda > 2000 && renda <= 3000)
{
    imposto = 0.08;
}
else if (renda > 3000 && renda < 4500)
{
    imposto = 0.18;
}
else
{
    imposto = 0.28;
}

valorAPagar = renda * imposto;

Console.WriteLine("Imposto a pagar: {0}", valorAPagar.ToString("F2", CultureInfo.InvariantCulture));

