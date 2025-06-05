namespace Abdal_Security_Group_App
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            visualStudio2022DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2022DarkTheme();
            radMenu1 = new Telerik.WinControls.UI.RadMenu();
            menuItem_about_us = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_donate = new Telerik.WinControls.UI.RadMenuItem();
            irDonationBtn = new Telerik.WinControls.UI.RadMenuItem();
            EnDonationBtn = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_github = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_gitlab = new Telerik.WinControls.UI.RadMenuItem();
            desk_alert = new Telerik.WinControls.UI.RadDesktopAlert(components);
            bg_worker = new System.ComponentModel.BackgroundWorker();
            btn_start = new Telerik.WinControls.UI.RadButton();
            btn_exit = new PictureBox();
            btn_minimize = new PictureBox();
            listBox1 = new ListBox();
            radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            waitingBarIndicatorElement1 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            waitingBarIndicatorElement2 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)radMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radWaitingBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).BeginInit();
            radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radMenu1
            // 
            radMenu1.Dock = DockStyle.Bottom;
            radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] { menuItem_about_us, menuItem_donate, radMenuItem3 });
            radMenu1.Location = new Point(0, 519);
            radMenu1.Name = "radMenu1";
            radMenu1.Size = new Size(616, 28);
            radMenu1.TabIndex = 0;
            radMenu1.ThemeName = "VisualStudio2022Dark";
            // 
            // menuItem_about_us
            // 
            menuItem_about_us.Image = Properties.Resources.user_16x16;
            menuItem_about_us.Name = "menuItem_about_us";
            menuItem_about_us.Text = "About Us";
            menuItem_about_us.Click += menuItem_about_us_Click;
            // 
            // menuItem_donate
            // 
            menuItem_donate.Image = Properties.Resources.dollar16x16;
            menuItem_donate.Items.AddRange(new Telerik.WinControls.RadItem[] { irDonationBtn, EnDonationBtn });
            menuItem_donate.Name = "menuItem_donate";
            menuItem_donate.Text = "Donate";
            // 
            // irDonationBtn
            // 
            irDonationBtn.Image = Properties.Resources.iran_16x16;
            irDonationBtn.Name = "irDonationBtn";
            irDonationBtn.Text = "Persian speaker";
            irDonationBtn.Click += irDonationBtn_Click;
            // 
            // EnDonationBtn
            // 
            EnDonationBtn.Image = Properties.Resources.United_Kingdom16x16;
            EnDonationBtn.Name = "EnDonationBtn";
            EnDonationBtn.Text = "English speaker";
            EnDonationBtn.Click += EnDonationBtn_Click;
            // 
            // radMenuItem3
            // 
            radMenuItem3.Image = Properties.Resources.git_pull_request16x16;
            radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] { menuItem_github, menuItem_gitlab });
            radMenuItem3.Name = "radMenuItem3";
            radMenuItem3.Text = "Source Code";
            // 
            // menuItem_github
            // 
            menuItem_github.Image = Properties.Resources.github;
            menuItem_github.Name = "menuItem_github";
            menuItem_github.Text = "Github";
            menuItem_github.Click += menuItem_github_Click;
            // 
            // menuItem_gitlab
            // 
            menuItem_gitlab.Image = Properties.Resources.gitlab_icon_rgb;
            menuItem_gitlab.Name = "menuItem_gitlab";
            menuItem_gitlab.Text = "Gitlab";
            menuItem_gitlab.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            menuItem_gitlab.Click += menuItem_gitlab_Click;
            // 
            // bg_worker
            // 
            bg_worker.DoWork += bg_worker_DoWork;
            bg_worker.RunWorkerCompleted += bg_worker_RunWorkerCompleted;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(12, 391);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(110, 24);
            btn_start.TabIndex = 1;
            btn_start.Text = "Start";
            btn_start.ThemeName = "VisualStudio2022Dark";
            btn_start.Click += btn_start_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.BackgroundImage = Properties.Resources.x_circle_21x21;
            btn_exit.BackgroundImageLayout = ImageLayout.Stretch;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Location = new Point(7, 10);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(21, 21);
            btn_exit.TabIndex = 2;
            btn_exit.TabStop = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_minimize
            // 
            btn_minimize.BackColor = Color.Transparent;
            btn_minimize.BackgroundImage = Properties.Resources.minus_circle_21x21;
            btn_minimize.BackgroundImageLayout = ImageLayout.Stretch;
            btn_minimize.Cursor = Cursors.Hand;
            btn_minimize.Location = new Point(34, 10);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(21, 21);
            btn_minimize.TabIndex = 3;
            btn_minimize.TabStop = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(36, 36, 36);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Dock = DockStyle.Fill;
            listBox1.ForeColor = Color.Gold;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(2, 18);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(588, 72);
            listBox1.TabIndex = 4;
            // 
            // radWaitingBar1
            // 
            radWaitingBar1.Location = new Point(128, 391);
            radWaitingBar1.Name = "radWaitingBar1";
            radWaitingBar1.Size = new Size(476, 24);
            radWaitingBar1.TabIndex = 5;
            radWaitingBar1.Text = "radWaitingBar1";
            radWaitingBar1.ThemeName = "VisualStudio2022Dark";
            // 
            // 
            // 
            radWaitingBar1.WaitingBarElement.WaitingIndicatorSize = new Size(100, 14);
            radWaitingBar1.WaitingIndicators.Add(waitingBarIndicatorElement1);
            radWaitingBar1.WaitingIndicators.Add(waitingBarIndicatorElement2);
            radWaitingBar1.WaitingIndicatorSize = new Size(100, 14);
            radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;
            // 
            // waitingBarIndicatorElement1
            // 
            waitingBarIndicatorElement1.Name = "waitingBarIndicatorElement1";
            waitingBarIndicatorElement1.StretchHorizontally = false;
            // 
            // waitingBarIndicatorElement2
            // 
            waitingBarIndicatorElement2.Name = "waitingBarIndicatorElement2";
            waitingBarIndicatorElement2.StretchHorizontally = false;
            // 
            // radGroupBox1
            // 
            radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox1.Controls.Add(listBox1);
            radGroupBox1.HeaderMargin = new Padding(1);
            radGroupBox1.HeaderText = "Monitor";
            radGroupBox1.Location = new Point(12, 421);
            radGroupBox1.Name = "radGroupBox1";
            radGroupBox1.Size = new Size(592, 92);
            radGroupBox1.TabIndex = 6;
            radGroupBox1.Text = "Monitor";
            radGroupBox1.ThemeName = "VisualStudio2022Dark";
            // 
            // Main
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg42;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(616, 547);
            Controls.Add(radGroupBox1);
            Controls.Add(radWaitingBar1);
            Controls.Add(btn_minimize);
            Controls.Add(btn_exit);
            Controls.Add(btn_start);
            Controls.Add(radMenu1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ThemeName = "VisualStudio2022Dark";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)radMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)radWaitingBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).EndInit();
            radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2022DarkTheme visualStudio2022DarkTheme1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem menuItem_about_us;
        private Telerik.WinControls.UI.RadMenuItem menuItem_donate;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem menuItem_github;
        private Telerik.WinControls.UI.RadMenuItem menuItem_gitlab;
        private Telerik.WinControls.UI.RadDesktopAlert desk_alert;
        private System.ComponentModel.BackgroundWorker bg_worker;
        private Telerik.WinControls.UI.RadButton btn_start;
        private PictureBox btn_exit;
        private PictureBox btn_minimize;
        private Telerik.WinControls.UI.RadMenuItem irDonationBtn;
        private Telerik.WinControls.UI.RadMenuItem EnDonationBtn;
        private ListBox listBox1;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement1;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    }
}
