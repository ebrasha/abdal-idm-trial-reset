using Abdal_Security_Group_App.Core;
using System.Diagnostics;
using System.Reflection;
using Telerik.WinControls.UI;

namespace Abdal_Security_Group_App
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        private bool stop_op_status = false;
        private string abdal_app_name = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0];
        private AbdalSoundPlayer ab_player = new AbdalSoundPlayer();

        private string abdal_app_name_for_url = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0]
            .ToLower().Replace(' ', '-');


        public Main()
        {
            InitializeComponent();
            //change form title
            Version version = Assembly.GetExecutingAssembly().GetName().Version!;
            Text = abdal_app_name + " " + version.Major + "." + version.Minor;

            // Call Global Chilkat Unlock
            ChilkatMng.UnlockChilkat();
        }

        #region Dragable Form Start

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        #endregion

        private async void Main_Load(object sender, EventArgs e)
        {
            radWaitingBar1.StartWaiting();
            radWaitingBar1.Enabled = true;
            desk_alert.ThemeName = "VisualStudio2022Dark";
            await UpdateChecker.CheckForUpdateAsync();
        }

        private void menuItem_github_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.Start(new ProcessStartInfo("https://github.com/ebrasha/" + abdal_app_name_for_url) { UseShellExecute = true });
        }

        private void menuItem_gitlab_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.Start(new ProcessStartInfo("https://gitlab.com/Prof.Shafiei/" + abdal_app_name_for_url) { UseShellExecute = true });
        }

        private void menuItem_donate_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_about_us_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            about_us about_form = new Abdal_Security_Group_App.about_us();
            about_form.ShowDialog();
            about_form.TopMost = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }

        private void bg_worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Canceled Process By User!";
                this.desk_alert.Show();
                ab_player.sPlayer("cancel");
            }
            else if (e.Error != null)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = e.Error.Message;
                this.desk_alert.Show();


                ab_player.sPlayer("error");
            }
            else
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Done!";
                this.desk_alert.Show();

                if (stop_op_status)
                {
                    ab_player.sPlayerSync("cancel");
                }
                else
                {
                    ab_player.sPlayerSync("op-com");
                }

                ab_player.sPlayer("done");
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (bg_worker.IsBusy != true)
            {
                bg_worker.RunWorkerAsync();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void irDonationBtn_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("coin");
            Process.Start(new ProcessStartInfo("https://alphajet.ir/abdal-donation") { UseShellExecute = true });
        }

        private void EnDonationBtn_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("coin");
            Process.Start(new ProcessStartInfo("https://ebrasha.com/abdal-donation") { UseShellExecute = true });
        }

        private void LoadProcessNames()
        {
            string[] processNames = new string[]
            {
            "The process \"IDMan\" has been successfully terminated.",
            "The process \"IDMIntegrator64\" has been successfully terminated.",
            "The process \"IDMGrHlp\" has been successfully terminated.",
            "The process \"IDMMsgHost\" has been successfully terminated.",
            "The process \"idmBroker\" has been successfully terminated.",
            "The process \"IEMonitor\" has been successfully terminated.",
            "The process \"MediumILStart\" has been successfully terminated."
            };

            foreach (string name in processNames)
            {
                listBox1.Items.Add(name);
            }
        }

        private void bg_worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            
            ProcessTerminator.KillProcessesUntilGone();
            listBox1.Items.Clear();
            LoadProcessNames();
            RegistryCleaner.CleanRegistry();
            listBox1.Items.Add("Registry cleanup completed successfully.");
            listBox1.Items.Add("Internet Download Manager has been successfully reset.");
            listBox1.Items.Add("Enjoy your 30-day free trial period!");
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }



    }
}