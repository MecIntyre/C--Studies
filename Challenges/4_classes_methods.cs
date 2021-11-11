/* Your job is to research and fill in the missing line of code that calls a method from Math class 
   that will accept two values and return the larger of the two values into the variable largerValue, 
   which will be printed to the console. 
   When you run your code, you should see the following output: 600
   Use the following code as the starting point for your code:  */

int firstValue = 500;
int secondValue = 600;
int largerValue;

Console.WriteLine(largerValue);

//Solution:

int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);