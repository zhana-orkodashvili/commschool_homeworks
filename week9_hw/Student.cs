using System.Runtime.InteropServices.JavaScript;

namespace week9_hw;

public class Student
{
    private string name;
    private int age;
    private int enrollmentYear;
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    
    public int EnrollmentYear
    {
        get { return enrollmentYear; }
        set { enrollmentYear = value; }
    }
    
    public Student(string name,  int age, int enrollmentYear)
    {
        Name = name;
        Age = age;
        EnrollmentYear = enrollmentYear;
    }

    public Student()
    {
        Console.Write("Enter student name: ");
        name = Console.ReadLine();
        
        Console.Write("Enter student age: ");
        age = int.TryParse(Console.ReadLine(), out age)? age : 0;
        
        Console.Write("Enter student enrollment year: ");
        enrollmentYear= int.TryParse(Console.ReadLine(), out enrollmentYear)? enrollmentYear : 0;
        
    }

    public void calculateRemainingYears()
    {
        if (DateTime.Today.Year > enrollmentYear + 4)
        {
            Console.WriteLine($"{name} already graduated");
        }
        else if(DateTime.Today.Year ==enrollmentYear + 4)
        {
            Console.WriteLine($"{name} is graduating this year!");
        }
        else
        {
            int remainingYears = enrollmentYear + 4 - DateTime.Today.Year;
            Console.WriteLine($"Remaining years before graduation for {name}: {remainingYears}");
        }
    }
    
    public string getRandomSubject()
    {
        string[] subjects = { 
            "Mathematics",
            "Chemistry",
            "English",
            "Introduction to Computer Science", 
            "Data Structures and Algorithms", 
            "Software Engineering", 
            "Artificial Intelligence", 
            "Web Development", 
            "Cybersecurity", 
            "Machine Learning" 
        };
        
        Random random = new Random();
        int index = random.Next(0,subjects.Length);
        return subjects[index];
    }
    

}