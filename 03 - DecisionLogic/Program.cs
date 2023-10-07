// See https://aka.ms/new-console-template for more information


// Roll dice

/* Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) && (roll1 == roll3))
{
    Console.WriteLine($"You rolled triples. +6 points to total");
    total += 6;
}
else if ((roll1 == roll2) || (roll3 == roll2) || (roll1 == roll3))
{
    Console.WriteLine($"You rolled doubles. +2 points to total");
    total += 2;
}

if (total >= 15)
{
    Console.WriteLine($"Total = {total}. You win!");
}

if (total < 15)
{
    Console.WriteLine($"Total = {total}. Sorry, you lose.");
}
 */



// Expiring subscription

Random random = new Random();
int daysUntilExpiration = random.Next(2,3);
int discountPercentage = 0;

Console.WriteLine($"\nDays until expiration: {daysUntilExpiration}\n");
if (daysUntilExpiration <= 0)
{
    Console.WriteLine("Your subscribtion has expired.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0) {
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
Console.WriteLine("");
