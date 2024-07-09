public class FuncionarioMeioPeriodo : Funcionario, IBonus
{
     private double SalarioPorHora;
     
     private int HorasTrabalhadas;

     public FuncionarioMeioPeriodo(string nome, int matricula, double SalarioPorHora, int HorasTrabalhadas) : base(nome, matricula)
     {
        this.SalarioPorHora = SalarioPorHora;
        this.HorasTrabalhadas = HorasTrabalhadas;
     }

    public override double CalcularSalario()
    {
        return SalarioPorHora * HorasTrabalhadas;
    
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Matrícula: {MatriculaFuncionario}, Salário: {CalcularSalario()}, Projetos: {string.Join(", ", Projetos)} ");

    }

    public double CalcularBonus()
    {
        return CalcularSalario() * 0.05;
    }

}