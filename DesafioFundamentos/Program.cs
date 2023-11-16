using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial;
decimal precoPorHora;

Console.WriteLine(MensagensUsuario.SolicitarPrecoInicial);
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine(MensagensUsuario.SolicitarPrecoPorHora);
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    MensagensUsuario.MostrarOpcoes();

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine(MensagensUsuario.SolicitarPlacaParaEstacionar);
            es.AdicionarVeiculo(Console.ReadLine().ToString());
            break;

        case "2":
            Console.WriteLine(MensagensUsuario.SolicitarPlacaParaRemover);
            es.RemoverVeiculo(Console.ReadLine().ToString());
            break;

        case "3":
            MensagensUsuario.VeiculosEstacionados(es.ListarVeiculos());
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine(MensagensUsuario.OpcaoInvalida);
            break;
    }

    Console.WriteLine(MensagensUsuario.PressioneUmaTecla);
    Console.ReadLine();
}

Console.WriteLine(MensagensUsuario.ProgramaEncerrado);
