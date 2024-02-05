namespace week10_hw;

internal abstract class Week9Homework
{
    
    public static void Main(string[] args)
    {
        
        // 1. 
        
        Console.WriteLine("---- Problem 1 ----");
        TextualFileWorker file1 = new TextualFileWorker(128, "txt");
        file1.Read();
        file1.Write();
        file1.Edit();
        file1.Delete();
        
        Console.WriteLine();
        
        // 2.
        
        Console.WriteLine("---- Problem 2 ----"); 
        
        Bank bank = new Bank();
        
        bool isUserChecked = bank.CheckUserHistory();
        
        int loanMonths = 12;
        double amountPerMonth = 1000;
        
        if (isUserChecked)
        {
            double total = bank.CalculateLoanPercent(loanMonths, amountPerMonth);
            Console.WriteLine($"Bank: \n Total amount to be paid: {total}");
        }
        else
        {
            Console.WriteLine("Bank: \n User not checked out");
        }
        
        MicroFinance financeAgency = new MicroFinance();
        double totalAmount = financeAgency.CalculateLoanPercent(loanMonths, amountPerMonth);
        Console.WriteLine($"MicroFinance: \n Total amount to be paid: {totalAmount}");


    }
}