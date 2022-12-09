using CSharpAdvanced.Models;

PessoaModel Pessoa = new PessoaModel();

Pessoa.Nome = "Geronimo";
Pessoa.Idade = 24;


PessoaModel p1 = new PessoaModel()
{
    Id = "1",
    Nome = "Jesus",


};

    Console.WriteLine($"Indice na Lista: {p1.Id}.\nNome: {p1.Nome}.");

