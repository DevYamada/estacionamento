using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace novoProjeto.Models
{
    public class Carro
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;


        public Carro(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }
        public string Placa { get; set; }

        private List<string> Placas = new List<string>();
        public void Adicionar()
        {
            Console.WriteLine("Digite a placa Para adicionar: ");
            string placa = Console.ReadLine();
            Placas.Add(placa);
        }

        public void Remover()
        {
            Console.WriteLine("Digite a placa para remover: ");
            string placa = Console.ReadLine();
            for (var i = 0; i < Placas.Count(); i++)
            {
                if (Placas[i] == placa)
                {
                    Console.WriteLine("Veículo Encontrado, digite a quantidade de horas: ");
                    decimal horas = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine($"O valor total foi: {precoInicial + precoHora * horas}");
                    Placas.RemoveAt(i);
                    Console.WriteLine("Placa Removida!");
                    break;
                }
            }
        }

        public void Listar()
        {
            foreach (var item in Placas)
            {
                Console.WriteLine(item);
            }
        }
    }
}