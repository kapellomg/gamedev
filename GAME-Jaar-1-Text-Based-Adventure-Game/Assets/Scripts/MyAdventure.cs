using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{

    private enum States
    {
        start,
        intro,
        intro2,
        bullrun,
        easteregg,
        koop,
        verkoop,
        verkoop2

    }

    private States currentState = States.start;



    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnUserInput(string input)
    {
        if (currentState == States.start)
        {
            if (input == "start")
                Intro();
            else
            {
                Terminal.WriteLine("Dit is een ongeldige input");
            }
        }
        else if (currentState == States.intro)
        {
            if (input == "koop")
            {
                Intro2();
            }
            else if (currentState == States.intro)
            {
                if (input == "verkoop")
                {
                    Verkoop();
                }
            }
            else
            {
                Terminal.WriteLine("Dit is een ongeldige input");
            }

        }
        else if (currentState == States.intro2)
        {
            if (input == "koop")
            {
                Koop();
            }
            else if (currentState == States.intro2)
            {
                if (input == "verkoop")
                {
                    Verkoop2();
                }
            }
        }
        else if (currentState == States.intro)
        {
            if (input == "verkoop")
            {
                Verkoop();
            }
        }

      
    }




    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom in de ultieme text adventure game gebaseerd op /r/wallstreetbets");
        Terminal.WriteLine("Type start om verder te gaan");

    }

    void Intro()
    {
        currentState = States.intro;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je bent aan het investeren in DogeCoin en ziet dat de prijs met 40% gedaalt is");
        Terminal.WriteLine("Stop je er nog meer geld in of verkoop je alle dogecoins en geef je het op? Type Koop of Verkoop om verder te gaan");
    }
    void Intro2()
    {
        currentState = States.intro2;
        Terminal.WriteLine("De prijs daalt nog eens met 50% Wat doe je nu?");

    }

    void Koop()
    {
        currentState = States.koop;
        Terminal.WriteLine("Je koopt meer dogecoin en hebt er nu 2.2 miljoen en wacht af tot de prijs weer stijgt");
        Terminal.WriteLine("De prijs stijgt met 6000% Je investering van 5000 euro is nu 300000 euro waard! Gefeliciteerd, je bent nu een baller");
        Terminal.WriteLine("Game Over.");

    }
    void Verkoop()
    {
        currentState = States.verkoop;
        Terminal.WriteLine("Je hebt je Dogecoin verkocht met 80% verlies");
        Terminal.WriteLine("De prijs stijgt met 6000% Je investering van 2000 euro zou nu 1.2 ton waard zijn. Gefeliciteerd, you got played.");
        Terminal.WriteLine("Game Over. Buy low sell high");

    }
    void Verkoop2()
    {
        currentState = States.verkoop2;
        Terminal.WriteLine("Je kiest ervoor om toch maar te verkopen");
        Terminal.WriteLine("De prijs stijgt met 6000% Je investering van 5000 euro zou nu 3 ton waard zijn. Gefeliciteerd, you got played.");
        Terminal.WriteLine("Game Over. Buy low sell high");

    }
}   
