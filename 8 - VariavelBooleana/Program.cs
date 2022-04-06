Console.WriteLine("executando programa 8");

Console.WriteLine("qual é a idade de João ?");
int idadeJoao = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("há quantas pessoas");
int quantidadeDePessoas = Convert.ToInt32(Console.ReadLine());

bool acompanhado = quantidadeDePessoas  >= 2;

//bool acompanhado = true;
if (idadeJoao >= 18 || acompanhado)
{
    Console.WriteLine("Joao pode passar");
}
else
{
    Console.WriteLine("joao NÃO pode passar");
}



