namespace Interface.Entities;

public class Contract
{
    public int Number { get; private set; }
    public DateTime Date { get; private set; }
    public double TotalValue { get; private set; }

    public List<Installments> InstallmentsList { get; private set; } = new List<Installments>();

    public Contract(int number, DateTime date, double totalValue)
    {
        Number = number;
        Date = date;
        TotalValue = totalValue;
    }

    public void AddInstallment(Installments installment)
    {
        InstallmentsList.Add(installment);
    }
}