namespace DesafioEstacionamento.models

{
    public class Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        private decimal precoInicial = precoInicial;
        private decimal precoPorHora = precoPorHora;
        private List<string?> veiculos = [];

        public void AdicionarVeiculo()
        {
            Console.Clear();

            // Pede para o usuário digitar uma placa (ReadLine) e adiciona na lista "veiculos"
            Console.Write("Digite a placa do veículo para estacionar: ");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.Write("Digite a placa do veículo para remover: ");
            string? placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Write("\nDigite a quantidade de horas que o veículo permaneceu estacionado: ");
               
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas; 

                // Remove a placa digitada da lista de veículos
                veiculos.Remove(placa); 

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            Console.Clear();

            // Verifica se há veículos no estacionamento
            if (veiculos.Count != 0)
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Realiza um laço de repetição, exibindo os veículos estacionados
                foreach (string? placa in veiculos)
                {
                    Console.WriteLine($"- {placa}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
