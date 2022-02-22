namespace R5R_Installer
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.downRate = new System.Windows.Forms.TextBox();
            this.downRateAvg = new System.Windows.Forms.TextBox();
            this.eta = new System.Windows.Forms.TextBox();
            this.dpeers = new System.Windows.Forms.TextBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.discordLink = new System.Windows.Forms.LinkLabel();
            this.removeButton = new System.Windows.Forms.Button();
            this.URDetours = new System.Windows.Forms.Button();
            this.URScripts = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(12, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(92, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Download Directory";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(54, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // output
            // 
            this.output.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.output.Location = new System.Drawing.Point(211, 317);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(339, 22);
            this.output.TabIndex = 4;
            // 
            // downRate
            // 
            this.downRate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.downRate.Location = new System.Drawing.Point(639, 127);
            this.downRate.Name = "downRate";
            this.downRate.Size = new System.Drawing.Size(100, 22);
            this.downRate.TabIndex = 5;
            // 
            // downRateAvg
            // 
            this.downRateAvg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.downRateAvg.Location = new System.Drawing.Point(639, 164);
            this.downRateAvg.Name = "downRateAvg";
            this.downRateAvg.Size = new System.Drawing.Size(100, 22);
            this.downRateAvg.TabIndex = 6;
            // 
            // eta
            // 
            this.eta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.eta.Location = new System.Drawing.Point(639, 201);
            this.eta.Name = "eta";
            this.eta.Size = new System.Drawing.Size(100, 22);
            this.eta.TabIndex = 7;
            // 
            // dpeers
            // 
            this.dpeers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dpeers.Location = new System.Drawing.Point(639, 238);
            this.dpeers.Name = "dpeers";
            this.dpeers.Size = new System.Drawing.Size(100, 22);
            this.dpeers.TabIndex = 8;
            // 
            // progress
            // 
            this.progress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progress.Location = new System.Drawing.Point(12, 406);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(776, 32);
            this.progress.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Peers";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Estimated Time";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "AVG Download";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Current Download";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Output";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Download Progress";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Join us over at Discord!";
            // 
            // discordLink
            // 
            this.discordLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.discordLink.AutoSize = true;
            this.discordLink.Location = new System.Drawing.Point(642, 25);
            this.discordLink.Name = "discordLink";
            this.discordLink.Size = new System.Drawing.Size(141, 16);
            this.discordLink.TabIndex = 17;
            this.discordLink.TabStop = true;
            this.discordLink.Text = "discord.gg/r5reloaded";
            this.discordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.discordLink_LinkClicked);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.removeButton.BackColor = System.Drawing.Color.Red;
            this.removeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeButton.Location = new System.Drawing.Point(644, 340);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(127, 42);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // URDetours
            // 
            this.URDetours.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.URDetours.Location = new System.Drawing.Point(54, 289);
            this.URDetours.Name = "URDetours";
            this.URDetours.Size = new System.Drawing.Size(134, 57);
            this.URDetours.TabIndex = 19;
            this.URDetours.Text = "Update/Reinstall Detours";
            this.URDetours.UseVisualStyleBackColor = true;
            this.URDetours.Click += new System.EventHandler(this.URDetours_Click);
            // 
            // URScripts
            // 
            this.URScripts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.URScripts.Location = new System.Drawing.Point(54, 229);
            this.URScripts.Name = "URScripts";
            this.URScripts.Size = new System.Drawing.Size(134, 54);
            this.URScripts.TabIndex = 20;
            this.URScripts.Text = "Update/Reinstall Scripts";
            this.URScripts.UseVisualStyleBackColor = true;
            this.URScripts.Click += new System.EventHandler(this.URScripts_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(321, 48);
            this.label9.TabIndex = 21;
            this.label9.Text = "For updating Scripts/Detours you don\'t need to select\r\n the Download Directory, y" +
    "ou just have to make\r\n sure you have Directory.txt!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.URScripts);
            this.Controls.Add(this.URDetours);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.discordLink);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.dpeers);
            this.Controls.Add(this.eta);
            this.Controls.Add(this.downRateAvg);
            this.Controls.Add(this.downRate);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox downRate;
        private System.Windows.Forms.TextBox downRateAvg;
        private System.Windows.Forms.TextBox eta;
        private System.Windows.Forms.TextBox dpeers;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel discordLink;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button URDetours;
        private System.Windows.Forms.Button URScripts;
        private System.Windows.Forms.Label label9;
    }
}

