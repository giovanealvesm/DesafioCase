using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdusyncDesafioCasePOO
{
    public class Pessoa
    {
        public Pessoa(string nome, string cpf, string email, string senha, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Senha = senha;
            Telefone = telefone;
        }
        public Pessoa()
        {
        }
        protected string Nome { get; set; }
        protected string Cpf { get; set; }
        protected string Email { get; set; }
        protected string Senha { get; set; }
        protected string Telefone { get; set; }


        /// <summary>
        /// Cria lista pessoas e adiciona pessoa na lista
        /// </summary>
        /// <param name="_pessoa"></param>
        public void CadastrarPessoas(Pessoa _pessoa)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(_pessoa);
        }
        
    }
}
