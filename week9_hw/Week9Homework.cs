namespace week9_hw;

internal abstract class Week9Homework
{
    
    public static void Main(string[] args)
    {
        
        // 1. 
        
        Console.WriteLine("---- Problem 1 ----");
        Console.WriteLine("Enter your company information. Is it local company?");
        if (bool.TryParse(Console.ReadLine(), out bool isLocal))
        {
            var company1 = new Company(isLocal);
            Console.WriteLine("Enter the total amount of salary paid:");
            if (decimal.TryParse(Console.ReadLine(), out decimal totalSalary))
                Console.WriteLine($"Total tax paid is: {company1.calculate_tax(totalSalary)}");
            
        }
        Console.WriteLine();
        
        
        // 2. 
        
        Console.WriteLine("---- Problem 2 ----");
        Employee employee = new Employee(); 
        decimal weeklySalary = employee.calculateWeeklySalary();

        Console.WriteLine($"Weekly salary for {employee.FirstName} {employee.LastName}: {weeklySalary}");
        
        Console.WriteLine();

        
        // 3.
        
        Console.WriteLine("---- Problem 3 ----");
        Student student = new Student();
        student.calculateRemainingYears();
        var studentSubject=student.getRandomSubject();
        Console.WriteLine($"{student.Name} is taking a class in: {studentSubject}");
        
        Teacher teacher = new Teacher();
        teacher.checkSubject(studentSubject);

        Console.WriteLine();
        
        // 4. 
        
        Console.WriteLine("---- Problem 4 ----");

        Console.Write("Enter the number of students in the class: ");
        if (int.TryParse(Console.ReadLine(), out int numberOfStudents) && numberOfStudents > 0)
        {
            List<Student2> students = new List<Student2>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Enter student {i + 1} name: ");
                string studentName = Console.ReadLine();

                Console.Write($"Are they a good student? (true/false): ");
                bool isGoodStudent = bool.TryParse(Console.ReadLine(), out bool isGood) && isGood;

                if (isGoodStudent)
                {
                    students.Add(new GoodStudent(studentName));
                }
                else
                {
                    students.Add(new LazyStudent(studentName));
                }
            }

            Classroom class1 = new Classroom(students);
            class1.displayClass();
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }

    }
    
    
}