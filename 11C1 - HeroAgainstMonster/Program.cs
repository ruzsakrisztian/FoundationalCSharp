int heroHealthPoints = 10;
int monsterHealthPoints = 10;
Random pointsToLose = new Random();
int lostPoints = 0;
do
{
    lostPoints = pointsToLose.Next(1, 11);
    monsterHealthPoints -= lostPoints;
    Console.WriteLine($"Monster was damaged and lost {lostPoints} health and now has {monsterHealthPoints} health.");
    
    if (monsterHealthPoints <= 0) continue;

    lostPoints = pointsToLose.Next(1, 11);
    heroHealthPoints -= lostPoints;
    Console.WriteLine($"Hero was damaged and lost {lostPoints} health and now has {heroHealthPoints} health.");

} while ((heroHealthPoints > 0) && (monsterHealthPoints > 0));