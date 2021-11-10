// Output: Hello, Bob! You have 3 in your inbox. The temperature is 34.4 celsius.
// Store the following values from the output in variables:
//  Bob
//  3
//  34.4
// These variables should be given names that reflect their purpose.
// Make sure you select the correct data type for each of the variables based on the type of data it will hold.
// Finally, you'll combine the variables with literal strings 
// passed into a series of Console.Write() commands to form the complete message.


// One possible solution:
string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");