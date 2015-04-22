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
            Console.WriteLine("Play Black Jack");
            Console.WriteLine("Start the game by dealing cards? (y/n)");
            string strStartGame = Console.ReadLine();

           
                int[] iArrDealerCards = new int[10];
                int[] iArrplayerCards = new int[10];
                if (strStartGame == "y")
                {
                    for (int i = 0; i < 1; i++)
                    {
                        Random rDealer = new Random();
                        int iRandomDCard = rDealer.Next(1, 10);
                        Console.WriteLine(iRandomDCard);

                        iArrDealerCards[i] = iRandomDCard;

                        Random rPlayer = new Random();
                        int iRandomPCard = rPlayer.Next(1, 10);
                        Console.WriteLine(iRandomPCard);

                        iArrplayerCards[i] = iRandomPCard;
                    }
                }




            

            

        }
    }
}
