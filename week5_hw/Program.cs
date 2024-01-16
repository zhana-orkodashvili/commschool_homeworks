
namespace week5_hw;

internal abstract class Program
{
    public static void Main(string[] args)
    {
// 1.
        Console.WriteLine("----- Task 1 -----");
        Console.Write("Enter a number: ");
        var num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num % 5 == 0 ? "Yes" : "NO");


// 2.

        Console.WriteLine("----- Task 2 -----");
        Console.Write("Enter first number: ");
        var num1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter second number: ");
        var num2 = Convert.ToDecimal(Console.ReadLine());


        var sum = num1 + num2;
        Console.WriteLine($"X+Y = {sum}");

        var diff = Math.Max(num1, num2) - Math.Min(num1, num2);
        Console.WriteLine($"X-Y = {diff}");

        var product = num1 * num2;
        Console.WriteLine($"X*Y = {product}");

        if (Math.Min(num1, num2) != 0){
            var division = Math.Max(num1, num2) / Math.Min(num1, num2);
            Console.WriteLine($"X/Y = {division}");
        }
        else {
            Console.WriteLine("Not Allowed To Divide By Zero");
        }

// 3.

        Console.WriteLine("----- Task 3 -----");
        Console.Write("Enter first number (x): ");
        var x = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter second number (y): ");
        var y = Convert.ToDecimal(Console.ReadLine());

        x = y + x;
        y = x - y;
        x -= y;

        Console.WriteLine($"After Swapping: x = {x}, y = {y}");

// 4.

        Console.WriteLine("----- Task 4 -----");
        Console.Write("Enter a number: ");
        var inputNum = Convert.ToDecimal(Console.ReadLine());

        for (var i = 1; i <= 9; i++) {
            var result = inputNum * i;
            Console.WriteLine($"{inputNum} x {i} = {result}");
        }


// 5.

        Console.WriteLine("----- Task 5 -----");
        Console.Write("Enter a number: ");
        var n = Convert.ToDecimal(Console.ReadLine());

        for (var i = 2; i < n; i += 2) {
            var square = i*i;
            Console.WriteLine(square);
        }
    }
}