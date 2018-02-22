using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    class MainMenu
    {
        public static void ShowMainMenu()
        {
            Terminal.WriteLine("What do you want to hack into?");
            Terminal.WriteLine("Press 1 for the local library.");
            Terminal.WriteLine("Press 2 for the police station.");
            Terminal.WriteLine("Enter your selection:");
        }

        public static void ShowMainMenu(string message)
        {
            Terminal.ClearScreen();
            Terminal.WriteLine(message);
            Terminal.WriteLine("What do you want to hack into?");
            Terminal.WriteLine("Press 1 for the local library.");
            Terminal.WriteLine("Press 2 for the police station.");
            Terminal.WriteLine("Enter your selection:");
        }

    }

    class GameStuff
    {
        public enum Screen { MainMenu, PasswordEasy, PasswordMedium, Win };
        
        public static void StartGame(string chosen, string level)
        {
            
            Terminal.WriteLine("You have chosen: " + chosen + " ( Menu: " + level + ")");
            Terminal.WriteLine("Please enter your password: ");
        }

        public static string Greeting()
        {
            string userName = "Bushty";
            return userName;
        }
        
        


    }

}
