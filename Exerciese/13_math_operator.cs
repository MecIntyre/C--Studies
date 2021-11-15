/* Use operators like +, -, *, and / to perform basic mathematical operations.
The division of two int values will result in the truncation of any values after the decimal point. 
To retain values after the decimal point, you need to cast the divisor or dividend (or both) to from int into a floating point number like decimal first, then the quotient must be of the same floating point type as well in order to avoid truncation.
Perform a cast operation to temporarily treat a value as if it were a different data type.
Use the % operator to capture the remainder after division.
The order of operations will follow the rules of the acronym PEMDAS. */

// Output: Sum: 12 Difference: 2 Product: 35 Quotient: 1
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);


// Perform division using literal decimal data.
// Output: Decimal quotient: 1.4
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine("Decimal quotient: " + decimalQuotient);


/* Determine the remainder after int division
   Output: Modulus of 200 / 5 : 0
           Modulus of 7 / 5: 2 */
Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
Console.WriteLine("Modulus of 7 / 5: " + (7 % 5));


/* Order of operations
   Output: 23
           35 */
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);