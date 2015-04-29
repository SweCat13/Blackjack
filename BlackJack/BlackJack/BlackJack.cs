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
               {  
                   iArrDealerCards[i] = prg.AssignDealerCard(rDealer, iArrDealerCards[i]);
                   Console.WriteLine(iArrDealerCards[i]);

                   iArrPlayerCards[i] = prg.AssignPlayerCard(rDealer, iArrPlayerCards[i]);
                   Console.WriteLine(iArrPlayerCards[i]);
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
            iCard = rand.Next(1, 10);
            return iCard;

        }

        public int AssignPlayerCard(Random randP, int iCardP)
        {
            iCardP = randP.Next(1, 10);
            return iCardP; 
        }

         int Addition(int iPlayerCardOne, int iPlayerCardTwo)
        {
                
        }
           

        }             
          
       
    }

