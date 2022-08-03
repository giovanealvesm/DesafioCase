using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdusyncDesafioCasePOO
{
    public class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }


        public Endereco(string rua, int numero, string bairro, string cidade)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }

        List<Endereco> enderecos = new List<Endereco>();
        public void AdicionarEndereco(Endereco _endereco)
        {
            enderecos.Add(_endereco);
        }
        public void MostrarEndereco()
        {
            foreach (var item in enderecos)
            {
                Console.WriteLine($"{item.Rua} Nº {item.Numero}, {item.Bairro} - {item.Cidade}");
            }
        }


    }
}
