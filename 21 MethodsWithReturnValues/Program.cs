// Understand return type syntax

// double total = 0;
// double minimumSpend = 30.00;

// double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
// double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// if (TotalMeetsMinimum())
// {
//     total -= 5.00;
// }

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     // Calculate the discounted price of the item
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//     // Check if the total meets the minimum
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     // Format the double so only 2 decimal places are displayed
//     return input.ToString().Substring(0, 5);
// }


// Return numbers from methods

// double usd = 23.73;
// int vnd = UsdToVnd(usd);
// usd = VndToUsd(vnd);


// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"${vnd} VND = ${usd} USD");

// int UsdToVnd(double usd)
// {
//     int rate = 23500;
//     return (int)(rate * usd);
// }

// double VndToUsd(int vnd)
// {
//     int rate = 23500;
//     return (double)vnd / rate;
// }


// Return strings from methods

// string input = "there are snakes at the zoo";

// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));

// string ReverseWord(string word)
// {
//     string result = "";
//     for (int i = word.Length - 1; i >= 0; i--)
//     {
//         result += word[i];
//     }
//     return result;
// }

// string ReverseSentence(string input)
// {
//     string result = "";
//     string[] words = input.Split(" ");

//     foreach (string word in words)
//     {
//         result += ReverseWord(word) + " ";
//     }

//     return result.Trim();
// }



// Return bool from methods

// string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words)
// {
//     Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }

// bool IsPalindrome(string word)
// {
//     int start = 0;
//     int end = word.Length - 1;

//     while (start < end)
//     {
//         if (word[start] != word[end])
//         {
//             return false;
//         }
//         start++;
//         end--;
//     }

//     return true;
// }


// Return arrays from methods

// int target = 60;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[] result = TwoCoins(coins, target);

// if (result.Length == 0) 
// {
//     Console.WriteLine("No two coins make change");
// } 
// else 
// {
//     Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
// }

// int[] TwoCoins(int[] coins, int target)
// {
//     for (int first = 0; first < coins.Length; first++)
//     {
//         for (int second = first; second < coins.Length; second++)
//         {
//             if (coins[first] + coins[second] == target)
//             {
//                 return new int[] {first, second};
//             }
//         }
//     }
//     return  new int[0];
// }

int target = 51;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[,] result = TwoCoins(coins, target);


if (result.Length == 0)
{
    Console.WriteLine("No matches found.");
}

else
{
    for (int i = 0; i < 5; i++)
    {
        if (result[i, 0] != -1)
            Console.WriteLine($"Position {result[i, 0]} and {result[i, 1]} are a match.");

    }
};

int[,] TwoCoins(int[] coins, int target)
{
    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
    int counter = 0;
    for (int first = 0; first < coins.Length; first++)
    {
        for (int second = first; second < coins.Length; second++)
        {
            if (coins[first] + coins[second] == target && counter < 5)
            {
                result[counter, 0] = first;
                result[counter, 1] = second;
                counter++;
            }
        }
    }

    return counter == 0 ? new int[0, 0] : result;
}