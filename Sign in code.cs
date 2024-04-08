BankAccount JoeAccount = new BankAccount("Joe.Doe", "Password123");
double choice; 
string userguess;
string passwordguess;
int chances = 0;


Console.WriteLine("Press 1 to login as Joe Doe, 2 to sign up, or 3 to quit"); //to be used when integrating log in and sign up code
choice = int.Parse(Console.ReadLine());
if (choice == 1)
{


    Console.WriteLine(JoeAccount.Username); //Spencer this is just for you you get rid of it at the end its just to remember

    Console.WriteLine("You have chosen to log in. Please input Joe Doe's username to ensure correct login.");
    userguess = Console.ReadLine();
    do
    {
        if (JoeAccount.Username == userguess)
        {
            Console.WriteLine("Welcome Joe. ");
        }
        else
        {
            Console.WriteLine("That username is incorrect. Please try again");
        }
    }
    while (userguess != JoeAccount.Username);
    do
    {
        Console.Write("Please input your password. You have {0} chances remaining", 3 - chances);
        passwordguess = Console.ReadLine();
        if (passwordguess == JoeAccount.Password)
        {
            break;
        }
        else
        {
            chances++;
            Console.WriteLine("Incorrect. Please try again. ");
        }
    }
    while (chances < 3);
    if (passwordguess == JoeAccount.Password)
    {
        Console.WriteLine("That password is correct. Welcome to your bank account.");
    }
    else
    {
        Console.WriteLine("You have inputted too many invalid passwords. Please try again later");
        System.Environment.Exit(0);
    }


}
else if (choice == 2)
{
    //All the sign up stuff
}
else if (choice == 3)
{
    //just end the program
}
else
    Console.WriteLine("Invalid Choice. Please rerun program and choose again");
public class BankAccount
{
    public string Username { get; set; }
    public string Password { get; set; }

    public BankAccount(string loginID, string authenticator)
    {
        Username = loginID;
        Password = authenticator;

    }
}

