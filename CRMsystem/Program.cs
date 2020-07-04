using System;

namespace CRMsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var justin = new User();
            justin.ChangeEmail(1, "JustinKasbrick@gmail.com");


            Console.WriteLine($"Your email has been updated to {justin.Email}");
            Console.ReadLine();
        }
    }
}
