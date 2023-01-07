using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XanaduUniverseApp.Forms
{
    public partial class Elves : Form
    {
        static string myAncestorName = "I dont know my ancestores";
        YY humanoid = new YY("Leo", myAncestorName);
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


        public Elves()
        {
            InitializeComponent();

            timer.Interval = 8500;
            timer.Tick += (sender, e) =>
            {
                btns_panel.Visible = true;
                timer.Dispose();
            };

        }
        private void Elves_Load(object sender, EventArgs e)
        {
            MediaPlayer.URL = "Assets/elves-main.mp3";
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
            label1.Text = volumebar.Value.ToString() + "%";
        }

        private void Eat_btn_Click(object sender, EventArgs e)
        {
            humanoid.Eat();
            MediaPlayer.URL = humanoid.url;
            media_panel.Visible = true;


        }
        private void Speak_btn_Click(object sender, EventArgs e)
        {
            humanoid.Speak();
            MediaPlayer.URL = humanoid.url;
            media_panel.Visible = true;

        }

        private void Socialize_btn_Click(object sender, EventArgs e)
        {
            humanoid.Socialize();
            MediaPlayer.URL = humanoid.url;
            media_panel.Visible = true;
        }
        private void sing_btn_Click(object sender, EventArgs e)
        {
            humanoid.Sing();
            MediaPlayer.URL = humanoid.url;
            media_panel.Visible = true;
        }
        private void Elves_clsoe(object sender, FormClosingEventArgs e)
        {
            MediaPlayer.Ctlcontrols.stop();

        }

    }

}
