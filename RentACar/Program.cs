using System;

namespace RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Admin superuser = new Admin();
            superuser.name = "schäppi";
            superuser.password = "passwort1";
            superuser.IsLoggedIn = false;
        }
    }
}
