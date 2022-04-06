// See https://aka.ms/new-console-template for more information
Console.WriteLine("executando projeto 9");

Console.WriteLine("qual é a idade de João ?");
int idadeJoao = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("há quantas pessoas");

int quantidadeDePessoas = Convert.ToInt32(Console.ReadLine());
bool acompanhado = quantidadeDePessoas  >= 2;
string mensagemAdicional;

if (acompanhado == true)
{
    mensagemAdicional = "joao esta acompanhado";
}
else
{
    mensagemAdicional = "joao nao esta acompanhado";
}

if (idadeJoao >= 18 || acompanhado)
{
    Console.WriteLine("Joao pode passar");
    Console.WriteLine(mensagemAdicional);
}
else
{
    Console.WriteLine("joao NÃO pode passar");
    Console.WriteLine(mensagemAdicional);
}
