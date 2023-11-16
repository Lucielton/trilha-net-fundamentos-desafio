namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public bool AdicionarVeiculo(string placa)
        {
            if (veiculos.Any(v => StringComparer.OrdinalIgnoreCase.Equals(v, placa))) return false;
            
            veiculos.Add(placa);
            return true;
        }

        public bool RemoverVeiculo(string placa)
        {
            // Verifica se o veículo existe
            //if (veiculos.Any(v => v.ToUpper() == placa.ToUpper()))
            if(veiculos.Any(v => StringComparer.OrdinalIgnoreCase.Equals(v, placa)))
            {
                Console.WriteLine(MensagensUsuario.SolicitarHorasEstacionado);

                int horas = int.Parse(Console.ReadLine().ToString());
                decimal valorTotal = precoInicial + (precoPorHora * horas); 

                veiculos.Remove(placa);

                MensagensUsuario.VeiculoRemovido(placa, valorTotal);
                return true;
            }
            else
            {
                Console.WriteLine(MensagensUsuario.VeiculoNaoEstacionado);
                return false;
            }
        }

        public List<string> ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            return veiculos;
        }
    }
}
