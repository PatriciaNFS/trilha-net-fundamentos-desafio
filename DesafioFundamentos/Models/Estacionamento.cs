using System;
using System.Collections.Generic;
using System.Linq; 

namespace DesafioFundamentos.Models
{
      
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos = new List<string>();
        string placa = "";
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            placa = Console.ReadLine();

            veiculos.Add(placa);

            Console.WriteLine("Veículo adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                decimal valorTotal = 0; 
                int.TryParse(Console.ReadLine(), out horas);
                valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())       
           {
                Console.WriteLine("Lista de veículos no estacionamento:");

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"Placa: {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo cadastrado no estacionamento.");
            }
        }
    }
}
