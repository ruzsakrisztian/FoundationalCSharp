string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    DisplayEmail(corporate, i);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    DisplayEmail(external, i, externalDomain);
}

void DisplayEmail(string[,] nameList, int position, string domain = "contoso.com")
{
    string address = nameList[position, 0].Substring(0, 2) + nameList[position, 1];
    address = address.ToLower();
    Console.WriteLine($"{address}@{domain}");
}