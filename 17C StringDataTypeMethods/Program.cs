const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

string opening = "<span>";
string closing = "</span>";

int startIndex = input.IndexOf(opening) + opening.Length;
int endIndex = input.IndexOf(closing); 
int length = endIndex - startIndex;

quantity = input.Substring(startIndex, length);
quantity = $"Quantity: {quantity}";

opening = "<div>";
int openingLength = opening.Length;
int openingIndex = input.IndexOf(opening);
output = input.Remove(openingIndex, openingLength);

closing = "</div>";
int closingLength = closing.Length;
int closingIndex = output.IndexOf(closing);
output = output.Remove(closingIndex, closingLength);

output = output.Replace("trade", "reg");
output = $"Output: {output}";


Console.WriteLine(quantity);
Console.WriteLine(output);