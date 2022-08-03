using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdusyncDesafioCasePOO
{
    public class Viagem : Endereco
    {
        public Viagem(string rua, int numero, string bairro, string cidade) : base(rua, numero, bairro, cidade)
        {
        }

        public Endereco Origem { get; set; }
        public Endereco Desitino { get; set; }
        public StatusViagem Status { get; set; }
        public bool AdicionarParada { get; set; }
        public enum StatusViagem
        {
            AguardandoMotorista,
            Iniciada,
            Finalizada,
            Cancelada
        }

        public void AdicionaParda(Viagem _novaParada)
        {
            Desitino = _novaParada;
        }

        public string CacelaViagem()
        {
            return "Viagem cancelada";
        }
    }
}
