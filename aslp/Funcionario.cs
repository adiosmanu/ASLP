public abstract class Funcionario
{
    public string Nome;

    public int MatriculaFuncionario;

    public List<string> Projetos = new List<string>();

    public Funcionario(string Nome, int MatriculaFuncionario)
    {
        this.Nome = Nome;
        this.MatriculaFuncionario = MatriculaFuncionario;
    }

    public abstract double CalcularSalario();

    public abstract void ExibirInformacoes();

    public void AdicionarProjeto(string projeto)
    {
        Projetos.Add(projeto);
    }

    public void AdicionarProjeto(List<string> projetos)
    {
        projetos.AddRange(projetos);
    }

    

 

}