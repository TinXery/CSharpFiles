// CODE PROJECT 1

/* int userNumber = 0;
bool isValid = false;
bool isAccepted = false;
System.Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    string? userInput = Console.ReadLine();
    isValid = Int32.TryParse(userInput, out userNumber);

    if (isValid)
    {
        if (!(userNumber < 5 || userNumber > 10)) isAccepted = true;
        else System.Console.WriteLine($"You entered {userNumber}. Please enter a number between 5 and 10.");
    }
    else System.Console.WriteLine("Sorry, you entered an invalid number, please try again");

    isValid = false;
} while (!isAccepted);
System.Console.WriteLine($"Your input value ({userNumber}) has been accepted."); */



// CODE PROJECT 2

/* string? userInput;
bool isAccepted = false;
System.Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    userInput = Console.ReadLine();
    switch (userInput.Trim().ToLower())
    {
        case "administrator":
        case "manager":
        case "user":
            isAccepted = true;
            break;
        default:
            System.Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            break;
    }
} while (!isAccepted);

System.Console.WriteLine($"Your input value ({userInput}) has been accepted."); */


// CODE PROJECT 3

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringCount = myStrings.Length;

string myString = "";
int periodLocation = 0;




for (int i = 0; i < stringCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);
        System.Console.WriteLine(mySentence);

        myString = myString.Substring(periodLocation + 1);
        // System.Console.WriteLine("[DEBUG]: " + myString);

        myString = myString.TrimStart();
        // System.Console.WriteLine("[DEBUG]: " + myString);

        periodLocation = myString.IndexOf(".");
        // System.Console.WriteLine("[DEBUG]: " + myString.IndexOf("."));
    }

    mySentence = myString.Trim();
    System.Console.WriteLine(mySentence);
}