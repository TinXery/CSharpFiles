Console.Clear();
// string[] names = { "Alice", "Bob", "Charlie", "Diana" };
// for (int i = names.Length - 1; i >= 0; i--) 
// {
//     Console.WriteLine(names[i]);
// }

string[] names = { "Alice", "Bob", "Charlie", "Diana" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "Charlie") names[i] = "Sammy";


foreach (string name in names) Console.WriteLine(name);


Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();





