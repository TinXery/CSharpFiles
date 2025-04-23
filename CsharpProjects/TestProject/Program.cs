Random dice = new();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(05, 101);

Console.WriteLine("" + roll1);
Console.WriteLine("" + roll2);
Console.WriteLine("" + roll3);