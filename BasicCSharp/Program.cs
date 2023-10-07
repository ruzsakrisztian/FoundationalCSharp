// See https://aka.ms/new-console-template for more information

// int egesz = 5;
int[] egeszTomb = { 3, 4, 5 };
int[] masikTomb = new int[3];
// Console.WriteLine(egesz);
int counter = 0;
foreach (int szam in egeszTomb)
{
    masikTomb[counter] = szam * 2;
    Console.WriteLine(szam);
    counter = counter + 1;
}

foreach (int szam in masikTomb)
{
    Console.WriteLine(szam);
}
