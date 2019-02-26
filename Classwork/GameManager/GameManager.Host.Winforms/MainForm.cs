using System;
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

            game.Completed = true;
            game.Name = "Dark Souls";
            game.Price = 59.99M;



            game.Validate();

            //var x = 10;
            //x.ToString(); 

            //var str = game.Publisher;
            //Decimal.TryParse("45.99", out game.Price);

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

        private void OnGameAdd( object sender, EventArgs e )
        {
            //Display UI
            //If OK then "add" to system
        }

        private void OnGameSelected( object sender, EventArgs e )
        {

        }
    }
}
