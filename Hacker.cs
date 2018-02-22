using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public partial class Hacker
    {

        //Game configuration data
        string[] easyModePasswords = { "easy", "einfach", "really?", "maybe", "lulz" };
        string[] mediumModePasswords = { "medium", "mittel", "really!", "definite", "rofl" };

        //Game State
        GameStuff.Screen currentScreen = GameStuff.Screen.MainMenu;
        public static string level;

        // Use this for initialization
        public void Start()
        {
            string username = GameStuff.Greeting();
            Terminal.WriteLine(username);
            MainMenu.ShowMainMenu();
        }

        void OnUserInput(string input)
        {
            switch (input)
            {
                case "menu":
                    currentScreen = GameStuff.Screen.MainMenu;
                    MainMenu.ShowMainMenu();
                    break;
                case "exit;":
                    Application.Quit();
                    break;
                default:
                    if (currentScreen == GameStuff.Screen.MainMenu)
                        RunMainMenu(input);
                    else if (currentScreen == GameStuff.Screen.PasswordEasy)
                    {
                        EasyPasswordCheck(input);
                    }
                    else if (currentScreen == GameStuff.Screen.PasswordMedium)
                    {
                        MediumPasswordCheck(input);
                    }
                    else if (currentScreen == GameStuff.Screen.Win)
                    {
                        currentScreen = GameStuff.Screen.MainMenu;
                        MainMenu.ShowMainMenu("Congratulation, you have won! Select new level");
                    }
                    break;
            }
        }

        private void RunMainMenu(string input)
        {
            switch (input)
            {
                case "1": // TODO handle differently depending on Screen
                    currentScreen = GameStuff.Screen.PasswordEasy;
                    StartEasyMode(input);
                    break;
                case "2":
                    currentScreen = GameStuff.Screen.PasswordMedium;
                    StartMediumMode(input);
                    break;
                case "007":
                    Terminal.ClearScreen();
                    MainMenu.ShowMainMenu();
                    Terminal.WriteLine("Good try Mr. Bond, but pleae choose correct Level");
                    break;
                case "42":
                    Terminal.ClearScreen();
                    MainMenu.ShowMainMenu();
                    Terminal.WriteLine("Even if its the answer to everything, it will lead you nowhere here.. My Bad.");
                    break;
                default:
                    Terminal.ClearScreen();
                    MainMenu.ShowMainMenu();
                    Terminal.WriteLine("Choose a correct level!!!!");
                    break;
            }

        }

        public void GameOver()
        {
            currentScreen = GameStuff.Screen.Win;
        }
    }
}
