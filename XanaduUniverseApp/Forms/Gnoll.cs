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
    public partial class Gnoll : Form
    {
        static string myAncestorName = "ZZ species are my ancestors";
        NN humanoid = new NN("Mia", myAncestorName);
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Gnoll()
        {
            InitializeComponent();
            timer.Interval = 4500;
            timer.Tick += (sender, e) =>
            {
                btns_panel.Visible = true;
                timer.Dispose();
            };
        }

        private void Gnoll_Load(object sender, EventArgs e)
        {
            MediaPlayer.URL = "Assets/Gnoll_main.mp3";
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
        private void writecode_btn_Click(object sender, EventArgs e)
        {
            humanoid.WriteCode();
        }
        private void Socialize_btn_Click(object sender, EventArgs e)
        {
            humanoid.Socialize();
            MediaPlayer.URL = humanoid.url;
            media_panel.Visible = true;
            timer.Interval = 2500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Sing_btn.Visible = true;
            timer.Dispose();
        }

        private void Speak_btn_Click(object sender, EventArgs e)
        {
            humanoid.Speak();
            MediaPlayer.URL = "Assets/Gnoll_french.mp3";
            media_panel.Visible = true;
        }

        private void Dance_btn_Click(object sender, EventArgs e)
        {
            humanoid.Dance();
            MediaPlayer.URL = humanoid.url;
            media_panel.Visible = true;
        }

        private void Sing_btn_Click(object sender, EventArgs e)
        {
            humanoid.Sing();
            MediaPlayer.URL = humanoid.url;
            media_panel.Visible = true;
        }
    }
}
