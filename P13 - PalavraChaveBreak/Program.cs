// See https://aka.ms/new-console-template for more information
Console.WriteLine("executando programa 13");

for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    Console.WriteLine();
    for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
    {
        Console.Write("*");
        if (contadorColuna >= contadorLinha)
        {
            break;
        }
    }
}

for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    Console.WriteLine();
    for (int contadorColuna = 0; contadorColuna < contadorLinha; contadorColuna++)
    {
        Console.Write("*");
        if (contadorColuna >= contadorLinha)
        {
            break;
        }
    }
}

