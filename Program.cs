using System;

namespace RegExAssignment
{
    class Program
    {
        

        static void Main(string[] args)
        {
            bool result;
            string userName;
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter first name : ");
            userName = Console.ReadLine();

            result = userRegistration.ValidateName(userName);
            Console.WriteLine(result);

        }
    }
}
