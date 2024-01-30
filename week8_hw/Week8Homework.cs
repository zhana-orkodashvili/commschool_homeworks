namespace Week8Homework;

internal abstract class Week8Homework
{
    
    public static void Main(string[] args)
    {
        // 1.
        
        Console.WriteLine("---- Problem 1 ----");
        
        var result1 = CountNumbersInInterval(49, 71, 2);
        Console.WriteLine(result1); 

        var result2 = CountNumbersInInterval(2, 27, 4);
        Console.WriteLine(result2); 
        
        Console.WriteLine();
        
        // 2.
        
        Console.WriteLine("---- Problem 2 ----");

        Console.WriteLine(CountPairs("ABCABC"));
        Console.WriteLine(CountPairs("AA"));
        Console.WriteLine(CountPairs("AAABB"));
        
        Console.WriteLine();
        
        // 3. 
        
        Console.WriteLine("---- Problem 3 ----");
        
        Console.WriteLine(LongestCommonEndingSubString("multiplication", "subtraction")); 
        Console.WriteLine(LongestCommonEndingSubString("Some Random Text", "It is Some Random Text"));
        
        Console.WriteLine();
        
        // 4.
        
        Console.WriteLine("---- Problem 4 ----");
        
        Console.WriteLine("Using int list:");
        List<int> list1 = [2, 4, 6, 8] ;
        ProcessGenericList(list1); 
        Console.WriteLine();
        
        Console.WriteLine("Using string list:");
        List<string> list2= ["test", "random", "programming", "word"];
        ProcessGenericList(list2);
        Console.WriteLine();

        Console.WriteLine("Using bool list:");
        List<bool> list3= [true, false, true, false, true, false, false];
        ProcessGenericList(list3);
        
        Console.WriteLine();
        
        // 5.
        
        Console.WriteLine("---- Problem 5 ----");

        int num = 12345;
        PrintDigits(num);
        
        Console.WriteLine();
        
        // 6.
        
        Console.WriteLine("---- Problem 6 ----");
        
        List<int> nums1 = new List<int> { 1, 2, 3, 1 };
        List<int> nums2 = new List<int> { 1, 2, 3, 4 };

        Console.WriteLine($"List:  {string.Join(' ', nums1)}  contains duplicates? {ContainsDuplicate(nums1)}");
        Console.WriteLine($"List:  {string.Join(' ', nums2)}  contains duplicates? {ContainsDuplicate(nums2)}");
        
    }
    
    
    static int CountNumbersInInterval(int a, int b, int n)
    {
        var resultList = Enumerable.Range((int)Math.Pow(a, 1.0 / n), (int)Math.Pow(b, 1.0 / n) - (int)Math.Pow(a, 1.0 / n) + 1)
            .Where(i => a <= (int)Math.Pow(i, n) && (int)Math.Pow(i, n) <= b).ToList();

        return resultList.Count;
    }
    
    static int CountPairs(string socks)
    {
        var groups = socks.GroupBy(sock => sock);
        return Math.Max(groups.Sum(group => group.Count() / 2),0);
    }
    
    static string LongestCommonEndingSubString(string str1, string str2)
    {
        return Enumerable.Range(0, str1.Length - 1).Select(substr => str1[substr..]).FirstOrDefault(str2.EndsWith) ?? "";
    }

    static void ProcessGenericList<T>(List<T> inputList)
    {
        if (typeof(T) == typeof(string))
        {
            foreach (var item in inputList)
                if (item != null) Console.WriteLine(item.ToString()?.ToUpper());
        }
        else if (typeof(T) == typeof(int))
        {
            Console.WriteLine(inputList.Cast<int>().Sum());
        }
        else if (typeof(T) == typeof(bool))
        {
            Console.WriteLine($"First Element is {inputList.First()}");
            Console.WriteLine($"Last Element is {inputList.Last()}");
            Console.WriteLine($"Middle Element is {inputList[inputList.Count / 2]}");
        }
        else
        {
            Console.WriteLine("Unknown type");
        }
    }

    static void PrintDigits(int num)
    {
        if (num == 0)
            return;
        
        PrintDigits(num / 10);
        
        int currentDigit = num % 10;
        Console.WriteLine(currentDigit);
    }
    
    static bool ContainsDuplicate(List<int> nums)
    {
        return nums.Distinct().Count() != nums.Count;
    }
}