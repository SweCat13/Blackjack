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
            int iSumHandOne = 0;
            int iSumhandTwo = 0; 

            Console.WriteLine("Play Black Jack\n Start the game by dealing cards? (y/n)");
            string strStartGame = Console.ReadLine();

            if (strStartGame == "y")                                //spel-loop
            {
                for (int i = 0; i < 2; i++)
                {
                    

                     iArrDealerCards[i] = prg.AssignDealerCard(rDealer, iArrDealerCards[i]); //hämtar slumpat kort och berättar vilket kort som finns för dealer
                    
                        
                    if(iArrDealerCards[i] == 11)
                    {
                        Console.WriteLine("Knekt");
                    }
                    else if (iArrDealerCards[i] == 12)
                    {
                        Console.WriteLine("Dam");
                    }
                    else if (iArrDealerCards[i] == 13)
                    {
                        Console.WriteLine("Kung");
                    }
                    else
                    {
                        Console.WriteLine(iArrDealerCards[i]);
                    }


                    iArrPlayerCards[i] = prg.AssignPlayerCard(rDealer, iArrPlayerCards[i]); //hämtar slumpat kort och berättar vilket kort som finns för player
                       
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
                  
                    iSumHandOne = prg.CalcHands(iArrPlayerCards[i]);

                        

                    
                }

            }
        }



         
        public int AssignDealerCard(Random rand, int iCard) //slumpar fram ett random kort
        {
            iCard = rand.Next(1, 14);
            return iCard;

        }

        public int AssignPlayerCard(Random randP, int iCardP)
        {
            iCardP = randP.Next(1, 10);
            return iCardP; 
        }

        public int CalcHands(int[] iInputSum) //summerar dealer eller player hand
        {
            return 0;
        }
           

    }             
          
       
}

