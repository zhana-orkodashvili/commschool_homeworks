using System.Diagnostics.CodeAnalysis;

namespace week9_hw;

public enum Position
{
    Manager,
    Developer,
    Tester,
    Other
}

public class Employee
{
    private string firstName;
    private string lastName;
    private Position position; 
    private int age;
    private List<int> hoursWorked;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public Position Position
    {
        get { return position; }
        set { position = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public List<int> HoursWorked
    {
        get { return hoursWorked; }
        set { hoursWorked = value; }
    }

    public Employee() 
    {
        Console.Write("Enter employee first name: ");
        firstName = Console.ReadLine();

        Console.Write("Enter employee last name: ");
        lastName = Console.ReadLine();

        Console.Write("Enter employee age: ");
        if (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid input.");
            age = 0;
        }

        Console.Write("Enter employee position (Manager, Developer, Tester, Other): ");
        if (Enum.TryParse(Console.ReadLine(), out Position userPosition))
        {
            position = userPosition;
        }
        else
        {
            Console.WriteLine("Invalid position.");
            position = Position.Other;
        }

        hoursWorked = new List<int>();
        Console.WriteLine("Enter hours worked daily in a week: ");
        hoursWorked = Console.ReadLine()?.Split(' ').Select(str => int.TryParse(str, out var hour) ? hour : 0).ToList();
    }

    public Employee(string firstName, string lastName, int age, Position position, List<int> hoursWorked)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Position = position;
        HoursWorked = hoursWorked;
    }
    
    
    public decimal calculateWeeklySalary()
    {
        decimal hourlyRate;
        switch(position){
            case Position.Manager:
                hourlyRate = 40m;
                break;
            case Position.Developer:
                hourlyRate = 30m;
                break;
            case Position.Tester:
                hourlyRate = 20m;
                break;
            case Position.Other:
                hourlyRate = 10m;
                break;
            default:
                hourlyRate = 0;
                break;
        }
        var totalSalary = 0m;
        for (int i = 0; i < 7; i++)
        { 
            totalSalary += (i < 5) ? (hourlyRate * hoursWorked[i] + 5 * Math.Max(0,hoursWorked[i] - 8)) : (2*hourlyRate * hoursWorked[i]);
        }

        var bonus = hoursWorked.Sum() > 50 ? totalSalary * 0.20m : 0;
        totalSalary += bonus;
        
        return totalSalary;


    }
}