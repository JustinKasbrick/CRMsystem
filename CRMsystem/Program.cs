using System;

namespace CRMsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var justin = new User(1, "justink@iqmetrix.com", UserType.Employee);
            var controller = new UserController();

            controller.ChangeEmail(1, "justinkasbrick@gmail.com");


            Console.WriteLine($"Your email has been updated to {justin.Email}");
            Console.ReadLine();
        }
    }
}
