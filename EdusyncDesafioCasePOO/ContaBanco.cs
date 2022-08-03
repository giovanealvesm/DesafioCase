using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdusyncDesafioCasePOO
{
    public class ContaBanco
    {
        public ContaBanco(TipoConta tipoDeConta, string contaNumero, string contaAgencia)
        {
            TipoDeConta = tipoDeConta;
            ContaNumero = contaNumero;
            ContaAgencia = contaAgencia;
        }

        public TipoConta TipoDeConta { get; set; }
        public string ContaNumero { get; set; }
        public string ContaAgencia { get; set; }

        public enum TipoConta
        {
            Corrente,
            Poupanca
        }

    }
}
