// See https://aka.ms/new-console-template for more information

// 1.
#region Problem1

Console.WriteLine("---- Problem 1 ----");
Console.WriteLine("Enter the size of the array:");
if (!int.TryParse(Console.ReadLine(), out var size) || size <= 0)
    Console.WriteLine("Invalid input");


var arr = new int[size];

Console.WriteLine("Enter the elements:");
var arrStr = Console.ReadLine()?.Split(' ');

for (var i = 0; i < size; i++) {
    if (!int.TryParse(arrStr?[i], out arr[i]))
        Console.WriteLine("Invalid input");
}


var arrEven = new int[size];
var arrOdd = new int[size];
var evenCount = 0;
var oddCount = 0;

foreach (var num in arr) {
    if (num % 2 == 0) {
        arrEven[evenCount] = num;
        evenCount++;
    }
    else {
        arrOdd[oddCount] = num;
        oddCount++;
    }
}


Array.Resize(ref arrEven, evenCount);
Array.Resize(ref arrOdd, oddCount);

Console.Write("Array#1: ");
foreach (var item in arrEven)
    Console.Write(item+ " ");

Console.WriteLine();

Console.Write("Array#2: ");
foreach (var item in arrOdd)
    Console.Write(item+ " ");

Console.WriteLine();
#endregion



// 3.
#region Problem3

Console.WriteLine("---- Problem 3 ----");
Console.WriteLine("Enter the size of the array:");
if (!int.TryParse(Console.ReadLine(), out var size2) || size2 <= 0) {
    Console.WriteLine("Invalid input");
    return;
}

var arr2 = new int[size2];

Console.WriteLine("Enter the elements:");
var arrStr2 = Console.ReadLine()?.Split(' ');

for (var i = 0; i < size2; i++) {
    if (!int.TryParse(arrStr2?[i], out arr2[i])) {
        Console.WriteLine("Invalid input");
        return;
    }
}

var result = from element in arr2 group element by element into grouped select new {
        Element = grouped.Key,
        Count = grouped.Count(),
        Sum = grouped.Sum()
    };

foreach (var item in result)
    Console.WriteLine($"{item.Element} appears {item.Count} times. sum: {item.Sum}");


#endregion


// 4.
#region Problem4

Console.WriteLine("---- Problem 4 ----");
Console.WriteLine("Enter the results:");

List<int>? scores = Console.ReadLine()?.Split(' ').Select(str => int.TryParse(str, out var score) ? score : 0).ToList();

Console.WriteLine("Enter the value of n:");
if (scores != null && int.TryParse(Console.ReadLine(), out int n) && n >= 0 && n <= scores.Count) {
    var topNParticipants = scores.OrderByDescending(x => x).Take(n);
    Console.WriteLine($"Top {n} result: {string.Join(" ", topNParticipants)}");
}
else
    Console.WriteLine("Invalid input.");

#endregion


// 2.
#region Problem2

Console.WriteLine("---- Problem 2 ----");

Dictionary<string, List<string>> contacts = new Dictionary<string, List<string>>();

while (true) { 
    Console.WriteLine("--- Contacts Application ---");
    Console.WriteLine("1. Add Contact"); 
    Console.WriteLine("2. Delete Contact");
    Console.WriteLine("3. Update Contact");
    Console.WriteLine("4. Show Contacts");
    Console.WriteLine("5. Exit");

    Console.Write("Enter your choice: ");
    var choice = Console.ReadLine();

    switch (choice) {
        case "1":
            Console.Write("Enter the name of the contact: ");
            var name = Console.ReadLine();

            if (name != null && !contacts!.ContainsKey(name)) {
                List<string> phoneNumbers = [];
                Console.Write("Enter the phone number: ");
                var phoneNumber = Console.ReadLine();

                while (!string.IsNullOrEmpty(phoneNumber)) {
                    phoneNumbers.Add(phoneNumber);
                    Console.Write("Enter another phone number or press enter to finish: ");
                    phoneNumber = Console.ReadLine();
                }

                contacts[name] = phoneNumbers;
                Console.WriteLine($"Contact added. Name: {name}, Phone Numbers: {string.Join(", ", phoneNumbers)}");
            }
            else {
                Console.WriteLine($"Contact with name '{name}' already exists");
            }
            break;
        
        case "2":
            Console.Write("Enter the name of the contact: ");
            var nameToDelete = Console.ReadLine();

            if (nameToDelete != null && contacts != null && contacts.ContainsKey(nameToDelete)) {
                contacts.Remove(nameToDelete);
                Console.WriteLine($"Contact '{nameToDelete}' deleted.");
            }
            else {
                Console.WriteLine($"Contact '{nameToDelete}' not found.");
            }
            break;
        
        case "3":
            Console.Write("Enter the name of the contact: ");
            var nameToUpdate = Console.ReadLine();

            if (nameToUpdate != null && contacts != null && contacts.ContainsKey(nameToUpdate)) {
                List<string> phoneNumbers = [];

                Console.Write("Enter the new phone number of the contact: ");
                string newPhoneNumber = Console.ReadLine();

                while (!string.IsNullOrEmpty(newPhoneNumber)) {
                    phoneNumbers.Add(newPhoneNumber);
                    Console.Write("Enter another phone number or press enter to finish: ");
                    newPhoneNumber = Console.ReadLine();
                }
                
                contacts[nameToUpdate] = phoneNumbers;

                Console.WriteLine($"Contact '{nameToUpdate}' updated. New Phone Numbers: {string.Join(", ", phoneNumbers)}");
            }
            else {
                Console.WriteLine($"Contact '{nameToUpdate}' not found.");
            }
            break;
        
        case "4":
            if (contacts is { Count: 0 })
                Console.WriteLine("No contacts available.");
            else {
                Console.WriteLine("Contacts:");
                foreach (var contact in contacts!) {
                    Console.WriteLine($"Name: {contact.Key}, Phone Numbers: {string.Join(", ", contact.Value)}");
                }
            }
            break;
        
        case "5":
            Console.WriteLine("Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid choice");
            break;
            }

    Console.WriteLine();
}

#endregion