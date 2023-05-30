namespace LockedDoor
{
     class Program
     {
          // Door as a class-level variable
          static Door door;

          public static void Main(string[] args)
          {
               // create instance of door
               door = new Door(1111);

               // Introduction, door begins locked
               System.Console.WriteLine("Welcome to your new Door™!");
               System.Console.WriteLine("The default passcode is 1111. Please change while the door is open to improve security.");

               LockDoor();
          }

          public static void UnlockDoor()
          {
               while (true)
               {
                    System.Console.WriteLine("Door is now unlocked. Enter 1 to open the door or 2 to re-lock the door.");
                    string? userInput = Console.ReadLine();

                    if (userInput == "1")
                    {
                         OpenDoor();
                         break;
                    }
                    else if (userInput == "2")
                    {
                         LockDoor();
                         break;
                    }
                    else
                    {
                         System.Console.WriteLine("Invalid Input. Please try again.");
                    }
               }
          }

          public static void OpenDoor()
          {
               while (true)
               {
                    System.Console.WriteLine("Door is now open. Enter 1 to close the door or 2 to change the password.");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == 1)
                    {
                         CloseDoor();
                         break;
                    }
                    else if (userInput == 2)
                    {
                         ChangePasscode();
                         break;
                    }
                    else
                    {
                         System.Console.WriteLine("Invalid Input. Please try again.");
                    }
               }
          }
          public static void CloseDoor()
          {
               while (true)
               {
                    System.Console.WriteLine("Door is now closed. Enter 1 to lock the door or 2 to open.");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == 1)
                    {
                         LockDoor();
                         break;
                    }
                    else if (userInput == 2)
                    {
                         OpenDoor();
                         break;
                    }
                    else
                    {
                         System.Console.WriteLine("Invalid Input. Please try again.");
                    }
               }
          }
          public static void LockDoor()
          {
               while (true)
               {
                    System.Console.WriteLine("The door is currently locked. Please enter the 4 digit passcode to unlock the door.");
                    int userPasscodeAttempt = Convert.ToInt32(Console.ReadLine());

                    if (userPasscodeAttempt == door.Passcode)
                    {
                         UnlockDoor();
                    }
                    else if (userPasscodeAttempt.ToString().Length > 4)
                    {
                         System.Console.WriteLine("Remember that the passcode is only 4 digits.");
                    }
                    else 
                    {
                         System.Console.WriteLine("Invalid Password. Please try again.");
                    }
               }
          }

          public static void ChangePasscode()
          {
               while (true)
               {
                    System.Console.WriteLine("Please enter the new 4-digit passcode: ");
                    int userPasscode = Convert.ToInt32(Console.ReadLine());

                    if (userPasscode.ToString().Length != 4)
                    {
                         System.Console.WriteLine("Passcode must be 4 digits long. Please try again.");
                    }
                    else if (userPasscode.ToString().Length == 4)
                    {
                         System.Console.WriteLine("Passcode accepted. Thank you.");
                         door.Passcode = userPasscode;
                         OpenDoor();
                    }
                    else
                    {
                         System.Console.WriteLine("Invalid passcode. Please try again.");
                    }
               }
          }
     }
}