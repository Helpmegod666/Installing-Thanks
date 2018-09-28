using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment : MonoBehaviour
{

    public int UserValue;
    public int Startervalue;

    private int dragon;
    private int player = 100;
    private int Dragonhitchance;
    private int Dragonstrike;
    private int Slash;
    private int dragonHPmultiplier;
    private int mindamage;
    private int maxdamage;
    private int HeroicSlash;

    private int Starternumber = 50;
    private int Newnumber;
    private int highscore;
    private int score = 0;
    private int Highscore;
	// Use this for initialization
	void Start ()
    {

        HeroicSlash = Random.Range(1, 20);
        dragonHPmultiplier = Random.Range(1, 11);
        mindamage = Random.Range(10, 16);
        maxdamage = Random.Range(15, 41);
        dragon = Random.Range(100, 151);

        if (dragonHPmultiplier == 1)
        {
            dragon = dragon * 2;
            print("Something even stronger than before is coming!");
        }

        print("A dragon appears in the village! Defeat the dragon with " + dragon + " Amount of HP!");
        print("Welcome to a game of H/L");
    }

    void task1()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
          
        {
            UserValue += 2;
        }
           
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            UserValue /= 2;
        }

    }

    void task2()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Startervalue += Random.Range(1, 7);
            Startervalue -= Random.Range(1, 7);
        }

       
    }

	void task3()
    {


            if (Input.GetKeyDown(KeyCode.Space))
            {
                Dragonhitchance = Random.Range(0, 2);
                Dragonstrike = Random.Range(10, 21);
                Slash = Random.Range(mindamage, maxdamage);
            if (HeroicSlash == 1)
                {
                print("You charged your attack and smited the dragon to oblivion!");
                print("Your smite dealed " + (Slash * 100) + " damage!");
                dragon = dragon - Slash * 100;
                }


                Debug.Log(string.Format("You strike at the dragon, dealing " + Slash + " amount of damage! " + "It has " + (dragon = dragon - Slash) + "HP left!"));

                if (Dragonhitchance <= 0)
                {
                    Debug.Log(string.Format("The dragon strikes! You have " + (player = player - Dragonstrike) + " HP left!"));
                }

                if (dragon <= 0)
                {
                    print("You have defeated the dragon!");
                }

                if (player <= 0)
                {
                    print("You were defeated! Game over!");
                }

            }

    }

    void task5()
    {
        Highscore = 0;

        if (Input.GetKeyDown(KeyCode.Y))
        {
            Newnumber = Random.Range(1, 101);
            if (Newnumber > Starternumber)
            {
                score = score + 1;
                print(string.Format("Congratulations you managed to guess right, your score is {0} ", score));
                Starternumber = Newnumber;
                

            }

            else if (Newnumber < Starternumber)
            {

                print(string.Format("You failed a simple task, your score was {0} ", score));
                print(string.Format("Your highscore was {0} ", Highscore));
                score = 0;
                Starternumber = 50;
            }
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Newnumber = Random.Range(1, 101);
            if (Newnumber < Starternumber)
            {
                score = score + 1;
                print(string.Format("Congratulations you managed to guess right, your score is {0} ", score));
                Starternumber = Newnumber;


            }
            
            else if (Newnumber > Starternumber)
            {
                print(string.Format("You failed a simple task, your score was {0} ", score));
                print(string.Format("Your highscore was {0} ", Highscore));
                score = 0;
                Starternumber = 50;

            }
        }

        if (Highscore < score)
        {
            Highscore = score;
        }
    }


	// Update is called once per frame
	void Update ()
    {
        task1();
        task2();
        task3();
        task5();

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log(UserValue);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            print(Startervalue);
            if (Startervalue <= 0)
            {
                print("GAME OVER!");
            }

            if (Startervalue >= 20)
            {
                print("YOU WIN!");
            }


        }



    }
}
