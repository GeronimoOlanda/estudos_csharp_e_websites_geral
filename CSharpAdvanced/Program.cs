using CSharpAdvanced.Fundamentos;

IList<string> pessoas = new List<string>();


var nome = "";
while(nome != "Parou")
{
    Console.WriteLine("Digite o nome...");
    nome = Console.ReadLine();
    Console.WriteLine($"Seu nome é {nome}");


    if (nome != null)
    {
        pessoas.Add(nome);
    }
   
}
foreach (var pe in pessoas)
{
    Console.WriteLine(pe);
}


Fundamentos fundamentos = new Fundamentos();

Console.WriteLine(fundamentos.Mensagem("Louvado seja o nome do senhor Jesus Cristo!"));