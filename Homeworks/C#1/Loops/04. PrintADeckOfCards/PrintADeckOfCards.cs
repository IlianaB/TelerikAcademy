using System;

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
//output

//2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//…  
//K of spades, K of clubs, K of hearts, K of diamonds
//A of spades, A of clubs, A of hearts, A of diamonds
//Note: You may use the suit symbols instead of text.

namespace PrintADeckOfCards
{
    class PrintADeckOfCards
    {
        static void Main(string[] args)
        {
            string card = " ";

            for (int i = 0; i < 13; i++)
            {
                switch (i)
                {
                    case 0: card = "2";
                        break;
                    case 1: card = "3";
                        break;
                    case 2: card = "4";
                        break;
                    case 3: card = "5";
                        break;
                    case 4: card = "6";
                        break;
                    case 5: card = "7";
                        break;
                    case 6: card = "8";
                        break;
                    case 7: card = "9";
                        break;
                    case 8: card = "10";
                        break;
                    case 9: card = "J";
                        break;
                    case 10: card = "Q";
                        break;
                    case 11: card = "K";
                        break;
                    case 12: card = "A";
                        break;
                    default:
                        break;
                }

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(card + " ");

                    switch (j)
                    {
                        case 0: Console.Write("of spades" + ", ");
                            break;
                        case 1: Console.Write("of clubs" + ", ");
                            break;
                        case 2: Console.Write("of hearts" + ", ");
                            break;
                        case 3: Console.WriteLine("of diamonds");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
