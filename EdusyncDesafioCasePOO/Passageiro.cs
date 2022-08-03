using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdusyncDesafioCasePOO
{
    public class Passageiro : Pessoa
    {
        public TipoPagamento Pagamento { get; set; }
        public bool Viajando { get; set; } = false;
        public Passageiro(string nome, string cpf, string email, string senha, string telefone) : base(nome, cpf, email, senha, telefone)
        {
        }


        public enum TipoPagamento
        {
            Cartao,
            Dinheiro
        }
        public static void Logar(CadastroUsuarios _passageiros)
        {
            string _email, _senha;


            Console.WriteLine("Entre com seu Email: ");
            _email = Console.ReadLine();
            Console.WriteLine("Entre com sua senha: ");
            _senha = Console.ReadLine();

            if (_passageiros.motoristas.Count == 0)
            {
                Console.WriteLine("Nenhum Motorista cadastrado!");
            }

            foreach (var item in _passageiros.passageiros)
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
