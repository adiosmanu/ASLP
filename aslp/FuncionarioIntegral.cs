public class FuncionarioIntegral : Funcionario, IBonus
{
    private double SalarioMensal;

    public FuncionarioIntegral(string nome, int MatriculaFuncionario, double SalarioMensal) : base(nome, MatriculaFuncionario)
    {
        this.SalarioMensal = SalarioMensal;
    }

    public override double CalcularSalario()
    {
        return SalarioMensal;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"nome do funcionário: {Nome}");
        Console.WriteLine($"A matricula é: {MatriculaFuncionario}");
        Console.WriteLine($"O salário mensal é de : {SalarioMensal}");   
    }

    public double CalcularBonus()
    {
        return SalarioMensal * 0.1;
    }
}