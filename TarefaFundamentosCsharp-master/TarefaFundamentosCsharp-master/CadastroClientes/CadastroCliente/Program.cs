using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    class Program
    {
        public static List<Cliente> lCliente = new List<Cliente>();

        static void Main(string[] args)
        {
            var opcao = true;

            int caseSwitch = 1;

            do
            {
                Console.Title = " * SISTEMA DE RECEBIMENTOS * ";
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Clear();


                Console.WriteLine("-------------------------");
                Console.WriteLine("     MENU       ");
                Console.WriteLine("-------------------------");
               
                Console.WriteLine("1. Cadastrar Cliente");
                Console.WriteLine("2. Alterar Cliente");
                Console.WriteLine("3. Excluir Cliente");
                Console.WriteLine("4. Listar Cliente");
                Console.WriteLine("5. Sair");
                Console.WriteLine(" Informe a opção deseja: \n");
                Console.SetCursorPosition(25, 8);


                caseSwitch = Convert.ToInt32(Console.ReadLine());                
                if (caseSwitch == 5)
                {
                    opcao = false;
                    Console.Write("good by!");
                }

                Console.Clear();

                switch (caseSwitch)
                {
                    case 1:
                        var cliente = new Cliente();
                        Console.WriteLine("Bem vido ao cadastro de usuário");
                        Console.WriteLine("Digite o codigo : ");
                        cliente.Id = Convert.ToInt32(Console.ReadLine());
                        

                        Console.WriteLine("Digite o nome : ");
                        cliente.Nome = Console.ReadLine();

                        Console.WriteLine("Digite o endereço : ");
                        cliente.Endereco = Console.ReadLine();

                        Console.WriteLine("Digite o telefone : ");
                        cliente.Telefone = Console.ReadLine();

                        lCliente.Add(cliente);

                        break;
                    case 2:

                        var clienteAlterar = new Cliente();

                        foreach (var item in lCliente)
                        {
                            Console.WriteLine("Código: " + item.Id);
                            Console.WriteLine("Nome: " + item.Nome);
                            Console.WriteLine("Endereço: " + item.Endereco);
                            Console.WriteLine("Telefone: " + item.Telefone);
                        }

                        Console.Write("Digite o codigo do cliente para alterar : ");
                        clienteAlterar.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nome: ");
                        clienteAlterar.Nome = Console.ReadLine();
                        Console.Write("Endereço: ");
                        clienteAlterar.Endereco = Console.ReadLine();
                        Console.Write("Telefone: ");
                        clienteAlterar.Telefone = Console.ReadLine();
                        foreach (var item in lCliente)
                        {
                            if (item.Id == clienteAlterar.Id)
                            {
                                lCliente.Remove(item);
                                lCliente.Add(clienteAlterar);
                                break;
                            }
                        }

                        break;
                    case 3:
                        Console.WriteLine("Excluir Usuario");
                        Console.WriteLine("Informe o Id do Usuario");
                        var clienteExcluir = new Cliente();

                        clienteExcluir.Id = Convert.ToInt32(Console.ReadLine());

                        foreach (var item in lCliente)
                        {
                            if (item.Id == clienteExcluir.Id)
                                lCliente.Remove(item);
                        }


                        Console.WriteLine("Listar Usuario");
                        break;
                    case 4:

                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Listar Usuario");

                        foreach (var item in lCliente)
                        {
                            Console.WriteLine("Código: " + item.Id.ToString());
                            Console.WriteLine("Nome: " + item.Nome);
                            Console.WriteLine("Endereço: " + item.Endereco);
                            Console.WriteLine("Telefone: " + item.Telefone);
                        }

                        Console.WriteLine("--------------------------------------------");
                        
                        var v = Console.ReadLine();
                        break;
                }

              

            } while (opcao);
           
           
        }

       
    }

    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}
