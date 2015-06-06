using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushysConsole
{
    public static class Actions
    {
        static int choicestring;
            

        public static void GameMenu()
        {
            
            Console.WriteLine("\nWelcome to Bushy's");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();    
  
            while (choicestring != 1)
            {
                Console.WriteLine("\n1) Play Game \n\n2) How to Play");
                int.TryParse(Console.ReadLine(), out choicestring);
            
                switch (choicestring)
                {
                    case 1:
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("\nHow to play the game");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();

                        Console.WriteLine("\nChoose whether to walk the trail in search of nuts, or try to find friendly \nanimals who might be able to heal you if you are not feeling too well...");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("\n\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();

                         Console.WriteLine("\nWhether you choose to walk or check for friends, it will cost you one move.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("\n\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();


                        Console.WriteLine("\nWatch out, if you eat a poisonous berry you may get sick.  This will affect your speed, meaning it will take more moves to complete the trail.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("\n\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("\nIf you run out of moves before you collect the required amount of nuts, you can retry the trail.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("\n\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("\nTry to collect as many nuts as possible to grow your tree big and strong!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("\n\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        break;
                }


            }


           
        }


        public static void Walk(Bushy bushy, Trail trail)
        {
            Random random = new Random();     
            int randomNumber = random.Next(0, 100);

            // 50 percent chance you earn just 1 nut
            if (randomNumber > 50)
            {
                Console.WriteLine("\nYou got a nut\n");
                bushy.nuts += 1;
            }
            // 50 percent chance you get the opportunity to attempt to earn 3 nuts or pass, consequence could lose 1 health
            else
            {
                EatStrangeNut(bushy);
            }
            trail.moves -= bushy.health;
            NextRoundKeyPress(true);
        }


        private static void EatStrangeNut(Bushy bushy)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            int choicestring = 0;
            do
            {
                Console.WriteLine("\nYou came accross a different kind of nut, do you risk eating it? \n\n1) Risk it \n\n2) Skip it\n");
                
                int.TryParse(Console.ReadLine(), out choicestring);
                if (choicestring < 1 || choicestring > 2)
                {
                    Console.Clear();
                    Console.WriteLine("\nEnter a 1 or 2 to make your selection!");
                }
            }
            while (choicestring < 1 || choicestring > 2);

            //switch - case 1 risk eating, case 2 put nut back.
            switch (choicestring)
            {
                case 1:
                    randomNumber = random.Next(0, 100);
                    if (randomNumber > 50)
                    {
                        Console.WriteLine("\nYou discovered 3 nuts!\n");
                        bushy.nuts += 3;
                    }
                    else
                    {
                        Console.WriteLine("\nThat wasn't a nut! You ate a poisonous berry!  You're not feeling too well...\n");
                        bushy.health++;
                    }
                    break;

                case 2:
                    Console.WriteLine("\nYou put the nut back where you found it.\n");
                    break;

                default:
                    break;
            }
        }


        public static void DisplayStatus(Trail trail, Bushy bushy)
        {
            Console.WriteLine("\nTrail Number " + trail.trailNumber);

            Console.WriteLine("\n\nMoves Left: " + trail.moves + " * Nuts: " + bushy.nuts + " * Health: " + bushy.GetHealth() + "\n\n===================================================");
        }


        public static void checkFriends(Bushy bushy)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            Console.WriteLine("You check under a rock, hoping to find a furry friend.\n");
            string animal = "";


            if (randomNumber < 10)
            {
                animal = "some friendly Chipmunks! After eating, you feel \na little better!";
                Heal(bushy);
            }
            else if (randomNumber >= 10 && randomNumber < 20)
            {
                animal = "some friendly Prairie Dogs!  After eating, you feel \na little better!";
                Heal(bushy);
            }
            else if (randomNumber >= 20 && randomNumber < 30)
            {
                animal = "some friendly Ground Squirrels!  They give you a mushroom.  \nAfter eating, you feel a little better!";
                Heal(bushy);
            }
            else if (randomNumber >= 30 && randomNumber < 40)
            {
                animal = "a friendly Frog!  He gives you a mushroom.  After eating, you feel a little better!";
                Heal(bushy);
            }
            else if (randomNumber >= 40 && randomNumber < 50)
            {
                animal = "a friendly Bear!  He gives you a mushroom.  After eating, you feel a little better!";
                Heal(bushy);
            }
            else if (randomNumber >= 50 && randomNumber < 60)
            {
                animal = "a Rattlesnake! You run away";
            }
            else if (randomNumber >= 60 && randomNumber < 70)
            {
                animal = "a Coyote! You run away";
            }
            else if (randomNumber >= 70 && randomNumber < 80)
            {
                animal = "a Hawk! You run away";
            }
            else if (randomNumber >= 80 && randomNumber < 90)
            {
                animal = "an Eagle! You run away";
            }
            else if (randomNumber >= 90)
            {
                animal = "a Wolverine! You run away";
            }
            Console.WriteLine("You come accross " + animal);
        }


        public static void Heal(Bushy bushy)
        {
            if (bushy.health > 1) bushy.health--;
        }


        public static void NextRoundKeyPress(bool next)
        {
            string roundortrail;
            if (next == true)
            {
                roundortrail = "round";
            } else
            {
                roundortrail = "trail";
            }

            Console.WriteLine("\nPress any key to begin the next " + roundortrail +".");
            Console.ReadKey();
            Console.Clear();
        }


        public static void trailSummary(Trail trail)
        {
            Console.WriteLine("\nTrail " + trail.trailNumber + "\n\nMoves available: " + trail.moves + "\n\nNuts Required: " + trail.nutsRequired);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nBeginning...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }

    }
}