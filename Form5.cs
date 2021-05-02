using System;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class YouHaveDoneTheImpossiblePart2 : Form
    {
        public YouHaveDoneTheImpossiblePart2(string name, string time)
        {
            InitializeComponent();
            TimeSpan a__ = TimeSpan.FromSeconds(int.Parse(time));
            var a_ = a__.ToString(@"dd\:hh\:mm\:ss");
            label2.Text = "You just done the impossible: Guessed the number in impossbie mode. Although it's quite impressive, but it isn't too impressive since a person named: " + name + " have guessed the number in: "+ a_ +". So try again if you want to beat the record";
        }
    }
}
