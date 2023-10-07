// Project 1 - Validating integer input

/* int enteredNumber = 0;
bool validNumber = false;
string? readEntry;

Console.WriteLine("Enter an integer between 5 and 10!");

do
{
    readEntry = Console.ReadLine();
    validNumber = int.TryParse(readEntry, out enteredNumber);
    if (!validNumber)
        Console.WriteLine("This is not an integer. Please try again: ");
    else if (enteredNumber < 5 || enteredNumber > 10)
        Console.WriteLine("The number is not between 5 and 10. Please try again: ");

} while (!validNumber || enteredNumber < 5 || enteredNumber > 10);

Console.WriteLine($"Your number ({enteredNumber}) was accepted."); */


// Project 2 - Validating string input

/* string? entry = "";
string? trimmedRole = "";

Console.WriteLine("What is your role? (Adminstrator / Manager / User)");

do
{
    entry = Console.ReadLine();
    if (entry != null)
        trimmedRole = entry.Trim().ToLower();
    if (trimmedRole != "administrator" && trimmedRole != "manager" && trimmedRole != "user")
        Console.WriteLine($"This role ({trimmedRole}) does not exist. Please try again: ");
        

} while (trimmedRole != "administrator" && trimmedRole != "manager" && trimmedRole != "user");

Console.WriteLine($"You logged in as {trimmedRole}"); */


// Project 3

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string text in myStrings)
{
    string myString = text;
    int placeOfPeriod = myString.IndexOf(".");
    while (placeOfPeriod > -1)
    {
        string stringToDisplay = myString.Remove(placeOfPeriod);
        myString = myString.Remove(0, placeOfPeriod+1);
        Console.WriteLine(stringToDisplay.Trim());
        placeOfPeriod = myString.IndexOf(".");
    }
    Console.WriteLine(myString.Trim());
}