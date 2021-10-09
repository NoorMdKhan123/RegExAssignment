using System;

namespace RegExAssignment
{
    class Program
    {
        

        static void Main(string[] args)
        {
            bool result;
            string firstName;
            

            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter first name : ");
            firstName = Console.ReadLine();

            result = userRegistration.ValidateName(firstName);
            Console.WriteLine(result);
            

        }
    }
}
