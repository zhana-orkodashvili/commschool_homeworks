// See https://aka.ms/new-console-template for more information

// 1.

Console.WriteLine("---- Problem 1 ----");
Console.WriteLine("Enter radius: ");
var radius=Convert.ToDecimal(Console.ReadLine());

var bigSquareArea=Math.Pow((double)(2*radius),2);

var smallSquareArea = Math.Pow(Math.Sqrt(2)*(double)radius,2);

Console.WriteLine($"Difference: {double.Round(bigSquareArea-smallSquareArea)}");

// 2.

Console.WriteLine("---- Problem 2 ----");
Console.WriteLine("Input result: ");

var userInput=Console.ReadLine();

if (userInput != null && userInput.All(x => x == userInput[0])) Console.WriteLine("Yes");
else Console.WriteLine("No");


// 3.

Console.WriteLine("---- Problem 3 ----");

var totalScore=0;

Console.WriteLine("Enter number of wins: ");
var wins=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of loses: ");
var loses=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of draws: ");
var draws=Convert.ToInt32(Console.ReadLine());

totalScore += 3*wins+draws;

Console.WriteLine($"Total score: {totalScore}");


// 4.

Console.WriteLine("---- Problem 4 ----");
Console.WriteLine("Enter hours worked daily in a week: ");
List<int>? hours = Console.ReadLine()?.Split(' ').Select(str => int.TryParse(str, out var hour) ? hour : 0).ToList();

var salary = 0;

if (hours is { Count: >= 0 and <= 7 })
{
    for (var i = 0; i < hours.Count; i++) {
        var overtimeHours = hours[i] - 8 > 0 ? hours[i] - 8:0;
        salary += (i < 5) ? (10 * hours[i] + 5 * overtimeHours) : (20 * hours[i]);
    }
    
    Console.WriteLine($"Weekly Salary: {salary}");
}
else Console.WriteLine("Invalid input.");


// 5.

Console.WriteLine("---- Problem 5 ----");
Console.WriteLine("Enter daily results: ");
List<decimal>? results = Console.ReadLine()?.Split(' ').Select(str => decimal.TryParse(str, out var result) ? result : 0).ToList();

var counter = 1;
var maxlen = 0;

if (results != null)
{
    for (var i = 1; i < results.Count; i++) {
        
        if (results[i] > results[i - 1]) counter++;
        
        else 
        {
            maxlen = Math.Max(counter, maxlen);
            counter = 1;
        }
        
    }
    maxlen = Math.Max(counter, maxlen)==1 ? 0 : Math.Max(counter, maxlen);
    
}
else Console.WriteLine("Empty Input");

Console.WriteLine($"Max number of progress: {maxlen}");


// 6. 

Console.WriteLine("---- Problem 6 ----");

Console.WriteLine("Enter strings:");
var wordList=Console.ReadLine()?.Split(' ').ToList();

Console.WriteLine("Enter length:");

if (int.TryParse(Console.ReadLine(), out var length) && wordList != null) 
{
    var filtered = wordList.Where(element => element.Length == length).ToList();
    Console.WriteLine(filtered.Count != 0 ? string.Join(' ', filtered):"No element found");
}
else
    Console.WriteLine("Invalid input");
