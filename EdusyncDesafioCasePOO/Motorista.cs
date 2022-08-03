using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdusyncDesafioCasePOO
{
    public class Motorista : Pessoa
    {
        public Carro TipoCarro { get; set; }
        public ContaBanco Receber { get; set; }
        public bool AceitarCorrida { get; set; }

        public List<Carro> carros = new List<Carro>();
        public List<ContaBanco> contas = new List<ContaBanco>();

        public Motorista(string nome, string cpf, string email, string senha, string telefone, Carro _tipoCarro, ContaBanco _receber) : base(nome, cpf, email, senha, telefone)
        {
            TipoCarro = _tipoCarro;
            Receber = _receber;
            
        }
        
        public void CadastrarCarro(Carro _carro)
        {
            carros.Add(_carro);
        }
        public void AdicionarConta(ContaBanco _conta)
        {
            contas.Add(_conta);
        }
        public static void Logar(CadastroUsuarios _motoristas)
        {
            string _email, _senha;


            Console.WriteLine("Entre com seu Email: ");
            _email = Console.ReadLine();
            Console.WriteLine("Entre com sua senha: ");
            _senha = Console.ReadLine();

            if (_motoristas.motoristas.Count == 0)
            {
                Console.WriteLine("Nenhum Motorista cadastrado!");
            }

            foreach (var item in _motoristas.motoristas)
            {
                if (item.Email == _email && item.Senha == _senha)
                {
                    Console.WriteLine("Login realizado com sucesso");
                }
                else
                {
                    Console.WriteLine("Email ou senha incorreto!");
                }
            }
        }
    }
}
