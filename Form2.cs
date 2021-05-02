using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Xml;

namespace NumberGuessingGame
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }
        private void Leaderboard_Load(object sender, EventArgs e)
        {
            if (Registry.CurrentUser.OpenSubKey(@"SOFTWARE\NumberGuessingGame") != null)
            {
                ReloadTable();
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NumberGuessingGame");
                key.SetValue("Data", "<leaderboard><shorttime><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos></shorttime><shorttimeimpossiblemode><time>2147483647</time><name>[Redacted]</name></shorttimeimpossiblemode></leaderboard>");
                key.Close();
                ReloadTable();
            }
        }
        private void ReloadTable()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\NumberGuessingGame");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(key.GetValue("Data").ToString());
            XmlNodeList node = doc.DocumentElement.SelectNodes("/leaderboard/shorttime/pos");
            for (var i = 0; i < node.Count; i++)
            {
                var a_ = Int32.Parse(node.Item(i).SelectSingleNode("time").InnerText);
                TimeSpan a__ = TimeSpan.FromSeconds(a_);
                var a = a__.ToString(@"dd\:hh\:mm\:ss");
                var b = node.Item(i).SelectSingleNode("name").InnerText;
                var c = "#" + (i + 1);
                string[] row_ = { c, a, b };
                var listViewItem_ = new ListViewItem(row_);
                ShortTimeTable.Items.Add(listViewItem_);
            }
            XmlNode node_ = doc.DocumentElement.SelectSingleNode(@"/leaderboard/shorttimeimpossiblemode/time");
            XmlNode node__ = doc.DocumentElement.SelectSingleNode(@"/leaderboard/shorttimeimpossiblemode/name");
            TimeSpan b__ = TimeSpan.FromSeconds(int.Parse(node_.InnerText));
            var b_ = b__.ToString(@"dd\:hh\:mm\:ss");
            impossibleName.Text = node__.InnerText;
            impossibleTimer.Text = b_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Warning: Once you reset the leaderboard, all best time and best time in impossible mode will be reset and there will be no way to restore.\r\nAre you sure you want to continue?", "Reset Leadeerboard", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
            {
                Registry.CurrentUser.DeleteSubKey(@"SOFTWARE\NumberGuessingGame");
                MessageBox.Show("Leaderboard has been reset-ed.", "Reset-ed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } else
            {
            }
            
        }
    }
}
