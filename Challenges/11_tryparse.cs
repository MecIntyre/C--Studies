/* Iterate through each value in a string of values.
   Start with the following line of code.
   
   string[] values = { "12.3", "45", "ABC", "11", "DEF" };
   
   Business Rules:
    Rule 1: If the value is alphanumeric, concatenate it to form a message
    Rule 2: If the value is numeric, add it to the total
    Rule 3: Make sure the result matches the following output:
   
   Output Message: ABCDEF
          Total: 68.3  */

//One possible solution:
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");