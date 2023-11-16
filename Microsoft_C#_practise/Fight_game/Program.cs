int heroHealth = 10;
int enemyHealth = 10;

Random random = new Random();

while (heroHealth > 0 && enemyHealth > 0)
{
    int heroAttack = random.Next(1,11);
    enemyHealth -= heroAttack;
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {enemyHealth} health.");

    if (enemyHealth <= 0)
    {
        Console.WriteLine("Hero wins!");
        break;
    }

    int enemyAttack = random.Next(1,11);
    heroHealth -= enemyAttack;
    Console.WriteLine($"Hero was damaged and lost {enemyAttack} health and now has {heroHealth} health.");

    if (heroHealth <= 0)
    {
        Console.WriteLine("Enemy wins!");
        break;
    }

}