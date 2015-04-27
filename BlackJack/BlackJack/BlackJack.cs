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
            int iRandomDCard = 0;
            int iRandomPCard = 0;
            int[] iArrDealerCards = new int[10];
            int[] iArrplayerCards = new int[10];
            Program prg = new Program();

            Console.WriteLine("Play Black Jack");
            Console.WriteLine("Start the game by dealing cards? (y/n)");
            string strStartGame = Console.ReadLine();

            if (strStartGame == "y")                                //spel-loop
            {
            
               for (int i = 0; i < 2; i++)
               {
                   
                   iRandomDCard = rDealer.Next(1, 10);
                   iArrDealerCards[i] = prg.AssignDealerCard(rDealer, iArrDealerCards[i]);
                   Console.WriteLine(iArrDealerCards[i]);

                   
                   iRandomPCard = rPlayer.Next(1, 10);

                   iArrplayerCards[i] = iRandomPCard;
                   Console.WriteLine(iArrplayerCards[i]);

               }
            }

            int siffra = 0;
            for (int r = 0; r < iArrplayerCards.Length; r++ )
            {
                siffra = iArrDealerCards[r] + siffra; 
            }
        }

        public int AssignDealerCard(Random rand, int iCard)
        {
            iCard = rand.Next(1, 10);
            return iCard;
        }             
          
        
    }
}
