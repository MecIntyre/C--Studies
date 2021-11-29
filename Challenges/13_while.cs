/* Role playing game battle challenge
   The hero and the monster will start with 10 health points.
   All attacks will be a value between 1 and 10.
   The hero will attack first.
   Print the amount of health the monster lost and their remaining health.
   If the monster's health is greater than 0, it can attack the hero.
   Print the amount of health the hero lost and their remaining health.
   Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
   Print the winner.

   No matter how you do it, your code should produce a similar output:
    Monster was damaged and lost 1 health and now has 9 health.
    Hero was damaged and lost 1 health and now has 9 health.
    Monster was damaged and lost 7 health and now has 2 health.
    Hero was damaged and lost 6 health and now has 3 health.
    Monster was damaged and lost 9 health and now has -7 health.
    Hero wins! */

//One possible solution:

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");