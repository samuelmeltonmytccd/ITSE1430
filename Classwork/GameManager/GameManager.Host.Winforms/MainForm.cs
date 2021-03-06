﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager.Host.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //accidentally changed Behavior>AutoValidate to its current setting 
            InitializeComponent();

            LoadUI();

        }

        void LoadUI()
        {
            Game game = new Game();

            game.Name = "DOOM";
            game.Price = 59.99M;

            var name = game.Name;
            if (name.Length == 0)
                /* is empty*/
                ;

            //Checking for null - long way
            if (game.Name != null && game.Name.Length == 0)
                ;

            //Conditional - E ? Et : Ef
            var length = game.Name != null ? game.Name.Length : 0;

            //Short way - null conditional
            // game.Name.Length -> int
            // game.Name?.Length -> int?
            if ((game.Name?.Length ?? 0) == 0)
                ;
            if (game.Name.Length == 0)
                /* is empty */
                ;

            //var isCool = game.IsCoolGame;
            //game.IsCoolGame = false;

            //Validate(game)
            game.Validate();

            //var x = 10;
            //x.ToString();

            //var str = game.Publisher;            
            //Decimal.TryParse("45.99", out game.Price);

            //event EventHandler Click;
            //delegate EventHandler void ( Object, EventArgs )
            //_miGameAdd.Click += OnGameAdd;
        }

        private void fileToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            MessageBox.Show("Help");
        }

        private void BindList()
        {
            //Bind games to listbox
            _listGames.Items.Clear();

            //nameof(Game.Name) == "Name"
            _listGames.DisplayMember = nameof(Game.Name);

            //_listGames.Items.AddRange(_games);
            foreach (var game in _games)
            {
                if (game != null)
                    _listGames.Items.Add(game);
            };
        }

        //TODO missing functionality here
        private void OnGameAdd( object sender, EventArgs e )
        {
            //Display UI
            var form = new GameForm();

            //Modeless
           form.Show();

        //    //Modal
        //    if (form.ShowDialog(this) != DialogResult.OK)
        //        return;

        //    //TODO: Add
            //_games[GetNextEmptyGame()] = form.Game;
            //BindList();
        }

        //HACK: Find first spot in array with no game
        private int GetNextEmptyGame()
        {
            for (var index = 0; index < _games.Length; ++index)
                if (_games[index] == null)
                    return index;

            return -1;
        }

        private Game[] _games = new Game[100];

        private void OnGameSelected( object sender, EventArgs e )
        {

        }

        private void OnGameEdit( object sender, EventArgs e )
        {
            var form = new GameForm();

            var game = GetSelectedGame();
            if (game == null)
                return;

            //Game to edit
            form.Game = game;

            if (form.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Fix to edit, not add
            UpdateGame(game, form.Game);
            BindList();
        }

        private void UpdateGame( Game oldGame, Game newGame )
        {
            for (int index = 0; index < _games.Length; ++index)
            {
                if (_games[index] == oldGame)
                {
                    _games[index] = newGame;
                    break;
                };
            };
        }

        private void OnGameDelete( object sender, EventArgs e )
        {
            //Get selected game, if any
            var selected = GetSelectedGame();
            if (selected == null)
                return;

            //Display confirmation
            if (MessageBox.Show(this, $"Are you sure you want to delete {selected.Name}?",
                               "Confirm Delete", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            //TODO: Delete
            //DeleteGame(selected);
            BindList();
        }
    }
}
