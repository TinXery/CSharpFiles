﻿Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    System.Console.WriteLine(current);
} while (current != 7);

/* do
{
    current = random.Next(1, 11);
    System.Console.WriteLine(current);
} while (current != 7); */

/* while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}

System.Console.WriteLine($"Last number: {current}");
 */