using System;

namespace EdusyncDesafioCasePOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBanco conta = new ContaBanco(ContaBanco.TipoConta.Corrente, "00-7", "1234");
            Carro carro = new Carro("asdf-2022","Honda","Civic","Preto");
            
            Motorista motorista = new Motorista("giovane","13246", "giovane@email.com", "123", "123456" ,carro, conta);
            CadastroUsuarios cadastro = new CadastroUsuarios();
            cadastro.CadastrarMotorista(motorista);
            
            
            Console.Write("Motorista ou  Passageiro? [M] [P]");
            string inicio = Console.ReadLine().ToUpper();
            if(inicio == "M")
            {
                Console.Write("Possui Login? [S] [N]");
                string novoLogin= Console.ReadLine().ToUpper();
                if(novoLogin == "S")
                {
                    Motorista.Logar(cadastro);
                }else if(novoLogin == "N")
                {
                    Console.WriteLine("Entre em cadastrar!");
                    
                }
            }else if(inicio == "P")
            {
                Console.Write("Possui Login? [S] [N]");
                string novoLogin = Console.ReadLine().ToUpper();
                if (novoLogin == "S")
                {
                    Motorista.Logar(cadastro);
                }
                else if (novoLogin == "N")
                {
                    Console.WriteLine("Entre em cadastrar!");

                }
            }























            //Motorista motorista = new Motorista("Thor Odin Son", "123.456.789-01", "thor@email.com", "soudigno", "playboyzinho");
            //Carro carro = new Carro("abcd-2022", "Honda", "Civic", "Preto");
            //string _placa = " ";
            //Carro carro1 = new Carro(_placa);

           // Carro novoCarro = new Carro();

            //Motorista motorista1 = new Motorista(motorista, carro, conta);

            //Motorista motorista2 = new Motorista("Thor Odin Son", "123.456.789-01", "thor@email.com", "soudigno", "playboyzinho");

            //Passageiro passageiro = new Passageiro("Yudi Tamashiro", "123.456.789-00", "yudi@email.com", "senha123", "4002-8922");
            //Pessoa passageiro = new Pessoa("Yudi Tamashiro", "123.456.789-00", "yudi@email.com", "senha123", "4002-8922");

            //Endereco origem = new Endereco("Rua dos Bobos", 0, "boca do sapo", "Campinas");


            //passageiro.Logar("playboyzinho@email.com", "soudigno");


        }
    }
}
