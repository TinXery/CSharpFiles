int herosHP = 50, villiansHP = 50;
Random random = new Random();

System.Console.WriteLine("-------------- -   THE GAME   - ----------------------");
do
{
    System.Console.WriteLine($"Hero's HP is: {herosHP} \tVillain's HP is: {villiansHP}");
    System.Console.WriteLine("- - - - - - ----------------------------- - - - - - -");

    int herosDamage = random.Next(1, 11);
    villiansHP -= herosDamage;

    System.Console.Write($"Hero dealt: {herosDamage} Dmg");
    if (villiansHP < 1) break;

    int villainsDamage = random.Next(1, 11);
    herosHP -= villainsDamage;

    System.Console.Write($"\tVillain dealt: {villainsDamage} Dmg\n");
} while (herosHP > 0);

System.Console.WriteLine("\n-----------------------------------------------------");
if (villiansHP < 0) System.Console.WriteLine("Hero Wins!");
else System.Console.WriteLine("Villian Wins!");