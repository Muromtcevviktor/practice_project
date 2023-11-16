
                                        // Project 1
/*
Console.WriteLine("Enter an integer value between 5 and 10");

int numericValue = 0;
bool validNumber = false;

do
{
    string readResult = Console.ReadLine();
    bool parseSuccess = int.TryParse(readResult, out numericValue);
    //Console.WriteLine(parseSuccess);
    if(numericValue >= 5 && numericValue <= 10)
    {
        Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
        validNumber = true;
    } else if (parseSuccess && numericValue < 5 || numericValue > 10)
        {
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
        }
            else
            {
                Console.WriteLine("Sorry, you entered an invalid number, please try again");
            }


} while (validNumber == false);
*/

                                        // Project 2

/*
Console.WriteLine("Enter you role name (Administrator, Manager, or User)");

bool validAnswer = false;
string userAnswer;

do
{
    string readResult = Console.ReadLine();
    userAnswer = readResult.Trim();

    if (userAnswer.ToLower() == "administrator" || userAnswer.ToLower() == "manager" || userAnswer.ToLower() == "user") 
    {
        validAnswer = true;
    } else
        {
            Console.WriteLine($"The role name that you entered, \"{userAnswer}\" is not valid. ");
        }

} while(validAnswer == false);

Console.WriteLine($"Your input value ({userAnswer}) has been accepted.");
*/

                                        // Project 3

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}