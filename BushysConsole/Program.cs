using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushysConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //initialize the game
            int choicestring = 0;
            Trail trail = new Trail();
            Bushy bushy = new Bushy();
            Tree tree = new Tree();
            
            //play the game
            Actions.GameMenu();

            while (trail.trailNumber <= 12 && trail.quitFlag == false)
            {
                //initialize the level
                trail.newLevel();
                Actions.trailSummary(trail);

                
                while (trail.moves > 0)
                { 
                    Actions.DisplayStatus(trail, bushy);

                    do
                    {
                        Console.WriteLine("\nChoose: \n\n1) Walk Trail \n\n2) Check for Friendly Animals \n\n3) Check Nuts Remaining\n\n4) Quit \n\n***************************************************\n");
                        int.TryParse(Console.ReadLine(), out choicestring);
                        if (choicestring < 1 || choicestring > 4)
                        {
                            Console.Clear();
                            Console.WriteLine("\nEnter a 1, 2, 3, or 4 to make your selection!");
                        }
                    }
                    while (choicestring < 1 || choicestring > 4);

                    // choice 1 - walk choice 2 - checkfriend choice 3 - check nuts remaining choice 4 - quit
                    switch (choicestring)
                    {
                        case 1:
                            Actions.Walk(bushy, trail);
                            break;

                        case 2:
                            Actions.checkFriends(bushy);

                            trail.moves -= bushy.health;
                            Actions.NextRoundKeyPress(true);
                            break;

                        case 3:
                            trail.NutsRemaining(trail, bushy);
                            break;

                        case 4:
                            trail.moves = 0;
                            trail.quitFlag = true;
                            break;

                        default:
                            break;
                    }

                    //condition which completes the trail
                    if (trail.moves <= 0 && trail.nutsRequired <= bushy.nuts)
                    {

                        tree.growTree(bushy.nuts);
                        tree.TreeImage(tree);
                        Actions.NextRoundKeyPress(false);
                        bushy.nuts = 0;
                        bushy.health = 1;
                        
                    //condition where player did not complete trail, gets option to try again
                    } else if (trail.moves <= 0 && trail.quitFlag == false)
                    {
                        do
                        {
                            Console.WriteLine("\nAw Shucks, you do not have enough nuts to complete the trail. \n\n1) Try Again \n\n2) Quit");
                            int.TryParse(Console.ReadLine(), out choicestring);
                            if (choicestring < 1 || choicestring > 2)
                            {
                                Console.Clear();
                                Console.WriteLine("\nEnter a 1 or 2 to make your selection!");
                            }
                        }
                        while (choicestring < 1 || choicestring > 2);

                        switch (choicestring)
                        {
                            case 1:
                                bushy.nuts = 0;
                                bushy.health = 1;
                                trail.trailNumber--;
                                Console.Clear();
                                break;

                            //quit the game, break out of both while loops by maxing conditions
                            case 2:
                                trail.trailNumber = 3;
                                trail.quitFlag = true;
                                break;
                            default:
                                break;
                        }
                    }
                //end while loop for the trail
                }
            //End while loop for the game
                if (trail.trailNumber >= 12)
                {
                    trail.quitFlag = true;
                    Console.WriteLine("You have beaten the game!");
                }
            }
        }
    }
}


