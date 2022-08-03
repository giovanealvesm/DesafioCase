using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdusyncDesafioCasePOO
{
    public class Carro
    {

       

        public Carro(string placa, string marca, string modelo, string cor)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
        }

        List<Carro> carros = new List<Carro>();
        public void CadastraCarro()
        {
            Console.WriteLine("Entre com a placa do carro: ");
            string placa = Console.ReadLine();
            Console.WriteLine("Entre com a marca do carro: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Entre com o modelo do carro: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Entre com a cor do carro: ");
            string cor = Console.ReadLine();
            carros.Add(new Carro(placa, marca, modelo, cor));
        }
        
        
        private string Placa { get; set; }
        public string Marca { get; set; }
        private string Modelo { get; set; }
        private string Cor { get; set; }


    }
}
