using Interface.Entities;

namespace Interface.Services;

public class ContractService
{
    private IPaymentService _paymentService;

    public ContractService(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    public void ProcessContract(Contract contract, int months)
    {
        double basicPayment = contract.TotalValue / months;
        for (int i = 1; i <= months; i++)
        {
            DateTime date = contract.Date.AddMonths(i);
            double updatedPayment = basicPayment + _paymentService.Interest(basicPayment, i);
            double totalPayment = updatedPayment + _paymentService.PaymentFee(updatedPayment);
            contract.AddInstallment(new Installments(date, totalPayment));
        }
    }
}