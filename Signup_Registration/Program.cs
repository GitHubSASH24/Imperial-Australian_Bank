using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class Bank
{
    private List<UserAccount> accounts; // List to store user accounts

    public Bank()
    {
        accounts = new List<UserAccount>(); // Initialize the list of user accounts
    }

    // Method for user sign-up process
    public void SignUp()
    {
        Console.WriteLine("Welcome to the registration process.");

        // Get user details
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter your email address: ");
        string email = Console.ReadLine();

        Console.Write("Enter your phone number: ");
        string phone = Console.ReadLine();

        string password = null;
        bool passwordValid = false;
        while (!passwordValid)
        {
            // Prompt user for password generation or custom password entry
            Console.WriteLine("Do you want to generate a password? (yes/no)");
            string response = Console.ReadLine().ToLower();

            if (response == "yes") // User chooses to generate password
            {
                try
                {
                    // Generate a password with length 8
                    password = PasswordGenerator.GeneratePassword(8);
                    Console.WriteLine("Generated Password: " + password);
                    passwordValid = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else if (response == "no") // User chooses to set a custom password
            {
                // Prompt user for custom password with requirements
                Console.WriteLine("Please set a custom password:");
                Console.WriteLine(GetPasswordRequirements());
                Console.Write("Enter your password: ");
                password = Console.ReadLine();

                // Check if custom password meets requirements
                if (IsPasswordValid(password))
                {
                    passwordValid = true;
                }
                else
                {
                    Console.WriteLine("Password does not meet the requirements. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid response. Please enter 'yes' or 'no'.");
            }
        }

        // Store user inputs
        string[] userInputs = { firstName, lastName, email, phone, password };

        // Check if email already exists
        if (accounts.Exists(acc => acc.Email == email))
        {
            Console.WriteLine("Email already registered.");
            return;
        }

        // Create a new user account and add it to the list
        UserAccount newUser = new UserAccount(firstName, lastName, email, phone, password);
        accounts.Add(newUser);

        Console.WriteLine("Sign up successful.");

        // Print user inputs for verification
        Console.WriteLine("\nYour inputs:");
        Console.WriteLine("First Name: " + userInputs[0]);
        Console.WriteLine("Last Name: " + userInputs[1]);
        Console.WriteLine("Email: " + userInputs[2]);
        Console.WriteLine("Phone: " + userInputs[3]);
        Console.WriteLine("Password: " + userInputs[4]);
    }

    // Method for user sign-in process
    public void SignIn()
    {
        Console.WriteLine("\nWelcome to the sign-in process.");

        // Get user email
        Console.Write("Enter your email address: ");
        string email = Console.ReadLine();

        // Get user password
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        // Find user account with provided email
        UserAccount user = accounts.Find(acc => acc.Email == email);

        // Check if user exists and password matches
        if (user != null && user.Password == password)
        {
            Console.WriteLine("Sign in successful.");
            // Provide access to banking operations
        }
        else
        {
            Console.WriteLine("Invalid email or password.");
        }
    }

    // Method to validate if password meets requirements
    private static bool IsPasswordValid(string password)
    {
        // Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character
        return password.Length >= 8 &&
               Regex.IsMatch(password, "[A-Za-z]") && // Contains alphabetical characters
               Regex.IsMatch(password, "[0-9]") &&  // Contains numerical characters
               Regex.IsMatch(password, "[!@#$%^&*]"); // Contains special character
    }

    // Method to provide password requirements message
    private string GetPasswordRequirements()
    {
        return "Password must be at least 8 characters long and contain at least one alphabetical character, one numerical character, and one special character.";
    }
}

public class UserAccount
{
    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public string Phone { get; }
    public string Password { get; }

    public UserAccount(string firstName, string lastName, string email, string phone, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Password = password;
    }
}

public class PasswordGenerator
{
    private const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
    private const string DigitChars = "0123456789";
    private const string SpecialChars = "!@#$%^&*()-_=+";

    private static readonly Random random = new Random();

    // Method to generate a random password of specified length
    public static string GeneratePassword(int length)
    {
        // Define character pool for password generation
        string charPool = UppercaseChars + LowercaseChars + DigitChars + SpecialChars;

        // Create a StringBuilder to store the password
        var passwordBuilder = new StringBuilder();

        // Generate random characters for the password
        for (int i = 0; i < length; i++)
        {
            // Append a random character from the charPool
            passwordBuilder.Append(charPool[random.Next(charPool.Length)]);
        }

        // Shuffle the generated password for added security
        return ShuffleString(passwordBuilder.ToString());
    }

    // Method to shuffle a string
    private static string ShuffleString(string str)
    {
        char[] chars = str.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            int j = random.Next(i, chars.Length);
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }
        return new string(chars);
    }
}

class Program
{
    static void Main()
    {
        Bank myBank = new Bank();

        // Sign up a user
        myBank.SignUp();

        // Print a separator before attempting sign-in
        Console.WriteLine("\n=======================");

        // Attempt sign in
        myBank.SignIn();
    }
}
