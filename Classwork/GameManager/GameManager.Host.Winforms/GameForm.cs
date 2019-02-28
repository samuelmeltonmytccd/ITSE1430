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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        public Game Game { get; set; }

        private decimal ReadDecimal( TextBox control )
        {
            if (control.Text.Length == 0)
                return 0;
            if (Decimal.TryParse(control.Text, out var value))
                return value;

            return -1;
        }

        private void button2_Click( object sender, EventArgs e )
        {

        }

        private void button1_Click( object sender, EventArgs e )
        {

        }

        private void OnValidateName( object sender, CancelEventArgs e )
        {
            //Console.WriteLine("print");
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Name is required.");
                e.Cancel = true;
            } else
                _errors.SetError(tb, "");
        }

        //{
        //    if (game.Name.Length == 0)
        //    {
        //        MessageBox.Show("Name is required.", "Error", MessageBoxButtons.OK);
        //        return;
        //    };
        //}

        private void OnValidatePrice( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            var price = ReadDecimal(tb);
            if (price < 0)
            {
                _errors.SetError(tb, "Price must be >= 0.");
                e.Cancel = true;
            } else
                _errors.SetError(tb, "");
        }

        private void OnCancel( object sender, EventArgs e )
        {

               DialogResult = DialogResult.Cancel;
               Close();
            
        }
    }
}
