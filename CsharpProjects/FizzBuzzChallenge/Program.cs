Console.Clear();
for (int i = 1; i <= 100; i++)
{
    string fizzBuzzAdder = "";
    System.Console.Write(i);
    if (i % 3 == 0) fizzBuzzAdder += "Fizz";
    if (i % 5 == 0) fizzBuzzAdder += "Buzz";
    if (fizzBuzzAdder.Length != 0) System.Console.Write(" - ");
    System.Console.WriteLine($"{fizzBuzzAdder}");
}