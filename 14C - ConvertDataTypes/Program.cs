
// Important: decimal separator is ","
// If I use "12.3", this code will not work 
// (Hungarian decimal separator is ",")

string[] values = { "12,3", "45", "ABC", "11", "DEF" };


decimal total = 0;
decimal numberFound;
string message = "Message: ";

for (int i = 0; i < values.Length; i++)
{
    string stringToTry = values[i];



    if (Decimal.TryParse(stringToTry, out numberFound))
    {
        total += numberFound;
    }
    else
    {
        message += stringToTry;
    }
}

Console.WriteLine($"Total = {total}");
Console.WriteLine($"Message = {message}");


// Second challenge

/* int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 =  Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
 */