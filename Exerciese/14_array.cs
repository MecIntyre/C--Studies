/* An array is a special variable that holds a sequence of related data elements.
   You should memorize the basic format of an array variable declaration.
   Access each element of an array to set or get its values using a zero-based index inside of square brackets.
   If you attempt to access an index outside of the boundary of the array, you'll get a run time exception.
   The Length property gives you a programmatic way to determine the number of elements in an array. */


string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
fraudulentOrderIDs[3] = "D000";


/* First: A123
   Second: B456
   Third: C789
   Reassign First: F000
   There are 3 fraudulent orders to process. */

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");