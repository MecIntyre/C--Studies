/* Use compound assignment operators like +=, -=, *=, ++, and -- to perform a mathematical operation like increment or decrement, 
   then assign the result into the original variable.
   Increment and decrement operators perform differently depending on whether the operator is before or after the operand. */


int value = 0;
value = value + 5;
value += 5;


int value = 0;
value = value + 1;
value++;


/* Output:
   First increment: 2
   Second increment: 3
   Third increment: 4
   First decrement: 3
   Second decrement: 2
   Third decrement: 1
   value = value + 1; */

int value = 1;
Console.WriteLine("First increment: " + value);
value += 1;
Console.WriteLine("Second increment: " + value);
value++;
Console.WriteLine("Third increment: " + value);
value = value - 1;
Console.WriteLine("First decrement: " + value);
value -= 1;
Console.WriteLine("Second decrement: " + value);
value--;
Console.WriteLine("Third decrement: " + value);


/* increment operator before and after the value.
   Output:
   First: 2
   Second: 2
   Third: 3
   Fourth: 4 */

int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine("Second: " + value++);
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));