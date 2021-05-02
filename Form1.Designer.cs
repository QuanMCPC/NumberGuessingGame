
namespace NumberGuessingGame
{
    partial class GuessTheNumberGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessTheNumberGame));
            this.output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.end_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearOutputBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxNum = new System.Windows.Forms.NumericUpDown();
            this.minNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Best_Time = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Wins = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.times = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tries = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.input = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(13, 12);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(775, 247);
            this.output.TabIndex = 0;
            this.output.Text = resources.GetString("output.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter number here:";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(340, 13);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 21);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // end_button
            // 
            this.end_button.Location = new System.Drawing.Point(421, 13);
            this.end_button.Name = "end_button";
            this.end_button.Size = new System.Drawing.Size(75, 21);
            this.end_button.TabIndex = 4;
            this.end_button.Text = "End";
            this.end_button.UseVisualStyleBackColor = true;
            this.end_button.Click += new System.EventHandler(this.Button2_Click);
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(259, 13);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(75, 21);
            this.insert_button.TabIndex = 5;
            this.insert_button.Text = "Insert";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.Button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ClearOutputBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maxNum);
            this.groupBox1.Controls.Add(this.minNum);
            this.groupBox1.Location = new System.Drawing.Point(13, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Leaderboard";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Activate Impossible Mode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ClearOutputBox
            // 
            this.ClearOutputBox.AutoSize = true;
            this.ClearOutputBox.Location = new System.Drawing.Point(9, 45);
            this.ClearOutputBox.Name = "ClearOutputBox";
            this.ClearOutputBox.Size = new System.Drawing.Size(204, 17);
            this.ClearOutputBox.TabIndex = 4;
            this.ClearOutputBox.Text = "Clear the output box after each game.";
            this.ClearOutputBox.UseVisualStyleBackColor = true;
            this.ClearOutputBox.CheckStateChanged += new System.EventHandler(this.ClearOutputBox_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "and";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Generate number between";
            // 
            // maxNum
            // 
            this.maxNum.Location = new System.Drawing.Point(258, 19);
            this.maxNum.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.maxNum.Name = "maxNum";
            this.maxNum.Size = new System.Drawing.Size(76, 20);
            this.maxNum.TabIndex = 1;
            this.maxNum.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // minNum
            // 
            this.minNum.Location = new System.Drawing.Point(145, 19);
            this.minNum.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.minNum.Name = "minNum";
            this.minNum.Size = new System.Drawing.Size(76, 20);
            this.minNum.TabIndex = 0;
            this.minNum.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Best_Time);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Wins);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.times);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tries);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(522, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 149);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Counter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "DD:HH:MM:SS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Time Format: ";
            // 
            // Best_Time
            // 
            this.Best_Time.AutoSize = true;
            this.Best_Time.Location = new System.Drawing.Point(142, 88);
            this.Best_Time.Name = "Best_Time";
            this.Best_Time.Size = new System.Drawing.Size(64, 13);
            this.Best_Time.TabIndex = 7;
            this.Best_Time.Text = "00:00:00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Best Time: ";
            // 
            // Wins
            // 
            this.Wins.AutoSize = true;
            this.Wins.Location = new System.Drawing.Point(142, 48);
            this.Wins.Name = "Wins";
            this.Wins.Size = new System.Drawing.Size(13, 13);
            this.Wins.TabIndex = 5;
            this.Wins.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Wins: ";
            // 
            // times
            // 
            this.times.AutoSize = true;
            this.times.Location = new System.Drawing.Point(142, 68);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(64, 13);
            this.times.TabIndex = 3;
            this.times.Text = "00:00:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Times: ";
            // 
            // tries
            // 
            this.tries.AutoSize = true;
            this.tries.Location = new System.Drawing.Point(142, 28);
            this.tries.Name = "tries";
            this.tries.Size = new System.Drawing.Size(13, 13);
            this.tries.TabIndex = 1;
            this.tries.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tries: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.input);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.start_button);
            this.groupBox3.Controls.Add(this.insert_button);
            this.groupBox3.Controls.Add(this.end_button);
            this.groupBox3.Location = new System.Drawing.Point(13, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 43);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input Area";
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.Control;
            this.input.Location = new System.Drawing.Point(109, 14);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(143, 20);
            this.input.TabIndex = 4;
            this.input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input_KeyUp_1);
            // 
            // GuessTheNumberGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "GuessTheNumberGame";
            this.Text = "Guess the number Game";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GuessTheNumberGame_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button end_button;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxNum;
        private System.Windows.Forms.NumericUpDown minNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label times;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tries;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.CheckBox ClearOutputBox;
        private System.Windows.Forms.Label Best_Time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Wins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

