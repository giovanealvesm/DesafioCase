using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdusyncDesafioCasePOO
{
    public class CadastroUsuarios
    {
        public List<Motorista> motoristas = new List<Motorista>();
        public List<Passageiro> passageiros = new List<Passageiro>();
        public List<Motorista> CadastrarMotorista(Motorista _motorista)
        {
            motoristas.Add(_motorista);
            return motoristas;
        }
        public List<Passageiro> CadastrarPassageiro(Passageiro _passageiro)
        {
            passageiros.Add(_passageiro);
            return passageiros;
        }
    }
}
