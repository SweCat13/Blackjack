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
            int iSumHandTwo = 0; 
            bool bPlayerBust = false;
            bool bDealerBust = false;

            string strPlayersName = string.Empty;

            Console.WriteLine("Enter Name ");
            strPlayersName = Console.ReadLine();
            Console.Clear();
            prg.PlayersNamn(strPlayersName);
            
            
            


            Console.WriteLine("Play Black Jack\n Start the game by dealing cards? (y/n)");
            string strStartGame = Console.ReadLine();

            if (strStartGame == "y")                                //spel-loop
            Console.Clear();


            {
                for (int i = 0; i < 2 ; i++) // int i = 0; i < CardsOnHand; i++ if (arriHand[i] >= 11) {GetCardName(Hand[i]);}
                {
                    
                     iArrDealerCards[i] = prg.AssignCard(rDealer, iArrDealerCards[i]); //anropar metod för att slumpa kort och berättar vilket kort som finns för dealer
                     prg.GetCardName(iArrDealerCards[i]);
                        

                    iArrPlayerCards[i] = prg.AssignPlayerCard(rDealer, iArrPlayerCards[i]); //anropar metod för att slumpa kort och berättar vilket kort som finns för player
                    prg.GetCardName(iArrPlayerCards[i]);
                  
                    
                }


                iSumHandOne = prg.CalcHand(iArrDealerCards);  //Andropar metoden för att sumera dealerns hand
                Console.WriteLine("Dealer sum: " + iSumHandOne);

                iSumHandTwo = prg.CalcHand(iArrPlayerCards);   //Andropar metoden för att sumera players hand
                Console.WriteLine("Player sum: " + iSumHandTwo);

                bDealerBust = prg.IsBusted(iSumHandOne);
                Console.WriteLine(bDealerBust);

                bPlayerBust = prg.IsBusted(iSumHandTwo);
                Console.WriteLine(bPlayerBust);

                while (!bDealerBust || !bPlayerBust)
                {
                    if (bDealerBust == true || bPlayerBust == true)
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Hit or stand? (1, 2)");

                        int iAnswer = 0;
                        iAnswer = int.Parse(Console.ReadLine());

                        if (iAnswer == 1)
                        {
                            prg.AddNewCard(rPlayer, iArrPlayerCards);
                            foreach (int i in iArrPlayerCards)
                            {
                                for (int j = 0; j < iArrPlayerCards.Length; j++)
                                {
                                    if (iArrPlayerCards[j] >= 11) 
                                    { 
                                        prg.GetCardName(iArrPlayerCards[j]); 
                                    }
                                }
                                Console.WriteLine(i);
                                iSumHandTwo = 0;
                                iSumHandTwo = prg.CalcHand(iArrPlayerCards);
                            }

                            Console.WriteLine("Player sum: " + iSumHandTwo);
                        }

                        else
                        {
                            Console.WriteLine("Nope");
                            break;
                        }

                    }
                }

                
            }
        }



         
        public int AssignDealerCard(Random rand, int iCard) //slumpar fram ett random kort för dealer
        {
            iCard = rand.Next(2, 14);
            return iCard;

        }

        public int[] AddNewCard(Random rand, int[] arriHand)
        {
            Program prg = new Program();

            for (int i = 0; i < arriHand.Length - 1; i++ )
            {
                if (arriHand[i] == 0)
                {
                    arriHand[i] = prg.AssignPlayerCard(rand, arriHand[i]);
                    break;
                }
            }


            return arriHand;
        }

        public int AssignPlayerCard(Random randP, int iCardP) //slumpar fram ett random kort för player
        {
            iCardP = randP.Next(2, 14);
            return iCardP; 
        }

        public int AssignCard(Random rand, int iCard)
        {
            iCard = rand.Next(2, 14);
            return iCard;
        }

        int iSumOne = 0;
        public int CalcHand(int[] iInputSum) //sumerar dealer eller player hand
        {
            iSumOne = 0;
            for (int i = 0; i < 2; i++)
            {
                if (iInputSum[i] > 10 && iInputSum[i] < 14)               //beräknar alla tal över tio och under 14 som tio 
                {
                    iInputSum[i] = 10;
                }
                else if (iInputSum[i] == 14)                              //beräknar alla ess som 11
                {
                    iSumOne = 11;
                }

                iSumOne = iSumOne + iInputSum[i];
            }
            return iSumOne;
 
            }

        public bool IsBusted(int iInputHand)
        {
            if (iInputHand < 21)
            {
                return false;
            }

            else if (iInputHand == 21)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        void PlayersNamn(string strName) //Namn på playern
        {
            Console.WriteLine("Hello, " + strName + "\n---------------------");
        }

        public string GetCardName(int iArrCards)
        {
           int iCardVal = iArrCards;

           switch (iCardVal)
           {
               case 11:
                 return "Knekt";
                 break;

               case 12:
                return "Dam";
                break;

               case 13:
                return "Kung";
                break;

               case 14:
                return "Ess";
                break;
                            
           }

           return "";
         }
                  
    }             
          
       
}

