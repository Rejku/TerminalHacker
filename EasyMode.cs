using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public partial class Hacker : MonoBehaviour
    {
        
        public void StartEasyMode(string input)
        {
            Terminal.ClearScreen();
            level = input;
            GameStuff.StartGame("EasyMode", level);
        }

        public void EasyPasswordCheck(string input)
        {
            string levelPassword = easyModePasswords[0];
            if (input == levelPassword)
            {
                string username = GameStuff.Greeting();
                Terminal.WriteLine("Welcome back, " + username);
                Terminal.WriteLine("You have successfully logged into the System.");
                Terminal.WriteLine("Going back to main Menu");
                GameOver();
            } else {
                Terminal.WriteLine("Wrong, Please try again!");
            }
        }
    }
}

