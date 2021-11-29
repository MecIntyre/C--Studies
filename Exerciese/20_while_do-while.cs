/* The do-while statement iterates through a code block at least once, 
   and may continue to iterate based on a Boolean expression. 
   The evaluation of the Boolean expression usually depends on some value generated 
   or retrieved inside of the code block.
   The while statement evaluates a Boolean expression first, 
   and continues to iterate through the code block as long as the Boolean expression evaluates to true.
   The continue keyword to step immediately to the Boolean expression. */

/*
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7); */


/*
Random random = new Random();
int current = random.Next(1, 11);

while (current >=3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}"); */


Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

