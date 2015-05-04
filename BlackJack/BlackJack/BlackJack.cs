using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rPlayer = new Random();
            Random rDealer = new Random();
            int[] iArrDealerCards = new int[10];
            int[] iArrPlayerCards = new int[10];
            Program prg = new Program();

            Console.WriteLine("Play Black Jack\n Start the game by dealing cards? (y/n)");
            string strStartGame = Console.ReadLine();

            if (strStartGame == "y")                                //spel-loop
            {
               for (int i = 0; i < 2; i++)
<<<<<<< HEAD
               {


=======
               {  
>>>>>>> origin/master
                   iArrDealerCards[i] = prg.AssignDealerCard(rDealer, iArrDealerCards[i]);
                   Console.WriteLine(iArrDealerCards[i]);
                   

                   iArrPlayerCards[i] = prg.AssignPlayerCard(rDealer, iArrPlayerCards[i]);
<<<<<<< HEAD
                   if (iArrPlayerCards[i] == 11)
                   {
                       Console.WriteLine("Knekt");
                   }

                   else if (iArrPlayerCards[i] == 12)
                   {
                       Console.WriteLine("Dam");
                   }
                   else if (iArrPlayerCards[i] == 13)
                   {
                       Console.WriteLine("Kung");
                   }
                   else
                   {
                       Console.WriteLine(iArrPlayerCards[i]);
                   }

=======
                   Console.WriteLine(iArrPlayerCards[i]);
>>>>>>> origin/master
               }
            }

            int siffra = 0;
            for (int r = 0; r < iArrPlayerCards.Length; r++ ) 
            {
                siffra = iArrDealerCards[r] + siffra; 
            }
        }



        public int AssignDealerCard(Random rand, int iCard)
        {
            iCard = rand.Next(1, 14);
            return iCard;

        }

        public int AssignPlayerCard(Random randP, int iCardP)
        {
            iCardP = randP.Next(1, 10);
            return iCardP; 
        }
<<<<<<< HEAD
=======

         int Addition(int iPlayerCardOne, int iPlayerCardTwo)
        {
                
        }
>>>>>>> origin/master
           

        }             
          
       
    }

