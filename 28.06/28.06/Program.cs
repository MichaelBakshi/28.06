using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._06
{ 
    class Program
    {
        static void PrintGame(Game g)
        {
            Console.WriteLine(g);
            int number = g.TellMeHowManyPlayers();
            Console.WriteLine(number);
        }
        static void Main(string[] args)
        {



            Game g1 = new Game()
            {
                _name = "poker",
                _numberOfPlayers = 4,
                _rating = 7.8f,
                _originCountry = "USA"

            };
            PrintGame(g1);

            Game g2 = new Game("chess", 8.5f)
            {
                _numberOfPlayers = 2,
                _originCountry = "China"
            };

            PrintGame(g2);

            Game g3 = new Game("football", 22, 4.5f, "England");
            PrintGame(g3);


            Game g4 = new Game("sudoku", "India")
            {
                _rating = 7.1f,
                _numberOfPlayers =1
            };
            PrintGame(g4);



            
        }


    }
}
