using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {


        bool turn = true;
        int turn_count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {

                foreach (Control c in Controls)
                {
                    Button a = (Button)c;
                    a.Enabled = true;
                    a.Text = "";
                }
            }
            catch { }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BY ALY and ANDREW", "Tic Tac ToeAbout");
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (turn)

                a.Text = "x";


            else

                a.Text = "o";

            turn = !turn;
            a.Enabled = false;
            turn_count++;



            checkforwinner();
        }
        private void checkforwinner()
        {

            bool there_is_winner = false;
            //horizontal checks

            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
                there_is_winner = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                there_is_winner = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                there_is_winner = true;
            //virtical checks
            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                there_is_winner = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
                there_is_winner = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
                there_is_winner = true;
            //diagonal checks
            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
                there_is_winner = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!c1.Enabled))
                there_is_winner = true;


            if (there_is_winner)
            {
                disablebuttons();

                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " wins!", "woooow");




            }
            else
            {
                if (turn_count == 9)

                    MessageBox.Show("Draw", "Bummer");

            }


        }
        private void disablebuttons()
        {
            try
            {

                foreach (Control c in Controls)
                {
                    Button a = (Button)c;
                    a.Enabled = false;
                }
            }
            catch { }

        }
    }
}

