﻿using Labb_6___Console_Adventure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___Console_Adventure.Classes
{
    class Room : IEnvironment
    {
        public List<INonPlayerCharacter> nonPlayerCharacters { get; set; }

        //Konstruktor för hur en instans av Room ska se ut.
        public Room()
        {
            //Gör en lista av NPC och tilldelar värden till deras properties
            nonPlayerCharacters = new List<INonPlayerCharacter>()
            {
                new Human { Name = "Mss.Fairfax",
                            Response = "Well, off you go!",
                            QuestDialogue = "Say, would you do an' old woman a favour?\nMe name's Greta Fairfax and I live with me good-for-nothing son, Eric.\nHe's out there in the yard tryin' to get me cat, Mr.Nibbles, down from the tree in me garden.\nMr.Nibbles' been stuck up there all day and won't come down!\nWould you please help me?\nGo talk to Eric and see what you can do!",
                            Appearance = "an old woman" }
            };
        }

        public string AreaName()
        {
            return "Mss.Fairfax's living room";
        }

        //Metod som tar reda på vilka npcs det finns i "rummet" genom en foreach-loop
        //och sedan skriver ut det i Console.WriteLine
        public void Observe()
        {
            Console.WriteLine("The area contains: ");
            foreach (var nonPlayerCharacter in nonPlayerCharacters)
            {
                Console.WriteLine("{0}", nonPlayerCharacter.Appearance);
            }
        }

        public void Interact()
        {
            //For-loop för att skriva ut och ge alla objekt i listan ett nummer.
            for (int i = 1; i <= nonPlayerCharacters.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, nonPlayerCharacters[i - 1].Appearance);
            }

            Console.WriteLine("Choose object: ");
            int index = int.Parse(Console.ReadLine());

            if (QuestManager.isQuestStarted == false)
            {
                //Anropar properties från npcs och ser till att indexen blir detsamma som positionerna i for-loopen
                Console.WriteLine("{0}: {1}", nonPlayerCharacters[index - 1].Name, nonPlayerCharacters[index - 1].QuestDialogue);
                QuestManager.isQuestStarted = true;
            }

            else if (QuestManager.isQuestStarted == true && QuestManager.isLadderTaken == true)
            {
                //Anropar questproperties från npcs ifall questet har börjat
                Console.WriteLine("{0}: Oh you found a ladder! Splendid! Just splendid!", nonPlayerCharacters[index - 1].Name);
                QuestManager.QuestEnd();
            }

            else
            {
                Console.WriteLine("{0}: {1}", nonPlayerCharacters[index - 1].Name, nonPlayerCharacters[index - 1].Response);
            }
        }

        public void EnterRoom()
        {
            //put a while and switch here to decide which actions you want to do inside the room
            bool GameLoop = true;

            while (GameLoop)
            {
                Menus.ActionMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Observe();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Interact();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        GameLoop = false;
                        break;
                }
            }
        }
    }
}
