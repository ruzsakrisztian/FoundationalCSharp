// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// if (pallets[0] != null)
//     Console.WriteLine($"Before: {pallets[0].ToLower()}");

// Array.Clear(pallets, 0, 2);

// if (pallets[0] != null)
//     Console.WriteLine($"After: {pallets[0].ToLower()}");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// // Console.WriteLine("");
// // Array.Resize(ref pallets, 3);
// // Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// // foreach (var pallet in pallets)
// // {
// //     Console.WriteLine($"-- {pallet}");
// // }

// Console.WriteLine("");
// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// Console.WriteLine("");

// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// Console.WriteLine("");

// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }



// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

string value = "abc123";

char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

// Array.Reverse(valueArray);

// string reversedValue = "";
// foreach(char character in valueArray) {
//     reversedValue += character;
// }
// Console.WriteLine(reversedValue);
