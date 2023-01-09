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
        private FormMainMenu MainForm;

        public Elves(FormMainMenu mainform)
        {
            InitializeComponent();
            //Get the main form 
            MainForm = mainform;
            MediaPlayer.uiMode = "none";
            MediaPlayer.settings.volume = volumebar.Value;
            Mainassistant();
        }
        #region Main assistant voice
        private void Mainassistant()
        {
            if (!MainForm.isMuted)
            {
                btns_panel.Visible = false;
                timer.Interval = 8500;
                timer.Tick += (sender, e) =>
                {
                    btns_panel.Visible = true;
                    timer.Dispose();
                };
                MediaPlayer.URL = "Assets/elves/elves-main.mp3";
                timer.Start();
                Play_checker.Start();
            }
        }
        #endregion
        #region Events
        //MediaPlayer pause button
        private void pause_btn_Click(object sender, EventArgs e)
        {
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MediaPlayer.Ctlcontrols.pause();
            }
            else
            {
                MediaPlayer.Ctlcontrols.play();
                Play_checker.Dispose();
            }
        }
        //MediaPlayer volume bar
        private void volumebar_Scroll(object sender, EventArgs e)
        {
            MediaPlayer.settings.volume = volumebar.Value;
            label1.Text = volumebar.Value.ToString() + "%";
        }
        //Humanoid abilites
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
        private void sing_btn_Click(object sender, EventArgs e)
        {
            humanoid.Sing();
            MediaPlayer.URL = humanoid.url;
            media_panel.Visible = true;
        }
        private void Socialize_btn_Click(object sender, EventArgs e)
        {
            humanoid.Socialize();
            MediaPlayer.URL = humanoid.url;
            media_panel.Visible = true;
        }
        //Check the mute button 
        private void Play_checker_Tick(object sender, EventArgs e)
        {
            if (MainForm.isMuted)
            {
                MediaPlayer.Ctlcontrols.pause();
                btns_panel.Visible = true;
                timer.Dispose();
            }
        }
        //Close the form
        private void Elves_clsoe(object sender, FormClosingEventArgs e)
        {
            MediaPlayer.Ctlcontrols.stop();
            Play_checker.Dispose();
        }
        #endregion

      
    }

}
