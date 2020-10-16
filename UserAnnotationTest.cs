using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistrationUsingAnnotations
{
    class UserAnnotationTest
    {
        User user = new User();

        public void Validate()
        {
            ValidationContext context = new ValidationContext(user, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(user, context, results, true);
            if (!valid)
            {
                foreach(ValidationResult validationResult in results)
                {
                    Console.WriteLine("{0}", validationResult.ErrorMessage);
                }
            }
        }
        public void GetFirstName()
        {
            Console.Write("Enter First Name : ");
            user.firstName = Console.ReadLine();
        }

        public void GetLastName()
        {
            Console.Write("Enter Last Name : ");
            user.lastName = Console.ReadLine();
        }

        public void GetEmail()
        {
            Console.Write("Enter Email : ");
            user.email = Console.ReadLine();
        }

        public void GetPhoneNumber()
        {
            Console.Write("Enter Phone No : ");
            user.phoneNumber = Console.ReadLine();
        }

        public void GetPassword()
        {
            Console.Write("Enter Password : ");
            user.password = Console.ReadLine();
        }

    }
}
