namespace MetodosAbstratos.Entities;

public class Person : TaxPayer
{
    public double HealthSpending { get; set; }

    public Person(string nome, double annualIncome, double healthSpending) : base(nome, annualIncome)
    {
        HealthSpending = healthSpending;
    }

    public override double TotalToPay()
    {
        double value = 0;
        if (AnnualIncome < 20000)
        {
            value = 20000 * 0.15;
        }
        else
        {
            value = 20000 * 0.25;
        }

        if (HealthSpending > 0)
        {
            value -= (HealthSpending * 0.5);
        }

        return value;
    }
}