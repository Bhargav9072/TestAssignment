using System;
using System.Globalization;
using System.Linq;

try
{
    Console.Write("Please enter a string: ");
    string inputValue = Console.ReadLine().ToLower();
    bool isInvalidInput = false;
    while (!isInvalidInput)
    {
        if (string.IsNullOrEmpty(inputValue))
        {
            Console.WriteLine("Invalid Input. Try again...");
            Console.Write("Please enter a string: ");
            inputValue = Console.ReadLine().ToLower();
            isInvalidInput = false;
        }
        else
        {
            isInvalidInput = true;
        }
    }
    inputValue = inputValue.ToUpper(CultureInfo.InvariantCulture);
    var result = inputValue.GroupBy(p => p).Select(p => new { Count = p.Count(), Char = p.Key }).GroupBy(p => p.Count, p => p.Char).OrderByDescending(p => p.Key).First();

    foreach (var r in result)
    {
        Console.WriteLine("Frequent character:{0}, count:{1}", r, result.Key);
    }

    Console.Write("Press [enter] to continue...");
    Console.ReadLine();
}
catch (Exception)
{
    throw;
}