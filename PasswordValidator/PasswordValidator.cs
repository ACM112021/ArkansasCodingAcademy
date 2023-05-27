class PasswordValidator
     {
          public string UserPassword { get; set; }

          public PasswordValidator(string userpassword)
          {
               UserPassword = userpassword;
          }

          public bool IsPasswordValid()
          {
               bool hasLowercase = false;
               bool hasUppercase = false;
               bool hasNumber = false;

               foreach (char letter in UserPassword)
               {
                    if (char.IsLower(letter))
                    {
                         hasLowercase = true;
                    }
                    else if (char.IsUpper(letter))
                    {
                         hasUppercase = true;
                    }
                    else if (char.IsDigit(letter))
                    {
                         hasNumber = true;
                    }
               }

               return hasLowercase && hasUppercase && hasNumber;
          }
     }