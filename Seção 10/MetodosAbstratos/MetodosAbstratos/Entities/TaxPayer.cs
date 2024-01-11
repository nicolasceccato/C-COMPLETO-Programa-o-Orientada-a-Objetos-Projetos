namespace MetodosAbstratos.Entities;

public abstract class TaxPayer
{
    public string Nome { get; set; }
    public double AnnualIncome { get; set; }

    public TaxPayer(string nome, double annualIncome)
    {
        Nome = nome;
        AnnualIncome = annualIncome;
    }

    public abstract double TotalToPay();
}