﻿Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triple! 6 bonus to total");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total");
        total += 2;
    }
}

if (total > 15)
{
    Console.WriteLine("Congratulations! You just win a brand new car!");
}
else if (total > 9)
{
    Console.WriteLine("Congratulations! You just win a laptop!");
}
else if (total == 7)
{
    Console.WriteLine("Congratulations! You just win 2 tickets for a trip!");
}
else
{
    Console.WriteLine("You win a kitten :)");
}

