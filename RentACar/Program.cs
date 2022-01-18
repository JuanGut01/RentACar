using System;

namespace RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rental Management";
            Admin superuser = new Admin();
            superuser.name = "schäppi";
            superuser.password = "passwort1";
            superuser.IsLoggedIn = false;
            UI.menu();
        }
    }
}
