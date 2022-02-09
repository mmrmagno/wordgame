using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{


static void Main(string[] args)
    {
   
    Boolean repeat = true;

        while (repeat)
        {
            
                try
                {
                  
                        Console.WriteLine("Welcome to the guessing game!");
                        
                        string[] words = new string[] {"abuse", "adult", "agent", "anger", "apple", "award", "basis", "beach", "birth", "block", "blood", "board", "brain", "bread", "break", "brown", "buyer", "cause", "chain", "chair", "chest", "chief", "child", "china", "claim", "class", "clock", "coach", "coast", "court", "cover", "cream", "crime", "cross", "crowd", "crown", "cycle", "dance", "death", "depth", "doubt", "draft", "drama", "dream", "dress", "drink", "drive", "earth", "enemy", "entry", "error", "event", "faith", "fault", "field", "fight", "final", "floor", "focus", "force", "frame", "frank", "front", "fruit", "glass", "grant", "grass", "green", "group", "guide", "heart", "henry", "horse", "hotel", "house", "image", "index", "input", "issue", "japan", "jones", "judge", "knife", "laura", "layer", "level", "lewis", "light", "limit", "lunch", "major", "march", "match", "metal", "model", "money", "month", "motor", "mouth", "music", "night", "noise", "north", "novel", "nurse", "offer", "order", "other", "owner", "panel", "paper", "party", "peace", "peter", "phase", "phone", "piece", "pilot", "pitch", "place", "plane", "plant", "plate", "point", "pound", "power", "press", "price", "pride", "prize", "proof", "queen", "radio", "range", "ratio", "reply", "right", "river", "round", "route", "rugby", "scale", "scene", "scope", "score", "sense", "shape", "share", "sheep", "sheet", "shift", "shirt", "shock", "sight", "simon", "skill", "sleep", "smile", "smith", "smoke", "sound", "south", "space", "speed", "spite", "sport", "squad", "staff", "stage", "start", "state", "steam", "steel", "stock", "stone", "store", "study", "stuff", "style", "sugar", "table", "taste", "terry", "theme", "thing", "title", "total", "touch", "tower", "track", "trade", "train", "trend", "trial", "trust", "truth", "uncle", "union", "unity", "value", "video", "visit", "voice", "waste", "watch", "water", "while", "white", "whole", "woman", "world", "youth"};
                        Random random = new Random();
                        int randomWordPickPos = random.Next(0, words.Length);
                        string randomWordPick = words[randomWordPickPos];

                        
                        int i;
                        int guessNum = 8;
                        for (i = 0; i < guessNum; i++) 
                        {
                            Console.WriteLine("Guess: ");
                            string guesses = Console.ReadLine();
                            var val1 = randomWordPick;
                            var val2 = guesses;

                            var common = val1.Intersect(val2);

                            foreach (var cont in common)
                                
                                Console.WriteLine(cont);


                           if (guesses == randomWordPick)
                            {
                                break;
                            }
                        }

                        Console.WriteLine(randomWordPick);
                        repeat = false;
        
                    }
                    catch (System.Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("An error has Occurred");
                        Console.WriteLine("The error was: {0}", e.Message);
                        Console.WriteLine("Good Job, you broke it.");
                        Console.ResetColor(); 
                        repeat = true;
                    }

                }   

        }

}