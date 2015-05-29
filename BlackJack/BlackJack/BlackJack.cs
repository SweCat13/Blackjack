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

            if(strStartGame == "y")                                //spelsats
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

                while (!bDealerBust || !bPlayerBust) //while loop med krav att någon av playern och dealern inte är bust
                {
                    if (bPlayerBust == true)  //bryter ut ur loopen om någon är bust
                    {
                        Console.WriteLine("You loose");
                        break;
                    }
                    else if (bDealerBust == true)
                    {
                        Console.WriteLine("You win!!");
                        break;
                    }

                    else if(bDealerBust == false && bPlayerBust == false)
                    {
                        Console.WriteLine("Hit or stand? (1, 2)");           //playern kan välja att fortsätta ta kort eller stanna

                        int iAnswer = 0;
                        iAnswer = int.Parse(Console.ReadLine());

                        if (iAnswer == 1)                                  //playern tar ett till kort och playerns hand summeras igen
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
                            bPlayerBust = prg.IsBusted(iSumHandTwo);              //kollar om playern är bust
                            Console.WriteLine(bPlayerBust);
                            
                            if (iSumHandTwo == 21)                               //om playern får 21 vinner playern
                            {
                                bDealerBust = true;
                            }


                            if (iSumHandTwo > iSumHandOne && iSumHandTwo < 21)  //Dealern tar ett till kort om den har lägre kort än playern och playern inte är bust
                            {
                                prg.AddNewCard(rPlayer, iArrDealerCards);
                                foreach (int i in iArrDealerCards)
                                {
                                    for (int j = 0; j < iArrDealerCards.Length; j++)
                                    {
                                        if (iArrDealerCards[j] >= 11)
                                        {
                                            prg.GetCardName(iArrDealerCards[j]);
                                        }
                                    }
                                    Console.WriteLine(i);
                                    iSumHandOne = 0;
                                    iSumHandOne = prg.CalcHand(iArrDealerCards);
                                }

                                Console.WriteLine("Dealer sum: " + iSumHandOne);
                                bDealerBust = prg.IsBusted(iSumHandOne);          //kollar om dealern är bust
                                Console.WriteLine(bDealerBust);

                                if (iSumHandOne == 21)
                                {
                                    bPlayerBust = true;
                                }
                            }
                        }

                        else                                  //om playern väljer stand
                        {
                            Console.WriteLine("Nope");


                            if (iSumHandOne < iSumHandTwo) //dealern ska ta ett till kort om den har lägre summa än playern
                            {
                                while (iSumHandOne < iSumHandTwo)
                                {
                                    prg.AddNewCard(rPlayer, iArrDealerCards);
                                    foreach (int i in iArrDealerCards)
                                    {
                                        for (int j = 0; j < iArrDealerCards.Length; j++)
                                        {
                                            if (iArrDealerCards[j] >= 11)
                                            {
                                                prg.GetCardName(iArrDealerCards[j]);
                                            }
                                        }
                                        Console.WriteLine(i);
                                        iSumHandOne = 0;
                                        iSumHandOne = prg.CalcHand(iArrDealerCards);
                                    }

                                    bDealerBust = prg.IsBusted(iSumHandOne);  //kollar om dealern är bust
                                    Console.WriteLine(bDealerBust);

                                    Console.WriteLine("Dealer sum: " + iSumHandOne);
                                }

                                if (iSumHandOne > iSumHandTwo || iSumHandOne == iSumHandTwo)        //om ingen är bust vinner den med högst hand eller om båda har lika så vinner dealern
                                {
                                    bPlayerBust = true;
                                }

                            }
                            else                                                      //om dealern har högre kort är playern vinner dealern
                            {
                                bPlayerBust = true; 
                            }
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
            for (int i = 0; i < 10; i++)
            {
                if (iInputSum[i] > 10 && iInputSum[i] < 14)               //beräknar alla tal över tio och under 14 som tio 
                {
                    iInputSum[i] = 10;
                }

                iSumOne = iSumOne + iInputSum[i];

                if (iSumOne > 21 && iInputSum[i] == 11)                  
                {
                    iSumOne = iSumOne - 10; 
                }
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
                 

               case 12:
                return "Dam";
                

               case 13:
                return "Kung";
                

               case 14:
                return "Ess";
                
                            
           }

           return "";
         }
                  
    }             
          
       
}

