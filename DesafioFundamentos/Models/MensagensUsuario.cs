public class MensagensUsuario
{
    public static string SolicitarPrecoInicial = "Seja bem vindo ao sistema de estacionamento!\n" +
                                                 "Digite o preço inicial:";
    public static string SolicitarPrecoPorHora = "Digite o preço por hora:";
    public static string SolicitarPlacaParaEstacionar = "Digite a placa do veículo para estacionar:";
    public static string SolicitarPlacaParaRemover = "Digite a placa do veículo para remover:";
    public static string SolicitarHorasEstacionado = "Digite a quantidade de horas que o veículo permaneceu estacionado:";
    public static string VeiculoNaoEstacionado = "Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente";
    public static string NaoHaVeiculosEstacionados = "Não há veículos estacionados.";
    public static string OpcaoInvalida = "Opção inválida";
    public static string PressioneUmaTecla = "Pressione uma tecla para continuar";
    public static string ProgramaEncerrado = "O programa se encerrou";

    public static void MostrarOpcoes(){
        Console.Clear();
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine("1 - Cadastrar veículo");
        Console.WriteLine("2 - Remover veículo");
        Console.WriteLine("3 - Listar veículos");
        Console.WriteLine("4 - Encerrar");
    }

    public static void VeiculoRemovido(string placa, decimal valorTotal){
        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
    }

    public static void VeiculosEstacionados(List<string> veiculos){
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (string veiculo in veiculos) Console.WriteLine(veiculo);         
        }
        else
            Console.WriteLine(NaoHaVeiculosEstacionados);
    }
}