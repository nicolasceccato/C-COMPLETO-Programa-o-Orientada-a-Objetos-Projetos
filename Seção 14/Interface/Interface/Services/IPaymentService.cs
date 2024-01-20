namespace Interface.Services;

public interface IPaymentService
{
    public double PaymentFee(double amount);
    public double Interest(double amount, int months);
}