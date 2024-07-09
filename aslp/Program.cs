
class Program
{
    static void Main()
    {
        Empresa empresa = new Empresa();

        while (true)
        {
            Console.WriteLine("******************Menu**********************");
            Console.WriteLine("1 - Adicionar funcionário de tempo integral:");
            Console.WriteLine("2 - Adicionar funcionário de meio período");
            Console.WriteLine("3 - Remover funcionário");
            Console.WriteLine("4 - Exibir informações de todos os funcionários");
            Console.WriteLine("5 - Adicionar projeto(s) a um funcionário:");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("Escolha uma opção:");

            if (int.TryParse(Console.ReadLine(), out int opcao))

            switch (opcao)
            {
                case 1:
                    AdicionarFuncionarioTempoIntegral(empresa);
                    break;
                case 2:
                    AdicionarFuncionarioMeioPeriodo(empresa);
                    break;
                case 3:
                    RemoverFuncionario(empresa);
                    break;
                case 4:
                    empresa.ExibirFuncionarios();
                    break;
                case 5:
                    AdicionarProjetosFuncionarios(empresa);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Opação Inválida!");
                    break;
                
                    
            }
        }
    }

    static void AdicionarFuncionarioTempoIntegral(Empresa empresa)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Matrícula: ");
        int matricula = int.Parse(Console.ReadLine());
        Console.Write("Salário Mensal: ");
        double salarioMensal = double. Parse(Console.ReadLine());

        FuncionarioIntegral funcionario = new FuncionarioIntegral(nome, matricula, salarioMensal);
        empresa.AdicionarFuncionario(funcionario);
    }

    static void AdicionarFuncionarioMeioPeriodo(Empresa empresa)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Matrícula: ");
        int matricula = int.Parse(Console.ReadLine());
        Console.Write("Salário por hora: ");
        double salarioPorHora = double.Parse(Console.ReadLine());
        Console.Write("Horas trabalhadas: ");
        int horasTrabalhadas = int.Parse(Console.ReadLine());


        FuncionarioMeioPeriodo funcionario = new FuncionarioMeioPeriodo(nome, matricula,salarioPorHora, horasTrabalhadas );
        empresa.AdicionarFuncionario(funcionario);
    }
    static void RemoverFuncionario(Empresa empresa)
    {
        Console.Write("Matrícula do Funcionário a ser removida:  ");

        int matricula = int.Parse(Console.ReadLine());
        empresa.RemoverFuncionario(matricula);
    }

    static void AdicionarProjetosFuncionarios(Empresa empresa)
    {
        Console.Write("Matrícula do Funcionário:  ");
        int matricula = int.Parse(Console.ReadLine());
        Funcionario funcionario = empresa.BuscarFuncionarios(matricula);

        if(funcionario != null)
        {
            Console.Write("Digite o número de projetos a serem adicionados: ");
            int numeroProjetos = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroProjetos; i++)
            {
                Console.Write($"Nome do Projeto {i + 1}: ");
                string projeto = Console.ReadLine();
                funcionario.AdicionarProjeto(projeto);
            }
        }
            else
            {
                Console.WriteLine("Funcionário não encontrado!");
            }

    }
    
 
    }

