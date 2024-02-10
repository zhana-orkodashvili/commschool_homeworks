using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Xml;

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
            string xmlContent = xmlDoc.OuterXml;

            Console.WriteLine(xmlContent);
        }
        
        
        // 4.
        
        Console.WriteLine("---- Problem 4 ----");
        
        string currentDate = DateTime.Now.ToString("MMMM dd, yyyy");
        string data = " [ {\"currentDate\": \"" + currentDate + "\", \"birthday\": \"June 20, 2012\"} ]";
        
        using JsonDocument doc = JsonDocument.Parse(data);
        JsonElement root = doc.RootElement;

        Console.WriteLine(root);
        
        var element1 = root[0];
        var currentDateFromFile = DateTime.Parse(element1.GetProperty("currentDate").ToString());
        var birthdayFromFile = DateTime.Parse(element1.GetProperty("birthday").ToString());
        
        var birthday = new DateTime(currentDateFromFile.Year, birthdayFromFile.Month, birthdayFromFile.Day);

        if (birthday < currentDateFromFile)
            birthday = birthday.AddYears(1);
        
        TimeSpan daysUntilBirthday =  birthday.Subtract(currentDateFromFile);
        
        Console.WriteLine($"Days until birthday: {daysUntilBirthday.Days}");
        

    }

}

