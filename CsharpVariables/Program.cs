using CsharpVariables;

Greeting();

string firstName = FirstName();
string lastName = LastName();
char middleInitial = MiddleInitial();
int myAge = MyAge();
string userEmail = UserEmail();
bool userAnswer = UserAnswer();

CreateNewUser(userAnswer, firstName, lastName, middleInitial, myAge, userEmail, userAnswer);


static void CreateNewUser(bool userInput, string firstName, string lastName, char middleInitial, int myAge, string userEmail, bool userAnswer)
{
    if (userInput == true)
    {
        Console.Write("Okay, Please Wait While your account is created...");
        Console.ReadLine();
        Thread.Sleep(3000); 
        UserAccount newUser = new UserAccount(firstName, lastName, middleInitial, myAge, userEmail);
    }
    else
    {
        Greeting();
    }
}

static bool UserAnswer()
{
    Console.Write("Would you like to create a new Account (Y/N)? ");
    string answer = Console.ReadLine().ToUpper();
    if (answer == "Y")
    {
        bool newAnswer = true;
        return newAnswer;
    }
    else
    {
        bool newAnswer = false;
        Console.Write("Okay, Thank you. ");
        Console.ReadLine();
        return newAnswer;
    }

}

static string UserEmail()
{
    Console.Write("Please Enter your Email Address: ");
    string email = Console.ReadLine();
    return email;
}

static int MyAge()
{
    try
    {
        Console.Write("Please Enter your Age: ");
        int myAge = Convert.ToInt32(Console.ReadLine());
        return myAge;
    }
    catch
    {
        Console.WriteLine("There was an Error.");
        Console.WriteLine("Please Try Again and Enter a Number. ");
        Console.WriteLine("-----------------------------------");
        return MyAge();
    }
}

static char MiddleInitial()
{
    try
    {
        Console.Write("Please Enter your Middle Initial: ");
        char middleInitial = Convert.ToChar(Console.ReadLine());
        return middleInitial;
    }
    catch
    {
        Console.WriteLine("There was an Error.");
        Console.WriteLine("Please Try Again and Enter a Single Letter. ");
        Console.WriteLine("-----------------------------------");
        return MiddleInitial();
    }

}

static string LastName()
{
    Console.Write("Please Enter your Last Name: ");
    string lastName = Console.ReadLine();
    return lastName;
}

static string FirstName()
{
    Console.Write("Please Enter your First Name: ");
    string firstName = Console.ReadLine();
    return firstName;
}

static void Greeting()
{
    Console.Write("Welcome! Press any Key to Continue. ");
    Console.ReadLine();
}
