namespace week10_hw;

public interface FinanceOperations
{
    public double CalculateLoanPercent(int month, double AmountPerMonth);
    public bool CheckUserHistory();
}