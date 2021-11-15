/* The for iteration statement allows you to iterate through a block of code a specific number of times.
   The for iteration statement allows you to control every aspect of the iteration's mechanics by altering the three conditions 
   inside the parenthesis: the initializer, condition, and iterator.
   It's common to use the for statement when you need to control how you want to iterate through each item in an array.
   If your code block has only one line of code, you can eliminate the opening and closing curly braces and white space if you wish. */


/* Basic for statement
Output: 0 1 2 3 4 5 6 7 8 9 */
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


/* Change the iteration conditions
Output: 9 8 7 6 5 4 3 2 1 0 */
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}


/* Experiment with the iterator's pattern
Output: 0 3 6 9   */
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}


/* Use the break keyword to break the iteration statement
Output: 0 1 2 3 4 5 6 7    */
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}


/* Loop through each element of an array
Output: Michael David Eddie Alex */
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}


/* Limitation of the foreach statement
Output: Cannot assign to name because it is a 'foreach iteration variable' */
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}


/* Overcome the limitation of foreach with a for-statement
Output: Alex Eddie Sammy Michael */
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name); 