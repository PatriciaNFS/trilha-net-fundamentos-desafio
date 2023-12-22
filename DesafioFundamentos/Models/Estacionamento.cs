namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.veiculos = new List <Veiculo>();
        }

        public void AdicionarVeiculo()
        {
         Console.WriteLine("Digite a placa do veículo para estacionar:");
         string placa Console.ReadLine(); 
        Veiculo novo Veiculo = new Veiculo
            {
                Placa = placa
            };

            veiculos.Add (novo veiculo);

            Console.WriteLine ("Veículo adicionado com sucesso!");

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placaRemover = Console.ReadLine();
            Veiculo veiculoRemover = veiculos.FistOrDefault(V=>V.Placa == placaRemover);
            if (veiculoRemover!=null)
            }
        veiculo.Remove (veiculoRemover);
        Console.WriteLine ("Veículo removido com sucesso.");
    }
    else 
    {
        Console.WriteLine ("Veículo não encontrado. Verifique a placa e tente novamente.");
    }
}
            
           
            Console.WriteLine ("Digite a placa do veículo: ");
            string placa = Console.ReadLine();

            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse (Console.readLine());

                decimal precoInicial = 0;
                decimal precoPorHora = 0;
                decimal valorTotal = 0; 
                int horas =0;

                Console.WriteLine ("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                decimal variavelTotal = precoInicial + (precoPorHora* horas);              
                
                Console.WriteLine($"O valor total a ser pago: {valorTotal:C}");
            }
            else
            {
                    veiculos.Remove(placa);
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.");
                
            }
        }

        public void ListarVeiculos()
        {
            
            if (veiculos.Count>0)
                    
            {
                Console.WriteLine("Veículos estacionados");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine ("$"Placa: veiculo.Placa}");
                }
                else
            {
                Console.WriteLine("Não há veículos cadastrados no estacionamento.");
            }
        }
    }
}
