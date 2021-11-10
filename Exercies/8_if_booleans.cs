// Use an if statement to branch your code logic. 
// The if decision statement will execute code in its code block if its Boolean expression equates to true. 
// Otherwise, the runtime will skip over the code block and continue to the next line of code after the code block.
// A Boolean expression is any expression that returns a boolean value.
// Boolean operators will compare the two values on its left and right for equality, comparison, and more.
// A code block is defined by curly braces { }. It collects lines of code that should be treated as a single unit.
// The logical AND operator && aggregates two expressions so that both subexpressions 
// must be true in order for the entire expression to be true.
// The logical OR operator || aggregates two expressions so that if either subexpression is true, the entire expression is true.

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// 3. Add another if statement to implement the doubles bonus
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

// 4. Add another if statement to implement the triples bonus
if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

// 1. Add an if statement to display win message based on the value of the total variable
if (total > 14)
{
    Console.WriteLine("You win!");
}

// 2. Add an if statement to display win message based on the value of the total variable
if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}


// Boolean expression
// Output: True

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}