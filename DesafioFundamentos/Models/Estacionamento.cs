using System.ComponentModel;
using System.Diagnostics;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        private int horasNoParking = 0;


        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"--
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa--
            int Vaga = 0 + 1;
            foreach(string placaEstacionado in veiculos){
                Console.WriteLine($"Vaga do carro:{Vaga} | Placa do Carro:{placaEstacionado}");
                Vaga++;
            }
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,--
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                int horas = int.Parse(Console.ReadLine());

                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal--            
                decimal valorTotal = precoInicial + precoPorHora * horas;

                // TODO: Remover a placa digitada da lista de veículos--
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            int Vaga = 0 + 1;
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados--
                foreach(string placaEstacionado in veiculos){
                    Console.WriteLine($"Vaga do carro:{Vaga} | Placa do Carro:{placaEstacionado}");
                    Vaga++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void PreçoTotal()
        {
            int Vaga = 0 + 1;
            foreach(string placaEstacionado in veiculos){
                Console.WriteLine($"Vaga do carro:{Vaga} | Placa do Carro:{placaEstacionado}");
                Vaga++;
            }
            Console.WriteLine("Digite a placa do veículo para verificar:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())){
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horasNoParking = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horasNoParking;
                Console.WriteLine($"O veículo {placa} está com preço total de: R$ {valorTotal}");
            }
            else{
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }

        }
    }
}
