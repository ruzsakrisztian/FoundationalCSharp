string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(" ");

for(int i = 0; i< words.Length; i++) {
    char[] letters = words[i].ToCharArray();
    Array.Reverse(letters);
    words[i] = new string(letters);
}

string newPangram = string.Join(" ", words);

Console.WriteLine(newPangram);