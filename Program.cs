using System; //BIBLIOTECA BASICA DO C#
using System.Collections.Generic; // PERMITE USAR LISTAS
// criação da classe que representa um cliente

// criação da classe onde ficarão os clientes
class Program
{
    static List<Cliente> clientes = new List<Cliente>();

    static void Main()
    {
        int opcao = -1; //começa com menos um p entrar no loop
//loop para a copntinuação do menu
        while (opcao != 0)
        {
            Console.WriteLine("=== SISTEMA DE CLIENTES ===");
            Console.WriteLine("1 - Adicionar Cliente");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - Buscar Cliente");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
// tenta coonverter o que o usuario digitou pára numero
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Digite um número válido!\n");
                continue; // retorna p menu
            }
            Console.WriteLine();
// executa a funcao baseada na escolha 
            switch (opcao)
            {
                case 1:
                    AdicionarCliente();
                    break;

                case 2:
                    ListarClientes();
                    break;

                case 3:
                    BuscarCliente();
                    break;
            }

        } 
    }
// funcao para add cliente
    static void AdicionarCliente()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();
// cria um novo e ad na lista
        clientes.Add(new Cliente(nome, email));

        Console.WriteLine("Cliente cadastrado!\n");
    }
//lista os clientes
    static void ListarClientes()
    {
        if (clientes.Count == 0) // verifica se está vazia
        {
            Console.WriteLine("Nenhum Cliente cadastrado!\n");
            return;
        }

        Console.WriteLine("\nLista de Clientes:");

        foreach (var cliente in clientes)
        {
            cliente.Exibir();
        }

        Console.WriteLine();
    }
// funcao p buscar clientes
    static void BuscarCliente() 
    {
        Console.Write("Digite o nome para a busca: ");
        string busca = Console.ReadLine();
        bool encontrou = false;

        foreach (var cliente in clientes)
        {
            if (cliente.Nome.ToLower().Contains(busca.ToLower()))
            { 
                cliente.Exibir();
                encontrou = true; // verifica se o nome contem texto digitado
            }
        }

        if (!encontrou)
        {
            Console.WriteLine("Cliente não encontrado\n");
        }
        else 
        {
            Console.WriteLine();
        }
    }
}
