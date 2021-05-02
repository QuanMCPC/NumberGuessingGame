using System;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class InputNameDialog : Form
    {
        public static string name___ = "";
        public InputNameDialog(int position, string time)
        {
            InitializeComponent();
            indication.Text = "You have reached position " + position + "/10 with a time of:" + time + ".";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (nameInputNameDialog.Text.Trim() != "")
            {
                name___ = nameInputNameDialog.Text;
            }
            else
            {
                MessageBox.Show("Error: Please insert name so the game can save into the leaderboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
