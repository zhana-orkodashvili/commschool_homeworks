namespace week10_hw;

public class MicroFinance:FinanceOperations
{
    private double InterestRate = 0.10;
    private double ServiceFeeRate = 4.0;

    public double CalculateLoanPercent(int month, double AmountPerMonth)
    {
        double maxAmount = month * AmountPerMonth;
        double totalAmountToPay = maxAmount + InterestRate * maxAmount + ServiceFeeRate * month;
        return totalAmountToPay;
    }

    public bool CheckUserHistory() 
    {
        return true;
    }
}