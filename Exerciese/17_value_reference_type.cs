/* Values are stored as bits, which are simple on / off switches. 
   Combining enough of these switches allows you to store just about any possible value.
   There are two basic categories of data types: value and reference types. 
   The difference is in how and where the values are stored by the computer as your program executes.
   Simple value types include signed and unsigned integral numeric types and floating-point numeric types. 
   
   An integral type is a simple value data type that can hold whole numbers.
   There are signed and unsigned data types. Signed integral types use one bit to store whether the value is positive or negative.
   You can use the MaxValue and MinValue properties of numeric data types to evaluate whether a number can fit in a given data type. 
   
   Value types can hold smaller values and are stored in the stack. 
   Reference types can hold large values, and a new instance of a reference type is created using the new operator. 
   Reference type variables hold a reference (the memory address) to the actual value stored in the heap.
   Reference types include arrays, strings, and classes. */


// MinValue and MaxValue properties for each signed integral type
Console.WriteLine("Signed integral types:");
Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
/* Output:
   Signed integral types:
   sbyte  : -128 to 127
   short  : -32768 to 32767
   int    : -2147483648 to 2147483647
   long   : -9223372036854775808 to 9223372036854775807 */


// MinValue and MaxValue properties for each unsigned integral type
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");
Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
/* Output:
   Unsigned integral types:
   byte   : 0 to 255
   ushort : 0 to 65535
   uint   : 0 to 4294967295
   ulong  : 0 to 18446744073709551615  */


/* A floating-point type is a simple value data type that can hold fractional numbers.  
   Choosing the right floating-point type for your application requires you to consider more than just the maximum 
   and minimum values that it can hold. 
   You must also consider how many values can be preserved after the decimal, how the numbers are stored, 
   and how their internal storage affects the outcome of math operations.
   Floating-point values can sometimes be represented using "E notation" when the numbers or exponents grow especially large.
   There's a fundamental difference in how the compiler and runtime handle decimal as opposed to float or double, 
   especially when determining how much accuracy is necessary from math operations. */


Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
/* Output:
   Floating point types:
   float  : -3.402823E+38 to 3.402823E+38 (with ~6-9 digits of precision)
   double : -1.79769313486232E+308 to 1.79769313486232E+308 (with ~15-17 digits of precision)
   decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision) */
