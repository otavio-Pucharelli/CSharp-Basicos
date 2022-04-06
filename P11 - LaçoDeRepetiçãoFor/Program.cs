// See https://aka.ms/new-console-template for more information
Console.WriteLine("executando Programa 11");

double valorInvestido = 1000.0;

for (int contadorDeMes = 1; contadorDeMes <= 12; contadorDeMes++)
{
    valorInvestido *= 1.0036;
    Console.WriteLine("Após " + contadorDeMes + " você tera R$ " + valorInvestido);
}

