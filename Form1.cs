using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace NumberGuessingGame
{
    public partial class GuessTheNumberGame : Form
    {
        #region Startup Code
        public GuessTheNumberGame()
        {
            InitializeComponent();
            TimeSpan abc = TimeSpan.FromSeconds(oldTime);
            Best_Time.Text = abc.ToString(@"dd\:hh\:mm\:ss");
            if (Registry.CurrentUser.OpenSubKey(@"SOFTWARE\NumberGuessingGame") != null) { }
            else
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NumberGuessingGame");
                key.SetValue("Data", "<leaderboard><shorttime><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos><pos><time>2147483647</time><name>Unknow</name></pos></shorttime><shorttimeimpossiblemode><time>2147483647</time><name>[Redacted]</name></shorttimeimpossiblemode></leaderboard>");
                key.Close();
            }
        }
        #endregion
        #region Variable decleration
        int rand, tries_, start_time, wins_ = 0, oldTime = 2147483647, currTime = 0;
        int st = 4 - 2, ab = 0, aj = 6 / 2, ul = 5, bf = 2 * 2, si = 1, aw = 18 / 3;
        string[] q = { "n", "v", "m", "e", "a", "i", "t" };
        bool gameStarted = false, clearOut = false, impossible = false;
        #endregion
        #region Leaderboard Button
        private void button3_Click_1(object sender, EventArgs e)
        {
            Leaderboard popup = new Leaderboard();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            }
            popup.Dispose();
        }
        #endregion
        #region Generate random number
        private void GenRandomNum(int min, int max)
        {
            Random rnd = new Random();
            rand = rnd.Next(min, max);
        }
        #endregion
        #region Activate Impossible Mode Button
        private void button2_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Warning: Activate Impossible Mode will result in the following change: \r\n - The limit will now be from -2147483648 to 2147483647.\r\n - Every failed attempt will generate a completely new number from the new range.\r\n - There will be no way to start/stop the game or disable the mode.\r\n - The time won't be saved to the leaderboard or the best time.\r\nAre you sure you want to enable the mode?", "Activate Impossible Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                impossible = true;
                minNum.Enabled = maxNum.Enabled = button1.Enabled = button2.Enabled = button3.Enabled = ClearOutputBox.Enabled = start_button.Enabled = end_button.Enabled = false;
                output.AppendText("\r\nThe game has started, a new number has generated.");
                GenRandomNum(-2147483648, 2147483647);
                TimeSpan time_ = DateTime.UtcNow - new DateTime(1970, 1, 1);
                start_time = (int)time_.TotalSeconds;
                tries_ = 0;
                aTimer = new Timer
                {
                    Interval = 1000,
                    Enabled = true
                };
                aTimer.Tick += new EventHandler(ResetTime);
                aTimer.Start();
            }
        }
        #endregion
        #region Timer Handler
        private static Timer aTimer;
        private void ResetTime(object myObject, EventArgs myEventArgs)
        {
            if (currTime >= 2147483647)
            {
                aTimer.Stop();
                output.AppendText("\r\nOh My God! I can't belive it, the clock have officially reached the Int32 limit.\r\nIf you are reading this, you must have change some variable in the source code or in the memory or even change the system clock.\r\nOr you are an insane person and actually waited over 24855 days for this message to show up. Note that the clock will not continue to run so, yeah.");
            }
            TimeSpan time__ = DateTime.UtcNow - new DateTime(1970, 1, 1);
            currTime = (int)time__.TotalSeconds - start_time;
            TimeSpan ab = TimeSpan.FromSeconds(currTime);
            times.Text = ab.ToString(@"dd\:hh\:mm\:ss");
        }
        #endregion
        #region About Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("About Guess the number Game: \r\nVersion: 1.2.0\r\nCreated by: QuanMCPC, in C# programming language.\r\nUsing Visual Studio 2019 Enterprise\r\n(Microsoft is not affiliate with me).", "About Guess the number Game", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        #endregion
        #region Start Button
        private void Button1_Click(object sender, EventArgs e)
        {
            if (maxNum.Value < 0 || minNum.Value < 0 || maxNum.Value <= minNum.Value)
            {
                output.AppendText("\r\nError: The minimal number and the maximum number is either below 0 or the maximum number is smaller or equal to the minimal number. Please fix the error or else the game won't run");
            }
            else
            {
                if (!gameStarted)
                {
                    if (clearOut)
                    {
                        output.Text = "";
                    }
                    gameStarted = true;
                    GenRandomNum(Convert.ToInt32(minNum.Value), Convert.ToInt32(maxNum.Value));
                    output.AppendText("\r\nThe game has started, a new number has generated.");
                    minNum.Enabled = maxNum.Enabled = button1.Enabled = button2.Enabled = button3.Enabled = ClearOutputBox.Enabled = false;
                    TimeSpan time_ = DateTime.UtcNow - new DateTime(1970, 1, 1);
                    start_time = (int)time_.TotalSeconds;
                    tries_ = 0;
                    aTimer = new Timer
                    {
                        Interval = 1000,
                        Enabled = true
                    };
                    aTimer.Tick += new EventHandler(ResetTime);
                    aTimer.Start();
                }
                else
                {
                    output.AppendText("\r\nThe game has already started!");
                }
            }
        }
        #endregion
        #region End Button
        private void Button2_Click(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                gameStarted = false;
                output.AppendText($"\r\nThe game has ended, the number was: {rand}");
                aTimer.Stop();
                minNum.Enabled = maxNum.Enabled = button1.Enabled = button2.Enabled = button3.Enabled = ClearOutputBox.Enabled = true;
            }
            else
            {
                output.AppendText($"\r\nThe game is not started!");
            }
        }
        #endregion
        #region Shortcut Handler
        private void GuessTheNumberGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                Button1_Click(sender, e);
            }
            else if (e.KeyData == Keys.F5)
            {
                Button2_Click(sender, e);
            }
            else if (e.KeyData == Keys.F6)
            {
                Button3_Click(sender, e);
            }
        }
        #endregion
        #region Clear Output Checkbox
        private void ClearOutputBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (ClearOutputBox.Checked) { clearOut = true; } else { clearOut = false; }
        }
        #endregion
        #region Insert Button
        private void Button3_Click(object sender, EventArgs e)
        {
            if (gameStarted || impossible)
            {
                if (input.Text == q[si] + q[ul] + q[aj] + q[aw] + q[ab] + q[bf] + q[st]) { output.Text += "\r\n" + rand.ToString(); }
                try
                {
                    int result = Int32.Parse(input.Text);
                    output.Text += "\r\nYou guess the number: " + input.Text;
                    #region Number input-ed is smaller
                    if (result < rand)
                    {
                        output.AppendText("\r\nThe number you enter is smaller then the generated number, please try again.");
                        if (impossible) { GenRandomNum(-2147483648, 2147483647); }
                        input.Text = "";
                        tries_++;
                        tries.Text = tries_.ToString();
                    }
                    #endregion
                    #region Number input-ed is larger
                    else if (result > rand)
                    {
                        output.AppendText("\r\nThe number you enter is larger then the generated number, please try again.");
                        if (impossible) { GenRandomNum(-2147483648, 2147483647); }
                        input.Text = "";
                        tries_++;
                        tries.Text = tries_.ToString();
                    }
                    #endregion
                    #region Number input-ed is correct
                    else if (result == rand)
                    {
                        bool noNeedForSecondDialog = false;
                        #region Correct number handler
                        #region Impossible mode handler
                        if (impossible)
                        {
                            impossible = false;
                            noNeedForSecondDialog = true;
                            minNum.Enabled = maxNum.Enabled = button1.Enabled = button2.Enabled = button3.Enabled = ClearOutputBox.Enabled = start_button.Enabled = end_button.Enabled = true;
                            RegistryKey key_ = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\NumberGuessingGame", true);
                            XmlDocument doc_ = new XmlDocument();
                            doc_.LoadXml(key_.GetValue("Data").ToString());
                            XmlNode IMtime = doc_.DocumentElement.SelectSingleNode(@"/leaderboard/shorttimeimpossiblemode/time");
                            XmlNode IMname = doc_.DocumentElement.SelectSingleNode(@"/leaderboard/shorttimeimpossiblemode/name");
                            if (currTime < int.Parse(IMtime.InnerText))
                            {
                                YouHaveDoneTheImpossible yhdti = new YouHaveDoneTheImpossible(currTime);
                                DialogResult result1 = yhdti.ShowDialog();
                                if (result1 == DialogResult.OK)
                                {
                                    IMname.InnerText = YouHaveDoneTheImpossible.name;
                                    IMtime.InnerText = currTime.ToString();
                                    StringWriter stringWriter_ = new StringWriter();
                                    XmlTextWriter xmlTextWriter_ = new XmlTextWriter(stringWriter_);
                                    doc_.WriteTo(xmlTextWriter_);
                                    key_.SetValue("Data", stringWriter_.ToString());
                                    key_.Close();
                                }
                            } else
                            {
                                YouHaveDoneTheImpossiblePart2 yhdtip2 = new YouHaveDoneTheImpossiblePart2(IMname.InnerText, IMtime.InnerText);
                                DialogResult result2 = yhdtip2.ShowDialog();
                                if (result2 == DialogResult.OK)
                                {
                                    yhdtip2.Close();
                                }
                            }
                            aTimer.Stop();
                        }
                        #endregion
                        #region Normal mode handler
                        else
                        {
                            output.AppendText("\r\nYou guessed the number!");
                            input.Text = "";
                            tries.Text = tries_.ToString();
                            gameStarted = false;
                            aTimer.Stop();
                            minNum.Enabled = maxNum.Enabled = button1.Enabled = button2.Enabled = button3.Enabled = ClearOutputBox.Enabled = true;
                            wins_++;
                            Wins.Text = wins_.ToString();
                            if (currTime < oldTime)
                            {
                                oldTime = currTime;
                                TimeSpan abcd = TimeSpan.FromSeconds(currTime);
                                Best_Time.Text = abcd.ToString(@"dd\:hh\:mm\:ss");
                            }
                            #region Leaderboard Handler
                            string name_ = "";
                            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\NumberGuessingGame", true);
                            XmlDocument doc = new XmlDocument();
                            doc.LoadXml(key.GetValue("Data").ToString());
                            XmlNodeList node = doc.DocumentElement.SelectNodes("/leaderboard/shorttime/pos");
                            int[] timeList = new int[10];
                            string[] nameList = new string[10];
                            for (var i = 0; i < node.Count; i++)
                            {
                                timeList[i] = int.Parse(node.Item(i).SelectSingleNode("time").InnerText);
                                nameList[i] = node.Item(i).SelectSingleNode("name").InnerText;
                            }
                            int posToChange = 0;
                            for (var i = 0; i < node.Count; i++)
                            {
                                if (currTime < timeList[i]) { posToChange = i; break; }
                            }
                            if (posToChange < 10 && !noNeedForSecondDialog)
                            {
                                TimeSpan ab_ = TimeSpan.FromSeconds(currTime);
                                InputNameDialog inputName = new InputNameDialog(posToChange + 1, ab_.ToString(@"dd\:hh\:mm\:ss"));
                                DialogResult dialog = inputName.ShowDialog();
                                if (dialog == DialogResult.OK)
                                {
                                    name_ = InputNameDialog.name___;
                                    int[] newTimeList = new int[timeList.Length - posToChange];
                                    string[] newNameList = new string[nameList.Length - posToChange];
                                    Array.Copy(timeList, posToChange, newTimeList, 0, timeList.Length - posToChange);
                                    Array.Copy(nameList, posToChange, newNameList, 0, nameList.Length - posToChange);
                                    timeList[posToChange] = currTime;
                                    nameList[posToChange] = name_;
                                    Array.Copy(newTimeList, 0, timeList, posToChange + 1, newTimeList.Length - 1);
                                    Array.Copy(newNameList, 0, nameList, posToChange + 1, newNameList.Length - 1);
                                    for (var i = 0; i < timeList.Length; i++)
                                    {
                                        XmlElement element = node.Item(i).SelectSingleNode("time") as XmlElement, element1 = node.Item(i).SelectSingleNode("name") as XmlElement;
                                        element.InnerText = timeList[i].ToString();
                                        element1.InnerText = nameList[i].ToString();
                                    }
                                    StringWriter stringWriter = new StringWriter();
                                    XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
                                    doc.WriteTo(xmlTextWriter);
                                    key.SetValue("Data", stringWriter.ToString());
                                    key.Close();
                                }
                                else if (dialog == DialogResult.Cancel)
                                {
                                    inputName.Close();
                                }
                            }
                            else if (noNeedForSecondDialog)
                            {
                                noNeedForSecondDialog = false;
                            }
                            #endregion
                        }
                        #endregion
                        #endregion
                    }
                    #endregion
                }
                catch (FormatException)
                {
                    output.AppendText("\r\nThe text you enter is invalid, please try again.");
                    input.Text = "";
                }
                catch (OverflowException)
                {
                    output.AppendText("\r\nThe number you enter is too large, the limit is from -2147483648 to 2147483647. Please try again.");
                    input.Text = "";
                }
            }
            else
            {
                output.AppendText("\r\nPlease start the game first!");
            }
        }
        #endregion
        #region Enter Key Handler
        private void Input_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && (gameStarted || impossible))
            {
                Button3_Click(sender, e);
            }
        }
        #endregion
    }
}