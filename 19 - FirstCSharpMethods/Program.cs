// SayHello();

// void SayHello()
// {
//     Console.WriteLine("Hello World!");
// }

// int[] a = {1,2,3,4,5};

// Console.WriteLine("Contents of Array:");
// PrintArray();

// void PrintArray()
// {
//     foreach (int x in a)
//     {
//         Console.Write($"{x} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Before calling a method");
// SayHello();
// Console.WriteLine("After calling a method");

// void SayHello() 
// {
//     Console.WriteLine("Hello World!");
// }

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers() 
// {
//     Random random = new Random();

//     for (int i = 0; i < 5; i++) 
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }

//     Console.WriteLine();
// }


// Idendtify Duplicated Code

// using System;

// int[] times = { 800, 1200, 1600, 2000 };
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// /* Format and display medicine times */

// WriteTime(times);

// Console.WriteLine();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// }
// else
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");

// /* Format and display medicine times */
// WriteTime(times);


// Console.WriteLine();


// void WriteTime(int[] timeArray)
// {
//     foreach (int val in timeArray)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }
// }

// void AdjustTimes() 
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }



// Validate IP Address

string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
    ValidateLength();
    ValidateRange();
    ValidateZeroes();

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"ip is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"ip is an invalid IPv4 address");
    }
}



void ValidateLength()
{
    validLength = address.Length == 4;
}
void ValidateZeroes()
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange()
{
    foreach (string number in address)
    {
        if (int.Parse(number) > 255)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}