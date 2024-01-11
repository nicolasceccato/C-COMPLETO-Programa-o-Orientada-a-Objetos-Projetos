namespace MetodosAbstratos.Entities;

public class Company : TaxPayer
{
    public int NumberOfEmployees { get; set; }

    public Company(string nome, double annualIncome, int numberOfEmployees) : base(nome, annualIncome)
    {
        NumberOfEmployees = numberOfEmployees;
    }

    public override double TotalToPay()
    {
        double value = 0;
        if (NumberOfEmployees > 10)
        {
            value = 0.14 * AnnualIncome;
        }
        else
        {
            value = 0.16 * AnnualIncome;
        }

        return value;
    }
}