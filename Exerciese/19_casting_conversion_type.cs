/* Use TryParse() when converting a string into a numeric data type.
   TryParse() returns true if the conversion is successful, false if it's unsuccessful.
   An out parameter provides a secondary means of a method returning a value. 
   In this case, the out parameter returns the converted value.
   Use the keyword out when passing in an argument to a method that has defined an out parameter. */


/* Output: Measurment: 102
           Measurement (w/ offset): 152 */

string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

/* Since it is defined outside of the if statement, 
   it can be accessed later in code. */
Console.WriteLine($"Measurement (w/ offset): {50 + result}");