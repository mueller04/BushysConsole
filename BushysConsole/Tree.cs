using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushysConsole
{
    public class Tree
    {
        public int size { get; set; }
        public string Description { get; set; }
        
        public void growTree(int nuts)
        {
            
            Console.Clear();
            Console.WriteLine("\nYou Completed the Trail!");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("\nNuts collected \nthis round: " + nuts);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nTree Size: " + size);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            int j = 0;
            for (int i = nuts; i > -1; i--)
                { 
                    Console.Clear();
                    Console.WriteLine("\nNuts collected \nthis round: " + i);
                    Console.WriteLine("\nTree Size: " + (size + j));
                    System.Threading.Thread.Sleep(60);
                    j++;
                }
            size += nuts;
        }


        public void TreeImage(Tree tree)
        {
            
            Console.WriteLine("\n\n");

            if (tree.size == 3)
                {
                    
                    Console.WriteLine("                 *                  ");
                    Description = "You've got a little seedling popping out of the ground!";
                }

                if (tree.size > 3 && tree.size <= 7)
                {
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    Description = "You've got a little bud seedling popping out of the ground!";
                }


                if (tree.size > 7 && tree.size <= 9)
                {
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 ***                  ");
                    Description = "You've got a little seedling popping out of the ground!";
                }

                if (tree.size > 9 && tree.size <= 11)
                {
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 ***                  ");
                    Description = "You're young seedling is getting tall!";
                }

                if (tree.size > 11 && tree.size <= 13)
                {
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                ****                  ");
                    Description = "You're young seedling is getting tall!";
                }

                if (tree.size > 13 && tree.size <= 15)
                {
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                ****                  ");
                    Description = "You're young seedling is getting tall!";
                }


                if (tree.size > 15 && tree.size <= 17)
                {
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                ****                  ");
                    Description = "You're young seedling is getting tall!";
                }

                if (tree.size > 17 && tree.size <= 20)
                {
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                ****                  ");
                    Description = "a little bud appeared!";
                }

                if (tree.size > 20 && tree.size <= 25)
                {
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                ****                  ");
                    Description = "a little bud appeared!";
                }

                if (tree.size > 25 && tree.size <= 27)
                {
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 ***               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                ****                  ");
                    Description = "It's sprouting arms!";
                }

                if (tree.size > 27 && tree.size <= 30)
                {
                    Console.WriteLine("              *   *    *             ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 ***               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                ****                  ");
                    Description = "It's sprouting arms!";
                }

                if (tree.size > 30 && tree.size <= 35)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *    *             ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 ***               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                ****                  ");
                    Description = "It's sprouting arms!";
                }

                if (tree.size > 35 && tree.size <= 40)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *    *             ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 ***               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                ****                  ");
                    Description = "It's sprouting arms!";
                }

                if (tree.size > 40 && tree.size <= 45)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *    *             ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 ***               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                ****                  ");
                    Description = "It's getting leafier!";
                }

                if (tree.size > 45 && tree.size <= 50)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *      *           ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *    *             ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 ***               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                ****                  ");
                    Description = "It's getting leafier!";
                }

                if (tree.size > 50 && tree.size <= 55)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *      *           ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *    *             ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("         *        ***      *         ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                ****                  ");
                    Description = "It's getting leafier!";
                }

                if (tree.size > 55 && tree.size <= 60)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *      *           ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("       *       *   *    *      *       ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("         *        ***      *         ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                ****                  ");
                    Description = "It's getting leafier!";
                }

                if (tree.size > 60 && tree.size <= 65)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *      *           ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("       *       *   *    *      *       ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("         *        ***      *         ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 ***                  ");
                    Console.WriteLine("                ****                  ");
                    Description = "It's getting taller!";
                }


                if (tree.size > 65 && tree.size <= 70)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *      *           ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("       *       *   *    *      *       ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("         *        ***      *         ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 ***                  ");
                    Console.WriteLine("                ****                  ");
                    Console.WriteLine("                ****                  ");
                    Description = "It's getting taller!";
                }

                if (tree.size > 70 && tree.size <= 75)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *      *           ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("       *       *   *    *      *       ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("         *        ***      *         ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 ***                  ");
                    Console.WriteLine("                ****                  ");
                    Console.WriteLine("                *****                  ");

                    Description = "It's getting taller!";
                }

                if (tree.size > 75 && tree.size <= 80)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *      *           ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("       *       *   *    *      *       ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("         *        ***      *         ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 ***                  ");
                    Console.WriteLine("                ****                  ");
                    Console.WriteLine("                *****                  ");
                    Console.WriteLine("               ******                  ");
                    Description = "It's getting taller!";
                }

                if (tree.size > 80 && tree.size <= 85)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *      *           ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("       *       *   *    *      *       ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("         *        ***      *         ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 ***                  ");
                    Console.WriteLine("                ***                  ");
                    Console.WriteLine("                ****                  ");
                    Console.WriteLine("                *****                  ");
                    Console.WriteLine("               ******                  ");
                    Description = "It's getting taller!";
                }

                if (tree.size > 85 && tree.size <= 90)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *      *           ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("       *       *   *    *      *       ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("         *        ***      *         ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    Console.WriteLine("                 ***                  ");
                    Console.WriteLine("                ***                  ");
                    Console.WriteLine("                ****                  ");
                    Console.WriteLine("                *****                  ");
                    Console.WriteLine("               ******                  ");
                    Description = "It's getting taller!";
                }

                if (tree.size > 90 && tree.size <= 95)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *      *           ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("       *       *   *    *      *       ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("         *        ***      *         ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    Console.WriteLine("                 **                  ");
                    Console.WriteLine("                 ***                  ");
                    Console.WriteLine("                ***                  ");
                    Console.WriteLine("                ****                  ");
                    Console.WriteLine("                *****                  ");
                    Console.WriteLine("               ******                  ");
                    Description = "It's getting taller!";
                }


                if (tree.size > 95 && tree.size <= 100)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *      *           ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("      * *      *   *    *     * *       ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("         *        ***      *         ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    Console.WriteLine("                 **                  ");
                    Console.WriteLine("                 ***                  ");
                    Console.WriteLine("                ***                  ");
                    Console.WriteLine("                ****                  ");
                    Console.WriteLine("                *****                  ");
                    Console.WriteLine("               ******                  ");
                    Description = "Look at it go!";
                }

                if (tree.size > 100 && tree.size <= 110)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("         *  *     *      * *          ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("      * *      *   *    *     * *       ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("         *        ***      *         ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    Console.WriteLine("                 **                  ");
                    Console.WriteLine("                 ***                  ");
                    Console.WriteLine("                ***                  ");
                    Console.WriteLine("                ****                  ");
                    Console.WriteLine("                *****                  ");
                    Console.WriteLine("               ******                  ");
                    Description = "Look at it go!";
                }

                if (tree.size > 110 && tree.size <= 120)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("         *  *     *      * *          ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("      * *      *   *    *     * *       ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("   *     *        ***      *    *     ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    Console.WriteLine("                 **                  ");
                    Console.WriteLine("                 ***                  ");
                    Console.WriteLine("                ***                  ");
                    Console.WriteLine("                ****                  ");
                    Console.WriteLine("                *****                  ");
                    Console.WriteLine("               ******                  ");
                    Description = "Look at it go!";
                }


                if (tree.size > 120 && tree.size <= 130)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("       * *  *     *      * * *         ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("      * *      *   *    *     * *       ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("   *     *        ***      *    *     ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    Console.WriteLine("                 **                  ");
                    Console.WriteLine("                 ***                  ");
                    Console.WriteLine("                ***                  ");
                    Console.WriteLine("                ****                  ");
                    Console.WriteLine("                *****                  ");
                    Console.WriteLine("               ******                  ");
                    Description = "Look at it go!";
                }

                if (tree.size > 130)
                {
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                  *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("       * *  *     *      * * *         ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("      * *      *   *    *     * *       ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("   *     *        ***      *    *     ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("            *     *     *            ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("              *   *  *               ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                 ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 *                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("                 **                  ");
                    Console.WriteLine("                 **                  ");
                    Console.WriteLine("                 ***                  ");
                    Console.WriteLine("                ***                  ");
                    Console.WriteLine("                ****                  ");
                    Console.WriteLine("                *****                  ");
                    Console.WriteLine("               ******                  ");
                    Description = "It's fully mature!";
                }


            Console.WriteLine("\n\n" + Description);
            System.Threading.Thread.Sleep(3000);
        }
    }
}
