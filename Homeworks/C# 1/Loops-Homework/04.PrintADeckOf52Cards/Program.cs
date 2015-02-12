using System;
namespace _04.PrintADeckOf52Cards
{


   //Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
   //The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
   //The card faces should start from 2 to A.
   //Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            for (int i = 2; i <= 14; i++)
            {
                switch (i)
                {
                    case 2:
                        text = "2";
                        break;
                    case 3:
                        text = "3";
                        break;
                    case 4:
                        text = "4";
                        break;
                    case 5:
                        text = "5";
                        break;
                    case 6:
                        text = "6";
                        break;
                    case 7:
                        text = "7";
                        break;
                    case 8:
                        text = "8";
                        break;
                    case 9:
                        text = "9";
                        break;
                    case 10:
                        text = "10";
                        break;
                    case 11:
                        text = "J";
                        break;
                    case 12:
                        text = "Q";
                        break;
                    case 13:
                        text = "K";
                        break;
                    case 14:
                        text = "A";
                        break;
                    default:
                        break;
                }
                for (int j = 1; j <= 4; j++)
                {
                   // int caseSwitch = 1;
                    switch (j)
                    {
                        case 1:
                            Console.Write("{0} of spades, ", text);
                            break;
                        case 2:
                            Console.Write("{0} of clubs, ", text);
                            break;
                        case 3:
                            Console.Write("{0} of hearts, ", text);
                            break;
                        case 4:
                            Console.Write("{0} of diamonds", text);
                            break;
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
