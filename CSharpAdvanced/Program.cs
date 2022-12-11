using CSharpAdvanced.Models;

string NomeProduto = "PC Gamer";
double Valor = 1.232;
int QTDProduto = 32;

ProdutoModel produto = new ProdutoModel(NomeProduto,Valor, QTDProduto);

ProdutoModel produto2 = new ProdutoModel("Teste", 21.22);

Console.WriteLine($"Nome       = {produto.Nome}.");
Console.WriteLine($"Preço      = {produto.Preco}.");
Console.WriteLine($"Quantidade = {produto.Quantidade} .");
