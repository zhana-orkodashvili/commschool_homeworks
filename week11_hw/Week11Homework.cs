using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Formatting = Newtonsoft.Json.Formatting;

namespace week11_hw;


internal abstract class Week11Homework
{
    public static void Main(string[] args)
    {

        // 1.

        Console.WriteLine("---- Problem 1 ----");
        
        Console.WriteLine("Enter the number of lines:");
        if (!int.TryParse(Console.ReadLine(), out var lines) || lines <= 0)
            Console.WriteLine("Invalid Input");

        Console.WriteLine("Enter text:");

        string?[] lineList = new string?[lines];

        for (var i = 0; i < lines; i++)
            lineList[i] = Console.ReadLine();

        var directory = Environment.CurrentDirectory;

        for (var i = 0; i < 3; i++)
            directory = Directory.GetParent(directory).ToString();

        var filePath = Path.Combine(directory, "output.txt");

        if (!File.Exists(filePath))
            File.Create(filePath).Close();
        
        File.WriteAllLines(filePath, lineList!);

        Console.WriteLine($"Last line from file: {File.ReadAllLines(filePath)[lines - 1]}");


        // 2.

        Console.WriteLine("---- Problem 2 ----");
        
        Console.WriteLine("Enter the number for multiplications table:");
        if (!int.TryParse(Console.ReadLine(), out var N) || N <= 0)
            Console.WriteLine("Invalid Input");

        var filePath2 = Path.Combine(directory, "output2.txt");

        if (!File.Exists(filePath2))
            File.Create(filePath2).Close();

        string str = "";
        for (var i = 1; i <= 9; i++)
        {
            for (var j = 1; j <= N; j++)
                str += $"{j} * {i} = {i * j} | \t";

            str += "\n";
        }

        File.WriteAllText(filePath2, str);


        // 3.
        
        
        Console.WriteLine("---- Problem 3 ----");
        
        Console.WriteLine("Enter the string:");
        string inputString = Console.ReadLine();

        Console.WriteLine("Enter the number of parts to split into:");
        int parts = int.Parse(Console.ReadLine());
        int length = inputString.Length;

        if (length % parts != 0)
            Console.WriteLine($"Not divisible by {parts}");
        else
        {
            int partLength = (int)((double)length / parts);
            
            string[] splitStrings = Enumerable.Range(0, parts)
                .Select(i => inputString.Substring(i * partLength, partLength))
                .ToArray();

            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root1 = xmlDoc.CreateElement("Root");

            for (int i = 0; i < splitStrings.Length; i++)
            {
                XmlElement node = xmlDoc.CreateElement($"{splitStrings[i]}");
                node.InnerText = $"string {i + 1}";
                root1.AppendChild(node);
            }

            xmlDoc.AppendChild(root1);
            
            var filePath3 = Path.Combine(directory, "xmlResult.xml");

            try
            {
                xmlDoc.Save(filePath3);
                Console.WriteLine("XML document saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
        }
        
        
        // 4.
        
        Console.WriteLine("---- Problem 4 ----");

        var birthdaysList = new List<Birthday>();
        birthdaysList.Add(new Birthday(DateTime.Now, new DateTime(2012, 6, 20)));
        
        
        var _dataConverted = JsonConvert.SerializeObject(birthdaysList.ToArray(), (Formatting)Formatting.Indented);
        
        var filePath4 = Path.Combine(directory, "jsonResult.json");
        
        if (!File.Exists(filePath4))
            File.Create(filePath4).Close();
        try
        {
            File.WriteAllText(filePath4, _dataConverted);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
        try
        {
            var jsonData = File.ReadAllText(filePath4);
            var birthdaysListFromFile = JsonConvert.DeserializeObject<Birthday[]>(jsonData);

            if (birthdaysListFromFile != null && birthdaysListFromFile.Length > 0)
            {
                DateTime currentDate = birthdaysListFromFile[0].CurrentDate;
                DateTime birthday = birthdaysListFromFile[0].BirthDate;
                
                birthday = new DateTime(currentDate.Year, birthday.Month, birthday.Day);
                 
                if (birthday < currentDate)
                    birthday = birthday.AddYears(1);
                
                TimeSpan daysUntilBirthday = birthday - currentDate;

                Console.WriteLine($"Days until birthday: {daysUntilBirthday.Days}");

            }
            else
            {
                Console.WriteLine("No records found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
        

    }

}

