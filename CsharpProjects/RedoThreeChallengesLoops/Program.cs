// CODE PROJECT 3 - Write code that processes the contents of a string array

string[] myWords = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodTracer = 0;

foreach (string myString in myWords)
{
    if (myString.IndexOf(".") == -1)
    {
        while (periodTracer < 1)
        {
            System.Console.WriteLine(myString);
            periodTracer++;
        }

    }
    else
    {
        string[] subWords = myString.Split(". ");
        while (periodTracer < subWords.Length)
        {
            string subWord = subWords[periodTracer];
            System.Console.WriteLine(subWord);
            periodTracer++;
        }
    }
}


