using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushysConsole
{
    

    public class Trail
    {
        public int trailNumber { get; set; }
        public int moves { get; set; }
        public int nutsRequired { get; set; }
        public bool quitFlag { get; set; }

        

        public Trail()
        {
            trailNumber = 0;
            moves = 0;
            nutsRequired = 0;
            quitFlag = false;
        }
        
        //create a new level
        public void newLevel()  
        {
            trailNumber++;
            moves = allocateMoves(trailNumber);
            nutsRequired = allocateNutsRequired(trailNumber);
        }


        public int allocateMoves(int trailnum)
        {
            float newmoves = trailnum + 4 + (trailnum * (float).2);
            double calculated = Math.Ceiling(newmoves);
            return (int)calculated;
        }


        public int allocateNutsRequired(int trailnum)
        {
            float newnuts = trailnum + 1 + (trailnum * (float).2);
            double calculated = Math.Ceiling(newnuts);
            return (int)calculated;
        }


        public void NutsRemaining(Trail trail, Bushy bushy)
        {
            Console.Clear();

            if (bushy.nuts >= trail.nutsRequired)
            {
                Console.WriteLine("You already have enough nuts to clear the trail!");
            } else
            {
                Console.WriteLine("Nuts remaining \nto complete trail: " + (trail.nutsRequired - bushy.nuts));
            }
            
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nReturning...");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }


    }
}
