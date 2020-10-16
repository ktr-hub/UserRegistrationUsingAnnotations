using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationUsingAnnotations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration using annotations!");
            UserAnnotationTest userAnnotationTest = new UserAnnotationTest();
            userAnnotationTest.GetFirstName();
            userAnnotationTest.GetLastName();
            userAnnotationTest.GetEmail();
            userAnnotationTest.GetPhoneNumber();
            userAnnotationTest.GetPassword();
            userAnnotationTest.Validate();
        }
    }
}
