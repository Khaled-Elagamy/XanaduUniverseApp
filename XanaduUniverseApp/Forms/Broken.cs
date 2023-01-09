using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
        private FormMainMenu MainForm;


        public Broken(FormMainMenu mainForm)
        {
            InitializeComponent();
            //Get the main form 
            MainForm = mainForm;
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
                timer.Interval = 4500;
                timer.Tick += (sender, e) =>
                {
                    btns_panel.Visible = true;
                    timer.Dispose();
                };
                MediaPlayer.URL = "Assets/broken/broken_main.wav";
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
        private void volumebar_Scroll(object sender, EventArgs e)
        {
            MediaPlayer.settings.volume = volumebar.Value;
            label2.Text = volumebar.Value.ToString() + "%";
        }
        //Humanoid abilites
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
            timer.Interval = 2500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        //Socialize show btns
        private void Timer_Tick(object sender, EventArgs e)
        {
            Dance_btn.Visible = true;
            Sing_btn.Visible = true;
            timer.Dispose();
        }
        private void Dance_Click(object sender, EventArgs e)
        {
            humanoid.Dance();
            MediaPlayer.URL = "Assets/broken/broken_dance.mp4";
            media_panel.Visible = true;
        }
        private void Sing_Click(object sender, EventArgs e)
        {
            humanoid.Sing();
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
        private void Broken_Close(object sender, FormClosingEventArgs e)
        {
            Play_checker.Dispose();
        }
        #endregion
    }
}
