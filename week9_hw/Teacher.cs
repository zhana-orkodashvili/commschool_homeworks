namespace week9_hw;

public class Teacher
{
   private string name;
   private bool isCertified;

   public string Name
   {
      get { return name; }
      set { name = value; }
   }
   
   public bool IsCertified
   {
      get { return isCertified; }
      set { isCertified = value; }
   }

   public Teacher(string name,  bool isCertified)
   {
      Name = name;
      IsCertified = isCertified;
   }

   public Teacher()
   {
      Console.Write("Enter teacher name: ");
      Name = Console.ReadLine();

      Console.Write("Is the teacher certified? (true/false): ");
      if (bool.TryParse(Console.ReadLine(), out bool certified))
      {
         IsCertified = certified;
      }
      else
      {
         Console.WriteLine("Invalid input.");
         IsCertified = false;
      }
   }

   public void checkSubject(string studentSubject)
   {
      switch (studentSubject)
      {
         case "Mathematics":
            Random random = new Random();
            var num1 = random.Next(0, 100);
            var num2 = random.Next(0, 100);
            Console.WriteLine($"Maths: {num1} + {num2} = {num1+num2}");
            break;
         case "Chemistry":
            Console.WriteLine($"Water: H2O");
            break;
         case "English":
            Console.WriteLine("Lorem Ipsum");
            break;
         default:
            Console.WriteLine("Teacher isn't competent in this subject.");
            break;
      }
   }


}