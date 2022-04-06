// See https://aka.ms/new-console-template for more information
Console.WriteLine("executando codigo 12");

double valorInvestido = 1000.0;
double fatorRendimento = 1.0036;

for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
{
    for (int contadorDeMes = 1; contadorDeMes <= 12; contadorDeMes++)
    {
        valorInvestido *= 1.0036;
        Console.WriteLine("Após " + contadorAno + " anos e " + contadorDeMes + " meses você terá R$ " + valorInvestido);
    }
    fatorRendimento += 0.0010;
    contadorAno++;
}
