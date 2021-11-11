/* The if-else allows you to test for a condition and perform code when a Boolean expression is true, 
   and different code when the boolean expression is false.
   You can nest 'if' statements to narrow down a possible condition. 
   Use else if to create multiple exclusive conditions.
   An else is optional, but it must always come last. */

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

/* Nesting allows to place code blocks inside of code blocks. 
   Nest an if-else statement (the check for triples) 
   inside of another if statement (the check for doubles) to prevent them both from happening. */
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}