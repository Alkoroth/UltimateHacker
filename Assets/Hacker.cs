using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game configuration data
    string[] level1Passwords = { "Press", "Media", "Internet" };
    string[] level2Passwords = { "Missiles", "Boarder", "Deployment" };
    string[] level3Passwords = { "Stock Market", "Trade Sanction", "Natural Resources" };
    //Game state
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen = Screen.MainMenu;
    string password;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu("Huss");
    }

    // Update is called once per frame
    void MainMenu(string name)
    {
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine($"Hello Agent {name}, Welcome To Hacker!");
        Terminal.WriteLine("You have been recruited by Emperor");  //You have been recruited by Emperor Ysgramor to destroy Earth. He has decided that Earth is not worth the an invasion and therefore, has decided to have you destroy it from the indide out.")
        Terminal.WriteLine("Ysgramor to destroy Earth.");
        Terminal.WriteLine("He has decided that Earth is not");
        Terminal.WriteLine("worth an invasion and therefore,");
        Terminal.WriteLine("has decided to have you destroy it");
        Terminal.WriteLine("from the indide out.");
        Terminal.WriteLine("Press 1 to hack the society");
        Terminal.WriteLine("Press 2 to hack the military");
        Terminal.WriteLine("Press 3 to hack the economy");
        Terminal.WriteLine("What part of mankind shall be the");
        Terminal.WriteLine("first victim of your wrath!?:");
    }
    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            MainMenu("Welcome Back Agent Ali!");
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }


    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }

        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
    }


    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have selected level: " + level);
        switch (level)
        {
            case 1:
                print(password);
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                print(password);
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                print(password);
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            default:
                print("Obey your orders, or face the consequences!");
                break;
        }
        Terminal.WriteLine("Prove yourself to the Empire! " + password.Anagram());
    }


    // Update is called once per frame
    void Update()
    {

    }
    void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            Terminal.WriteLine("You dare fail the Emperor!?");
            Terminal.WriteLine("Type menu to change to another level.");
        }
    }
        void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        ShowRewardScreen();
    }
        void ShowRewardScreen()
    {
        Terminal.WriteLine("Victory!!!");
    }
}