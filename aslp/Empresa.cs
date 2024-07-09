public class Empresa
{
   private List<Funcionario> Funcionarios;

    public Empresa()
    {
        Funcionarios = new List<Funcionario>();
    }

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    public void RemoverFuncionario(int matricula)
    {
        Funcionarios.RemoveAll(f => f.MatriculaFuncionario == matricula);
    }

    public void ExibirFuncionarios()
    {
        foreach (var funcionario in Funcionarios)
        {
            funcionario.ExibirInformacoes();
        }
    }
    public Funcionario BuscarFuncionarios(int matricula)
    {
        return Funcionarios.Find(f => f.MatriculaFuncionario == matricula);

    }



}
