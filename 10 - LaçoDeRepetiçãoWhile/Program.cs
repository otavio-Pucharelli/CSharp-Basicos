// See https://aka.ms/new-console-template for more information
Console.WriteLine("executando programa 10");

double valorInvestido = 1000;
int contadorDeMes = 1;

while (contadorDeMes <= 12)
{
    valorInvestido =  valorInvestido + valorInvestido + 0.0036;
    Console.WriteLine("Após " + contadorDeMes + " você tera R$ " + valorInvestido);
    contadorDeMes++;
}