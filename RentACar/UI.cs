using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RentACar
{
    internal class UI
    {
        public static void menu()
        {
            bool isDone = false;
            while (isDone == false )
            {
                Console.Clear();
                writeLogo();
                say("1", "Rent a Vehicle NOW!");
                say("2", "Login as Employee");
                say("3", "Exit");
                //Console.ReadKey();
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    string rentnowlogo = @"  ____            _     _   _  _____        ___ 
     |  _ \ ___ _ __ | |_  | \ | |/ _ \ \      / / |
     | |_) / _ \ '_ \| __| |  \| | | | \ \ /\ / /| |
     |  _ <  __/ | | | |_  | |\  | |_| |\ V  V / |_|
     |_| \_\___|_| |_|\__| |_| \_|\___/  \_/\_/  (_)
                                                    ";
                    Console.WriteLine(rentnowlogo, ConsoleColor.DarkMagenta);
                    // List all vehicles
                    // select vehicle regarding input (plate id)
                }
                else if (option == 2)
                {
                    string loginasemployeelogo = @"  _                _                     _____                 _                       
     | |    ___   __ _(_)_ __     __ _ ___  | ____|_ __ ___  _ __ | | ___  _   _  ___  ___ 
     | |   / _ \ / _` | | '_ \   / _` / __| |  _| | '_ ` _ \| '_ \| |/ _ \| | | |/ _ \/ _ \
     | |__| (_) | (_| | | | | | | (_| \__ \ | |___| | | | | | |_) | | (_) | |_| |  __/  __/
     |_____\___/ \__, |_|_| |_|  \__,_|___/ |_____|_| |_| |_| .__/|_|\___/ \__, |\___|\___|
                 |___/                                      |_|            |___/           ";
                    Console.WriteLine(loginasemployeelogo, ConsoleColor.DarkMagenta);
                    // Sign in Form for Admin
                    // Check credentials, if true forward Admin Area.
                }
                else if (option == 3)
                {
                    string exitlogo = @"  _____      _ _   
     | ____|_  _(_) |_ 
     |  _| \ \/ / | __|
     | |___ >  <| | |_ 
     |_____/_/\_\_|\__|
                       ";
                    Console.WriteLine(exitlogo, ConsoleColor.DarkMagenta);
                    isDone = true;
                }
                else
                {
                    string invalidoption = "Please choose a valid option.";
                    Console.WriteLine(invalidoption, ConsoleColor.Red);
                    Thread.Sleep(2000);
                }
            }
        }

        public static void say(string prefix, string message)
        {
            Console.Write("[");
            Console.Write(prefix, ConsoleColor.Magenta);
            Console.WriteLine("]" + message);
        }
        public static void writeLogo()
        {
            string logo = @"  ____            _        _   __  __                                                   _   
 |  _ \ ___ _ __ | |_ __ _| | |  \/  | __ _ _ __   __ _  __ _  ___ _ __ ___   ___ _ __ | |_ 
 | |_) / _ \ '_ \| __/ _` | | | |\/| |/ _` | '_ \ / _` |/ _` |/ _ \ '_ ` _ \ / _ \ '_ \| __|
 |  _ <  __/ | | | || (_| | | | |  | | (_| | | | | (_| | (_| |  __/ | | | | |  __/ | | | |_ 
 |_| \_\___|_| |_|\__\__,_|_| |_|  |_|\__,_|_| |_|\__,_|\__, |\___|_| |_| |_|\___|_| |_|\__|
                                                        |___/                               ";
            Console.WriteLine(logo, ConsoleColor.Magenta);
        }
    }
}
