// Objectives:

// • Define a new PasswordValidator class that can be given a password and determine if the
// password follows the rules above.
// • Make your main method loop forever, asking for a password and reporting whether the password is
// allowed using an instance of the PasswordValidator class.



namespace passwordValidator
{
     class Program
     {
          public static void Main(string[] args)
          {
               while (true)
               {
                    AskPassword();
               }
          }

          public static void AskPassword()
          {
               System.Console.WriteLine("Please create a new password following these restrictions: ");
               System.Console.WriteLine("• Passwords must be at least 6 letters long and no more than 13 letters long.");
               System.Console.WriteLine("• Passwords must contain at least one uppercase letter, one lowercase letter, and one number.");

               string password = Console.ReadLine();

               PasswordValidator passwordValidator = new PasswordValidator(password);

               if (passwordValidator.IsPasswordValid())
               {
                    System.Console.WriteLine("Password is valid.");
               }
               else
               {
                    System.Console.WriteLine("Password is invalid. Try again.");
               }
          }
     }
}
