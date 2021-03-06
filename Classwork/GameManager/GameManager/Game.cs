﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{

    /// <summary> Represents a game. </summary>
    public class Game
    {
        /// <summary>Name of the game.</summary>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }
        private string _name = "";

        /// <summary>Description of the game.</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        private string _description = "";

        //Calculated property
        public bool IsCoolGame
        {
            get { return Description != "EA"; }
        }
        public decimal Price { get; set; }

        public bool Owned { get; set; }

        public bool Completed { get; set; }

        //public string[] Genres
        //{
        //    get
        //    {
        //        var temp = new string[_genres.Length];
        //        Array.Copy(_genres, temp, _genres.Length);
        //        return temp;
        //    }
        //}
        //private string[] _genres;

        //Mixed accessibility
        //public double Rate
        //{
        //    get;
        //    internal set;
        //}

        /// <summary>
        /// Validates the object.</summary>
        /// <returns></returns>
        public bool Validate ()
        {
            //Name is required
            if (String.IsNullOrEmpty(Name))
                return false;

            //Price must be >= 0
            if (Price < 0)
                return false;

            return true;
        }
    }
}
