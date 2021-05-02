using System;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class YouHaveDoneTheImpossible : Form
    {
        public static string name = "";
        public YouHaveDoneTheImpossible(int time)
        {
            InitializeComponent();
            TimeSpan a__ = TimeSpan.FromSeconds(time);
            var a = a__.ToString(@"dd\:hh\:mm\:ss");
            label4.Text = "Your time was: " + a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                name = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Error: Please insert name so the game can save into the leaderboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
