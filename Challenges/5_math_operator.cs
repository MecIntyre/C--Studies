
/*
Write code in the .NET Editor to calculate Celsius given the current temperature in Fahrenheit.
To convert temperatures in degrees Fahrenheit to Celsius, first subtract 32, then multiply by five ninths (5 / 9).
The temperature is 34.444444444444444444444444447 Celsius. */


int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");
