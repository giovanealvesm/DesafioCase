using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdusyncDesafioCasePOO
{
    internal class Cartao
    {
        public TipoCartao SelecionaTipo { get; set; }
        public string NumCartao { get; set; }
        public DateTime Validade { get; set; }
        public int Cvv { get; set; }
        public string Bandeira { get; set; }
        public enum TipoCartao
        {
            Debito,
            Credito
        }

        List<Cartao> catoes = new List<Cartao>();

        public void AdicionarCartao(Cartao _cartao)
        {
            catoes.Add(_cartao);
        }
    }
}
