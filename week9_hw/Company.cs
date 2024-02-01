namespace week9_hw;

public class Company
{
    private bool isLocal;

    public Company(bool isLocal)
    {
        this.isLocal = isLocal;
    }
        
    public decimal calculate_tax(decimal totalSalary)
    {
        return isLocal ? 0.18m* totalSalary : 0.05m* totalSalary;
    }
}