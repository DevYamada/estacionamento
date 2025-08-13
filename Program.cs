// See https://aka.ms/new-console-template for more information
using novoProjeto.Models;

decimal precoInicial = 0;
decimal precoHora = 0;

bool exibirMenu = true;

Console.WriteLine("Digite o Preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o Preço por hora: ");
precoHora = Convert.ToDecimal(Console.ReadLine());


Carro carro = new Carro(precoInicial, precoHora);

while (exibirMenu)
{
    Console.WriteLine("Selecione a Opção: ");
    Console.WriteLine("1 - Cadastrar Veículo: ");
    Console.WriteLine("2 - Remover Veículo: ");
    Console.WriteLine("3 - Listar Veículos: ");
    Console.WriteLine("4 - Encerrar: ");

    switch (Console.ReadLine())
    {
        case "1":
            carro.Adicionar();          
            break;
        case "2":
            carro.Remover();
            break;
        case "3":
            carro.Listar();
            break;
        case "4":
            exibirMenu = false;
            break;

    }
}