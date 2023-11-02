using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises"
};

PlanVisit("School A");
PlanVisit("School B", 2);
PlanVisit("School C", 3);

void PlanVisit(string schoolName, int groups = 6) {
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}

void RandomizeAnimals()
{
    string tempAnimal = "";
    Random random = new Random();
    int indexOfRandomAnimal;
    for (int i = 0; i < pettingZoo.Length; i++)
    {
        tempAnimal = pettingZoo[i];
        indexOfRandomAnimal = random.Next(0, pettingZoo.Length);
        pettingZoo[i] = pettingZoo[indexOfRandomAnimal];
        pettingZoo[indexOfRandomAnimal] = tempAnimal;
    }
}

string[,] AssignGroup(int numberOfGroups = 6)
{
    int animalsPerGroup = pettingZoo.Length / numberOfGroups;
    string[,] groups = new string[numberOfGroups, animalsPerGroup];
    for (int i = 0; i < numberOfGroups; i++)
    {
        for (int j = 0; j < animalsPerGroup; j++)
        {
            groups[i, j] = pettingZoo[animalsPerGroup * i + j];
        }
    }
    return groups;
}

void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i, j]} ");
        }
        Console.WriteLine();
    }
}