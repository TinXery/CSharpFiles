﻿
/* string[] fraudulentOrderIDs = new string[3]; 
   fraudulentOrderIDs[0] = "A123";
   fraudulentOrderIDs[1] = "B456";
   fraudulentOrderIDs[2] = "C789";
   //fraudulentOrderIDs[3] = "D000"; */

/* string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine("Fraudulent Order IDs: ");
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders.");
 */

/* string[] names = { "Alice", "Bob", "Charlie", "Diana", "Eve" };
foreach (string name in names)
{
    Console.WriteLine(name);
} */

/* int sum = 0;
int bin = 0;
int[] inventory = { 200, 450, 700, 175, 250 };
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items. running total = {sum}");
}
Console.WriteLine($"We have {sum} items in Inventory.");
 */

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine($"{orderID}");
    }
}




