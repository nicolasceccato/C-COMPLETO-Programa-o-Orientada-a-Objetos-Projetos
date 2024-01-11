namespace MetodosAbstratos.Entities;

public abstract class TaxPayer
{
    public string Name { get; set; }
    public double AnnualIncome { get; set; }

    public TaxPayer(string name, double annualIncome)
    {
        Name = name;
        AnnualIncome = annualIncome;
    }

    public abstract double TotalToPay();
}