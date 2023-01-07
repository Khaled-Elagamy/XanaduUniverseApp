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
        static string myName = "Iam Ethan from ZZ species";
        static string myAncestorName = "I dont know my ancestores";
        ZZ humanoid = new ZZ(myName, myAncestorName);

        public Broken()
        {
            InitializeComponent();
        }

        private void Broken_Load(object sender, EventArgs e)
        {
            MediaPlayer.URL = "Assets/test.mp4";
            MediaPlayer.uiMode = "none";
            MediaPlayer.settings.volume = volumebar.Value;
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
        }

        private void Socialize_btn_Click(object sender, EventArgs e)
        {
            humanoid.Socialize();
        }
    }
}
