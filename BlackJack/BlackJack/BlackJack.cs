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
                for (int i = 0; i < 2; i++)
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

                iSumHandOne = prg.CalcDhand(iArrDealerCards);   //Andropar metoden för att sumera dealerns hand
                Console.WriteLine("Dealer sum: " + iSumHandOne);

                iSumHandOne = prg.CalcPhand(iArrPlayerCards);   //Andropar metoden för att sumera players hand
                Console.WriteLine("Player sum: " + iSumHandTwo);

                prg.Bust(); //Kolar om dealern är busted
            }
        }



         
        public int AssignDealerCard(Random rand, int iCard) //slumpar fram ett random kort för dealer
        {
            iCard = rand.Next(2, 14);
            return iCard;

        }

        public int AssignPlayerCard(Random randP, int iCardP) //slumpar fram ett random kort för player
        {
            iCardP = randP.Next(2, 14);
            return iCardP; 
        }

        int iSumOne = 0;
        public int CalcDhand(int[] iInputSum) //summerar dealer eller player hand
        {
            for (int i = 0; i < 2; i++)
            {
                if (iInputSum[i] > 10)               //beräknar alla tal över tio som tio hfaha
                {
                    iInputSum[i] = 10;
                }
                else if (iInputSum[i] == 14) //beräknar alla ess som 11
                {
                    iSumOne = 11;
                }

                iSumOne = iSumOne + iInputSum[i];
            }
            return iSumOne;
            }

            int iSumTwo = 0; 
        public int CalcPhand(int[] iInputSum) //summerar dealer eller player hand
        {
            for (int i = 0; i < 2; i++)
            {
                if (iInputSum[i] > 10)               //beräknar alla tal över tio som tio hfaha
                {
                    iInputSum[i] = 10;
                }
                else if (iInputSum[i] == 14) //beräknar alla ess som 11
                {
                    iSumTwo = 11;
                }

                iSumTwo = iSumTwo + iInputSum[i];
            }
            return iSumTwo; 
            }

        public void Bust()
        { 
            if (iSumOne >= 22)
            {
                Console.WriteLine("You're Busted, End of the game");
            }
        }

        void PlayersNamn(string strName) //Namn på spelaren
        {
            Console.WriteLine("Hello, " + strName + "\n---------------------");
            

        }
           
        
    }             
          
       
}

