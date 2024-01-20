using System.Globalization;

namespace Interface.Entities;

public class Installments
{
    public DateTime DueDate { get; private set; }
    public double Amount { get; private set; }

    public Installments(DateTime dueDate, double amount)
    {
        DueDate = dueDate;
        Amount = amount;
    }

    public override string ToString()
    {
        return DueDate.ToString("dd/MM/yyyy") + " - " + Amount.ToString("F2", CultureInfo.InvariantCulture);
    }
}