namespace week9_hw;

public class Classroom
{
    
    private List<Student2> students;
    
    public Classroom(List<Student2> students)
    {
        this.students = students;
    }
    
    public void displayClass()
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Is Good Student: {student is GoodStudent}");
            student.Study();
            student.Read();
            student.Write();
            student.Relax();
            Console.WriteLine();
        }
    }

    
}