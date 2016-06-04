/*
using System;
//using Splayerscorestem.Collections;

namespace Program
{
    public class Blackjack
    {
        int playerscore;
        int compscore;
        int origRow = 0;
        int origCol = 21;
        string x;
        int z = 1;
        Random rand = new Random();
        string[,] cards = { { "2" + "\u2660", "3" + "\u2660", "4" + "\u2660", "5" + "\u2660", "6" + "\u2660", "7" + "\u2660", "8" + "\u2660", "9" + "\u2660", "10" + "\u2660", "J" + "\u2660", "Q" + "\u2660", "K" + "\u2660", "A" + "\u2660" },
                            { "2" + "\u2663", "3" + "\u2663", "4" + "\u2663", "5" + "\u2663", "6" + "\u2663", "7" + "\u2663", "8" + "\u2663", "9" + "\u2663", "10" + "\u2663", "J" + "\u2663", "Q" + "\u2663", "K" + "\u2663", "A" + "\u2663" },
                            { "2" + "\u2665", "3" + "\u2665", "4" + "\u2665", "5" + "\u2665", "6" + "\u2665", "7" + "\u2665", "8" + "\u2665", "9" + "\u2665", "10" + "\u2665", "J" + "\u2665", "Q" + "\u2665", "K" + "\u2665", "A" + "\u2665" },
                            { "2" + "\u2666", "3" + "\u2666", "4" + "\u2666", "5" + "\u2666", "6" + "\u2666", "7" + "\u2666", "8" + "\u2666", "9" + "\u2666", "10" + "\u2666", "J" + "\u2666", "Q" + "\u2666", "K" + "\u2666", "A" + "\u2666" } };


        public void Card()
        {
            x = cards[rand.Next(3), rand.Next(12)];
            Console.Write(x + " ");
            switch (x[0])
            {
                case '2':
                    playerscore = playerscore + 2;
                    break;
                case '3':
                    playerscore = playerscore + 3;
                    break;
                case '4':
                    playerscore = playerscore + 4;
                    break;
                case '5':
                    playerscore = playerscore + 5;
                    break;
                case '6':
                    playerscore = playerscore + 6;
                    break;
                case '7':
                    playerscore = playerscore + 7;
                    break;
                case '8':
                    playerscore = playerscore + 8;
                    break;
                case '9':
                    playerscore = playerscore + 9;
                    break;
                case '1': // ten(10)
                    playerscore = playerscore + 10;
                    break;
                case 'J':
                    playerscore = playerscore + 10;
                    break;
                case 'Q':
                    playerscore = playerscore + 10;
                    break;
                case 'K':
                    playerscore = playerscore + 10;
                    break;
                case 'A':
                    playerscore = playerscore + 11;
                    break;
            }
        }

        public void CompLoose()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Компьютер проиграл");
            Console.ResetColor();
            Console.Write(" Еще раунд? (да\\нет): ");

            
            Console.ReadLine();
            //if (String.Equals(Console.ReadLine(), "да")) break;
            //playerscore = 0;
            //break;
        }

        public void PlayerLoose()

        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Игрок проиграл");
            Console.ResetColor();
            Console.Write(" Еще раунд? (да\\нет): ");
            //playerscore = 0;
            Console.ReadLine();
            //playerscore = 0;
            //break;
        }

        public void Push()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Игрок проиграл");
            Console.ResetColor();
            Console.Write(" Еще раунд? (да\\нет): ");
            //playerscore = 0;
            Console.ReadLine();
            //playerscore = 0;
            // break;
        }



        public void CardForComp()
        {
            x = cards[rand.Next(3), rand.Next(12)];
            Console.Write(x + " ");
            switch (x[0])
            {
                case '2':
                    compscore = compscore + 2;
                    break;
                case '3':
                    compscore = compscore + 3;
                    break;
                case '4':
                    compscore = compscore + 4;
                    break;
                case '5':
                    compscore = compscore + 5;
                    break;
                case '6':
                    compscore = compscore + 6;
                    break;
                case '7':
                    compscore = compscore + 7;
                    break;
                case '8':
                    compscore = compscore + 8;
                    break;
                case '9':
                    compscore = compscore + 9;
                    break;
                case '1': // ten(10)
                    compscore = compscore + 10;
                    break;
                case 'J':
                    compscore = compscore + 10;
                    break;
                case 'Q':
                    compscore = compscore + 10;
                    break;
                case 'K':
                    compscore = compscore + 10;
                    break;
                case 'A':
                    compscore = compscore + 11;
                    break;
            }
        }

        public void FirstTwoCard()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n Раунд " + z + "\n");
            Console.ResetColor();
            Console.Write(" Карты игрока: ");
            Card();
            Card();
            Console.WriteLine("\n Количество очков: " + playerscore);
            Console.Write(" Ещё? (да\\нет): ");

        }

        public void FirstTwoCardForComp()
        {
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("\n Раунд " + z + "\n");
            //Console.ResetColor();
            Console.Write(" Карты компьютера: ");
            CardForComp();
            CardForComp();
            Console.WriteLine("\n Количество очков: " + compscore);
            //Console.Write(" Ещё? (да\\нет): ");
        }

        public void NewCard()
        {
            Console.SetCursorPosition(origCol++, 3);
            Card();
            Console.WriteLine("\n Количество очков: " + playerscore);
            Console.Write("\r                             ");
            Console.Write("\r Ещё? (да\\нет): ");
            char ch = x[0];
            if (ch.Equals('1')) origCol = origCol + 1;
            origCol = origCol + 2;
        }

        //static void Main()
        {
            Blackjack program = new Blackjack();
            Console.WriteLine("\n Я хочу сыграть с тобой в одну игру. BlackJack.\n");
            Console.Write(" Начнем? ");
            Console.ReadKey();
            program.FirstTwoCard();
            while (true)
            {

                if (String.Equals(Console.ReadLine(), "да"))
                {



                    while (true)
                    {

                        program.NewCard();
                        if (program.playerscore == 21)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n Blackjack");
                            Console.ResetColor();
                            Console.Write("\n Еще раунд? ");
                            Console.ReadLine();
                            //if (String.Equals(Console.ReadLine(), "да"))
                            program.playerscore = 0;
                            program.z++;
                            program.origCol = 21;

                        }
                        if (program.playerscore > 21)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n Игрок проиграл");
                            Console.ResetColor();
                            Console.Write("\n Еще раунд? ");
                            Console.ReadLine();
                            program.origCol = 21;
                            program.playerscore = 0;
                            program.z++;
                            //break;
                        }
                        //break;
                        //Console.Write("\n Цикл 3 ");

                        Console.Write("\n Цикл 2 ");
                        Console.ReadKey();
                    }
                }

                else

                {
                    program.FirstTwoCardForComp();
                    if (program.compscore < program.playerscore)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Компьютер проиграл");
                        Console.ResetColor();
                        Console.Write(" Еще раунд? (да\\нет): ");


                        Console.ReadLine();
                        if (String.Equals(Console.ReadLine(), "да")) break;
                        //playerscore = 0;
                        //break;
                    }
                    //program.CompLoose();
                    else if (program.compscore == program.playerscore)
                        program.Push();
                    else
                        program.PlayerLoose();
                    break;
                }
            }
        }

    }
}

*/