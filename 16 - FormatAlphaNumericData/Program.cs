// string first = "Hello";
// string second = "World";
// string result = string.Format("{1} {0}!", first, second);
// result += "Hello again!";
// Console.WriteLine(result);

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price :C} (Save {discount:C})");


// decimal measurement = 123456.78982m;
// Console.WriteLine($"Measurement: {measurement:N3} units");

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// decimal price = 67880m;
// decimal salePrice = 59990m;

// string yourDiscount = String.Format("You saved {0:C0} off the regular {1:C0} price. ", (price - salePrice), price);
// yourDiscount += $"A discount of {(price - salePrice)/price:P1}!";
// Console.WriteLine(yourDiscount);

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");


// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12, '.'));
// Console.WriteLine(input.PadRight(12, '.'));

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);


