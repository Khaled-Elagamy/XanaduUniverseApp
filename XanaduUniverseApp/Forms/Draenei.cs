using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XanaduUniverseApp.Forms
{
    public partial class Draenei : Form
    {
        static string myName = "Iam Leo from DD species";
        static  string myAncestorName = "NN and ZZ species are my ancestors";
        DD humanoid = new DD(myName, myAncestorName);

        public Draenei()
        {
            InitializeComponent();
        }
        private void Draenei_Load(object sender, EventArgs e)
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

        private void Eat_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("What is Eat?!");
        }

        private void Snore_btn_Click(object sender, EventArgs e)
        {
            humanoid.Snore();
        }

        private void Socialize_btn_Click(object sender, EventArgs e)
        {
            humanoid.Socialize();
            MediaPlayer.URL = "Assets/rick.mp4";

            //MediaPlayer.URL = Properties.Resources.rikc;

        }

        private void MediaPlayer_Enter(object sender, EventArgs e)
        {

        }
    }
}
