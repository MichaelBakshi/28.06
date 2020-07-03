using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _28._06
{
    class Game
    {
        public string _name;
        public int _numberOfPlayers;
        public float _rating;
        public string _originCountry;

        public Game()
        {

        }

        public Game(string _name, float _rating = 5.5f)
        {
            this._name = _name;
            this._rating = _rating;
        }

        public Game(string _name,  int _numberOfPlayers, float _rating, string _originCountry)
        {
            this._name = _name;
            this._numberOfPlayers = _numberOfPlayers;
            this._rating = _rating;
            this._originCountry = _originCountry;
        }

        public Game(string _name, string _originCountry)
        {
            this._name = _name;
            this._originCountry = _originCountry;
        }

        public int TellMeHowManyPlayers ()
        {
            return _numberOfPlayers;
        }

        public override string ToString()
        {
            return $"{base.ToString()} _name : {_name} _number Of Players   : {_numberOfPlayers} " +
                $" _rating : {_rating } _originCountry : {_originCountry}";
        }


    }
}
