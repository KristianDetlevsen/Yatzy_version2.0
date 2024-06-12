using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy_version2._0
{
    internal class Menu
    {
               
        public void Show()
        {
            Runde runde = new Runde();

            Console.WriteLine("Velkommen til Yatzy 2.0!");

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Hvor mange spillere er I - 2, 3 eller 4?");
                string numPlayers = Console.ReadLine();
                switch (numPlayers)
                {
                    case "2":                        
                        Spiller spiller1 = new Spiller();
                        Spiller spiller2 = new Spiller();
                        ScoreBoard board1 = new ScoreBoard();
                        ScoreBoard board2 = new ScoreBoard();
                        runde.IndtastNavn(spiller1);
                        runde.IndtastNavn(spiller2);
                        Console.Clear();
                        for (int i = 1; i < 16; i++)
                        {
                            board1.VisScoreBoard(spiller1);
                            runde.SpilRunde(spiller1, i);
                            runde.TildelPoint(board1);
                            board2.VisScoreBoard(spiller2);
                            runde.SpilRunde(spiller2, i);
                            runde.TildelPoint(board2);
                        }
                        board1.VisScoreBoard(spiller1);
                        board2.VisScoreBoard(spiller2);
                        runde.SlutSpillet(board1, board2, spiller1, spiller2);
                        exit = true;
                        break;
                    case "3":
                        Spiller spiller1_ = new Spiller();
                        Spiller spiller2_ = new Spiller();
                        Spiller spiller3_ = new Spiller();
                        ScoreBoard board1_ = new ScoreBoard();
                        ScoreBoard board2_ = new ScoreBoard();
                        ScoreBoard board3_ = new ScoreBoard();
                        runde.IndtastNavn(spiller1_);
                        runde.IndtastNavn(spiller2_);
                        runde.IndtastNavn(spiller3_);
                        Console.Clear();
                        for (int i = 1; i < 16; i++)
                        {
                            board1_.VisScoreBoard(spiller1_);
                            runde.SpilRunde(spiller1_, i);
                            runde.TildelPoint(board1_);
                            board2_.VisScoreBoard(spiller2_);
                            runde.SpilRunde(spiller2_, i);                            
                            runde.TildelPoint(board2_);
                            board3_.VisScoreBoard(spiller3_);
                            runde.SpilRunde(spiller3_, i);                            
                            runde.TildelPoint(board3_);
                        }
                        board1_.VisScoreBoard(spiller1_);
                        board2_.VisScoreBoard(spiller2_);
                        board3_.VisScoreBoard(spiller3_);
                        runde.SlutSpillet(board1_, board2_, board3_, spiller1_, spiller2_, spiller3_);
                        exit = true;
                        break;
                    case "4":
                        Spiller spiller1__ = new Spiller();
                        Spiller spiller2__ = new Spiller();
                        Spiller spiller3__ = new Spiller();
                        Spiller spiller4__ = new Spiller();
                        ScoreBoard board1__ = new ScoreBoard();
                        ScoreBoard board2__ = new ScoreBoard();
                        ScoreBoard board3__ = new ScoreBoard();
                        ScoreBoard board4__ = new ScoreBoard();
                        runde.IndtastNavn(spiller1__);
                        runde.IndtastNavn(spiller2__);
                        runde.IndtastNavn(spiller3__);
                        runde.IndtastNavn(spiller4__);
                        Console.Clear();
                        for (int i = 1; i < 16; i++)
                        {
                            board1__.VisScoreBoard(spiller1__);
                            runde.SpilRunde(spiller1__, i);
                            runde.TildelPoint(board1__);
                            board2__.VisScoreBoard(spiller2__);
                            runde.SpilRunde(spiller2__, i);
                            runde.TildelPoint(board2__);
                            board3__.VisScoreBoard(spiller3__);
                            runde.SpilRunde(spiller3__, i);
                            runde.TildelPoint(board3__);
                            board4__.VisScoreBoard(spiller4__);
                            runde.SpilRunde(spiller4__, i);
                            runde.TildelPoint(board4__);
                        }
                        board1__.VisScoreBoard(spiller1__);
                        board2__.VisScoreBoard(spiller2__);
                        board3__.VisScoreBoard(spiller3__);
                        board4__.VisScoreBoard(spiller4__);
                        runde.SlutSpillet(board1__, board2__, board3__, board4__, spiller1__, spiller2__, spiller3__, spiller4__);
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Du skal vælge et tal mellem 2 og 4 - prøv igen!");
                        break;
                }
            }           
        }
    }
}
