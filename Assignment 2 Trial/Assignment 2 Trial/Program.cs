using System; 

class Program
{
    static void Main(string[] args) // entry point
    {
        Bank bank = new Bank(); 

        while (true)
        {
            Console.WriteLine("Welcome to Imperial Australian Bank");  //using writeline method to display main screen
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter username: ");
                    string usernameLogin = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string passwordLogin = Console.ReadLine();
                    if (bank.Login(usernameLogin, passwordLogin))
                    {
                        Console.WriteLine("Login successful!");
                        // Implement further banking operations here
                    }
                    break;

                case 2:
                    Console.Write("Enter username: ");
                    string usernameSignUp = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string passwordSignUp = Console.ReadLine();
                    if (bank.SignUp(usernameSignUp, passwordSignUp))
                    {
                        Console.WriteLine("Sign up successful!");
                        // Implement further actions after sign up if needed
                    }
                    break;

                case 3:
                    Console.WriteLine("Thank you for using Imperial Australian Bank. Goodbye!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }
}
