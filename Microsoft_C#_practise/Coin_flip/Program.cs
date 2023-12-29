Random random = new Random();
int randomValue = random.Next(0, 2);
Console.WriteLine(randomValue == 1 ? "heads" : "tails");