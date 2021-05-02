
namespace NumberGuessingGame
{
    partial class Leaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaderboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HighWins = new System.Windows.Forms.TabPage();
            this.ShortTime = new System.Windows.Forms.TabPage();
            this.ShortTimeTable = new System.Windows.Forms.ListView();
            this.pos1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.impossibleName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.impossibleTimer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.HighWins.SuspendLayout();
            this.ShortTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HighWins);
            this.tabControl1.Controls.Add(this.ShortTime);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 237);
            this.tabControl1.TabIndex = 1;
            // 
            // HighWins
            // 
            this.HighWins.Controls.Add(this.impossibleTimer);
            this.HighWins.Controls.Add(this.label4);
            this.HighWins.Controls.Add(this.impossibleName);
            this.HighWins.Controls.Add(this.label2);
            this.HighWins.Controls.Add(this.label1);
            this.HighWins.Location = new System.Drawing.Point(4, 22);
            this.HighWins.Name = "HighWins";
            this.HighWins.Padding = new System.Windows.Forms.Padding(3);
            this.HighWins.Size = new System.Drawing.Size(402, 211);
            this.HighWins.TabIndex = 1;
            this.HighWins.Text = "Best Time (Impossible Mode)";
            this.HighWins.UseVisualStyleBackColor = true;
            // 
            // ShortTime
            // 
            this.ShortTime.Controls.Add(this.ShortTimeTable);
            this.ShortTime.Location = new System.Drawing.Point(4, 22);
            this.ShortTime.Name = "ShortTime";
            this.ShortTime.Padding = new System.Windows.Forms.Padding(3);
            this.ShortTime.Size = new System.Drawing.Size(402, 211);
            this.ShortTime.TabIndex = 2;
            this.ShortTime.Text = "Best Time";
            this.ShortTime.UseVisualStyleBackColor = true;
            // 
            // ShortTimeTable
            // 
            this.ShortTimeTable.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.ShortTimeTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pos1,
            this.nTime,
            this.name1});
            this.ShortTimeTable.FullRowSelect = true;
            this.ShortTimeTable.HideSelection = false;
            this.ShortTimeTable.Location = new System.Drawing.Point(7, 6);
            this.ShortTimeTable.Name = "ShortTimeTable";
            this.ShortTimeTable.Size = new System.Drawing.Size(389, 199);
            this.ShortTimeTable.TabIndex = 1;
            this.ShortTimeTable.UseCompatibleStateImageBehavior = false;
            this.ShortTimeTable.View = System.Windows.Forms.View.Details;
            // 
            // pos1
            // 
            this.pos1.Text = "Position";
            // 
            // nTime
            // 
            this.nTime.Text = "Time";
            this.nTime.Width = 106;
            // 
            // name1
            // 
            this.name1.Text = "Name";
            this.name1.Width = 217;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "This person have done the impossible!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maybe the person cheated, or he/she have really guessed the number in the impossi" +
    "ble mode. Anyway, I\'m proud to present to you, the person who found the number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // impossibleName
            // 
            this.impossibleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impossibleName.Location = new System.Drawing.Point(6, 84);
            this.impossibleName.Name = "impossibleName";
            this.impossibleName.Size = new System.Drawing.Size(390, 20);
            this.impossibleName.TabIndex = 2;
            this.impossibleName.Text = "[Redacted]";
            this.impossibleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(393, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "with an amazing time of:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // impossibleTimer
            // 
            this.impossibleTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impossibleTimer.ForeColor = System.Drawing.Color.DarkRed;
            this.impossibleTimer.Location = new System.Drawing.Point(7, 143);
            this.impossibleTimer.Name = "impossibleTimer";
            this.impossibleTimer.Size = new System.Drawing.Size(389, 23);
            this.impossibleTimer.TabIndex = 4;
            this.impossibleTimer.Text = "00:00:00:00";
            this.impossibleTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reset Leaderboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Leaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Leaderboard";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.HighWins.ResumeLayout(false);
            this.ShortTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HighWins;
        private System.Windows.Forms.TabPage ShortTime;
        private System.Windows.Forms.ListView ShortTimeTable;
        private System.Windows.Forms.ColumnHeader pos1;
        private System.Windows.Forms.ColumnHeader nTime;
        private System.Windows.Forms.ColumnHeader name1;
        private System.Windows.Forms.Label impossibleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label impossibleTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}