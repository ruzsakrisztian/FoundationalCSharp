/*
    This code reverses a string
    and counts the number of times
    a particular character appears.
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = originalMessage.ToCharArray();
Array.Reverse(charMessage);

int letterCount = 0;

foreach (char i in charMessage) 
{ 
    if (i == 'o') 
    { 
        letterCount++; 
    } 
}

string newMessage = new String(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {x} times.");