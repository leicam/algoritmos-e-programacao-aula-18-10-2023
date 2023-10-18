namespace Aula18102023
{
    internal class Program
    {
        private static List<Cliente> _clientes = new List<Cliente>();

        static void Main(string[] args)
        {
            int opcao = 0;

            // do - while é uma estrutura de repetição
            do
            {
                Console.WriteLine("**MENU**");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                // estrutura de condição
                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        CadastrarCliente();
                        break;
                    case 2:
                        ListarClientes();
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Verifique.");
                        break;
                }

            } while (opcao != 0);
        }

        private static void CadastrarCliente()
        {
            Console.WriteLine("Informe o nome do cliente:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o sobrenome do cliente:");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do cliente:");
            string cpf = Console.ReadLine();

            Cliente cliente = new Cliente(nome, sobrenome, cpf);
            _clientes.Add(cliente);
        }

        private static void ListarClientes()
        {
            foreach(Cliente cliente in _clientes)
            {
                Console.WriteLine(cliente.ToString());
            }
        }
    }
}