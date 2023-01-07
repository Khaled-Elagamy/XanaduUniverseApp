using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XanaduUniverseApp.Forms
{
    public partial class Broken : Form
    {
        static string myAncestorName = "I dont know my ancestores";
        ZZ humanoid = new ZZ("Ethan", myAncestorName);
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


        public Broken()
        {
            InitializeComponent();
            timer.Interval = 6500;
            timer.Tick += (sender, e) =>
            {
                btns_panel.Visible = true;
                timer.Dispose();
            };
        }

        private void Broken_Load(object sender, EventArgs e)
        {
            MediaPlayer.URL = "Assets/broken_main.wav";
            MediaPlayer.uiMode = "none";
            MediaPlayer.settings.volume = volumebar.Value;
            timer.Start();

        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MediaPlayer.Ctlcontrols.pause();
            }
            else
            {
                MediaPlayer.Ctlcontrols.play();
            }
        }
        private void volumebar_Scroll(object sender, EventArgs e)
        {
            MediaPlayer.settings.volume = volumebar.Value;
            label2.Text = volumebar.Value.ToString() + "%";
        }

        private void Speak_btn_Click(object sender, EventArgs e)
        {
            humanoid.Speak();
            MediaPlayer.URL = humanoid.url;
            tableLayoutPanel1.Visible = true;
        }

        private void Socialize_btn_Click(object sender, EventArgs e)
        {
            humanoid.Socialize();
            MediaPlayer.URL = humanoid.url;
            tableLayoutPanel1.Visible = true;
            timer.Interval = 2500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Dance_btn.Visible = true;
            Sing_btn.Visible = true;
            timer.Dispose();
        }
        private void Dance_Click(object sender, EventArgs e)
        {
            humanoid.Dance();
            MediaPlayer.URL = humanoid.url;
            tableLayoutPanel1.Visible = true;
        }
        private void Sing_Click(object sender, EventArgs e)
        {
            humanoid.Sing();
            MediaPlayer.URL = humanoid.url;
            tableLayoutPanel1.Visible = true;
        }
    }
}
