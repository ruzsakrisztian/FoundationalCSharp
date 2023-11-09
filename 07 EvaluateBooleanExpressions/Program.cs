/* 
    Random coinFlip = new Random();
    int coinFlipValue = coinFlip.Next(0, 2);

    string coinFlipResult = coinFlipValue == 0 ? "heads" : "tails";
    Console.WriteLine(coinFlipResult); 
*/

// Challenge (from unit 6 of 9)


MessageBox.Show("Hello, World!");

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin") && level > 55)
    Console.WriteLine("Welcome, Super Admin user.");
else if (permission.Contains("Admin") && level <= 55)
    Console.WriteLine("Welcome, Admin user.");
else if (permission.Contains("Manager") && level >= 20)
    Console.WriteLine("Contact an Admin for access");
else if (permission.Contains("Magager") && level < 20)
    Console.WriteLine("You do not have sufficient privileges.");
else
    Console.WriteLine("You do not have sufficient privileges.");
