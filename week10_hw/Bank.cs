namespace week10_hw;

public class Bank:FinanceOperations
{
    private double InterestRate = 0.05;
    
    public double CalculateLoanPercent(int month, double AmountPerMonth)
    {
        double maxAmount = month * AmountPerMonth;
        double totalAmountToPay = maxAmount + InterestRate * maxAmount ;
        return totalAmountToPay;
    }

    public bool CheckUserHistory()
    {
        Random random = new Random();
        return random.Next(2) == 1;
    }
}