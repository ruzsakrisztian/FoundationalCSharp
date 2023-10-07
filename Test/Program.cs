long elso = 1;
long masodik = 1;
long fibonacciNumber = 0;

Console.WriteLine(elso);
Console.WriteLine(masodik);

for (int i = 0; i < 100; i++)
{
    fibonacciNumber = elso + masodik;
    Console.WriteLine(fibonacciNumber);

    elso = masodik;
    masodik = fibonacciNumber;
    
};