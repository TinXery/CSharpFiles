//New class to create a random Dice Throw. including Integers to store each numbers and the sum of the dice throws.
Random dice = new Random();

int diceThrowOne = dice.Next(1, 7);
int diceThrowTwo = dice.Next(1, 7);
int diceThrowThree = dice.Next(1, 7);

int total = diceThrowOne + diceThrowTwo + diceThrowThree;

//Checks if the the Dice Throw is eligable for bonus points
if (diceThrowOne == diceThrowTwo && diceThrowTwo == diceThrowThree)
{
    total += 6;
}
else if (diceThrowOne == diceThrowTwo || diceThrowOne == diceThrowThree || diceThrowTwo == diceThrowThree)
{
    total += 2;
}

// Check if you Total will have enough score to win + debug Print for each integer.
Console.WriteLine("Dice 1: " + diceThrowOne);
Console.WriteLine("Dice 2: " + diceThrowTwo);
Console.WriteLine("Dice 3: " + diceThrowThree);
Console.WriteLine("Total including bonus points: " + total);
if (total >= 16)
{
    Console.WriteLine("You win a new Car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new Laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a Trip for Two!");
}
else
{
    Console.WriteLine("You win a Kitten!");
}