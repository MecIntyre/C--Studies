/* Flip a coin challenge
   Use the Random class to generate a value. Based on the value, use the conditional operator to display either heads or tails.
   There should be a 50% chance that the result is either heads or tails.
   You should be able to accomplish the desired result in three lines of code or less. 
   
One possible solution: */

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");


//Solution two:
Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");