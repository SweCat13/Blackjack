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
            int iBustD = 0;
            int iBustP = 0;
            bool bPlayerBust = false;
            bool bDealerBust = false;
            int iCon = 0;

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
                for (int i = 0; i < 2 ; i++)
                {
                    
                     iArrDealerCards[i] = prg.AssignDealerCard(rDealer, iArrDealerCards[i]); //anropar metod för att slumpa kort och berättar vilket kort som finns för dealer
                    
                        
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
                    else if (iArrDealerCards[i] == 14)
                    {
                        Console.WriteLine("Ess");
                    }
                    else
                    {
                        Console.WriteLine(iArrDealerCards[i]);
                    }

                    iArrPlayerCards[i] = prg.AssignPlayerCard(rDealer, iArrPlayerCards[i]); //anropar metod för att slumpa kort och berättar vilket kort som finns för player

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
                    else if (iArrPlayerCards[i] == 14)
                    {
                        Console.WriteLine("Ess");
                    }
                    else
                    {
                        Console.WriteLine(iArrPlayerCards[i]);
                    }
                  
                    
                }


                    iSumHandOne = prg.CalcDhand(iArrDealerCards);  //Andropar metoden för att sumera dealerns hand
                Console.WriteLine("Dealer sum: " + iSumHandOne);

                iSumHandTwo = prg.CalcPhand(iArrPlayerCards);   //Andropar metoden för att sumera players hand
                Console.WriteLine("Player sum: " + iSumHandTwo);

                bDealerBust = prg.IsBusted(iSumHandOne);
                Console.WriteLine(iBustD);

                bPlayerBust = prg.IsBusted(iSumHandTwo);
                Console.WriteLine(iBustP);

                if (bDealerBust == true || bPlayerBust == true)
                {
                    // Metod som kollar player mot dealer om bust
                }
                else if (iBustD == 3)
                {
                    iCon = prg.Continue(iBustD, iBustP, iSumHandOne, iSumHandTwo);
                    
                    if (iCon == 1)
                    {
                        int iNumerFor = 3; 
                        for (int i = iNumerFor; i < iNumerFor++; i++)
                        {

                            iArrDealerCards[i] = prg.AssignDealerCard(rDealer, iArrDealerCards[i]);   //fastnat!!!!!!!!!!!!


                            if (iArrDealerCards[i] == 11)
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
                            else if (iArrDealerCards[i] == 14)
                            {
                                Console.WriteLine("Ess");
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


            return arriHand;
        }

        public int AssignPlayerCard(Random randP, int iCardP) //slumpar fram ett random kort för player
        {
            iCardP = randP.Next(2, 14);
            return iCardP; 
        }

        int iSumOne = 0;
        public int CalcDhand(int[] iInputSum) //sumerar dealer eller player hand
        {
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

            int iSumTwo = 0; 
        public int CalcPhand(int[] iInputSum) //sumerar dealer eller player hand
        {
            for (int i = 0; i < 2; i++)
            {
                if (iInputSum[i] > 10 && iInputSum[i] < 14)               //beräknar alla tal över tio och under 14 som tio 
                {
                    iInputSum[i] = 10;
                }
                else if (iInputSum[i] == 14)                              //beräknar alla ess som 11
                {
                    iSumTwo = 11;
                }

                iSumTwo = iSumTwo + iInputSum[i];
            }
            return iSumTwo; 
            }

        public bool IsBusted(int iInputHand)
        {
            if (iInputHand > 21)
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

        public void BustedOrNot (int iBustedD, int iBustedP, int SummanAvKortD, int SummanAvKortP) //Kollar om man är busted eller om man har black jack
        {
            if (iBustedD == 0)
            {
                Console.WriteLine("Player win ");
            }
            else if (iBustedP == 0)
            {
                Console.WriteLine("Dealer win!");
            }
            else if (iBustedD == 0 && iBustedP == 0)
            {
                Console.WriteLine("No one wins! It is a draw");
            }
            else if (iBustedD == 1 && SummanAvKortD > SummanAvKortP)
            {
                Console.WriteLine("Dealer Win!");
            }
            else if(iBustedD == 1 && SummanAvKortD < SummanAvKortP)
            {
                Console.WriteLine("Player Win!");
            }
            else if(iBustedD == 2)
            {
                Console.WriteLine("Black Jack, Dealer win");
            }
            else if (iBustedP == 2)
            {
                Console.WriteLine("Black Jack, Player win");
            }
        }

        int iContinue = 1;
        string Answer;
        public int Continue(int iContinueD, int iContinueP, int SummanAvKortD, int SummanAvKortp)
        { 
            if(iContinueD == 3)
            {
                return iContinue;
            }
            else if(iContinueP == 3)
            {
                Console.WriteLine("Do you want a new card?");
                Answer = Console.ReadLine();

                if (Answer == "yes")
                {
                    iContinue = 2;
                    return iContinue;
                }
                else if (Answer == "no")
                {
                    iContinue = 3;
                    return iContinue;
                }
                else
                {
                    return iContinue;
                }
             }
                else 
                {
                    return iContinue;
                }

        }
    }             
          
       
}

