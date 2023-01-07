using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using XanaduUniverseApp.Forms;
using XanaduUniverseApp.Properties;

namespace XanaduUniverseApp
{
    public partial class FormMainMenu : Form
    {
        //Fields

        private Button currentButton;
        private Form activeForm;
        private static SoundPlayer player = new SoundPlayer();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        //Constructor

        public FormMainMenu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            btncloseform.Visible = false;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            mainassistant();

            foreach (Control initialBtn in panelmenu.Controls)
            {
                if ((string)initialBtn.Tag == "initial")
                {
                    initialBtn.Visible = false;
                }
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods

        private void mainassistant()
        {
            Thread.Sleep(1000);
            player.SoundLocation = "Assets/mainassistant.wav";
            player.Play();
            timer.Interval = 8000;
            var counter = 0;
            panelmenu.Visible = false;
            timer.Tick += (sender, e) =>
            {
                foreach (Control initialBtn in panelmenu.Controls)
                {
                    if ((string)initialBtn.Tag == "initial")
                    {
                        initialBtn.Visible = true;
                        panelmenu.Visible = true;
                        // if (initialBtn.Visible == true)
                        if ( initialBtn.BackColor == Color.FromArgb(51, 51, 76))
                        {
                            //initialBtn.Visible = false;
                            initialBtn.BackColor = Color.FromArgb(63, 63, 90);
                        }
                        else
                        {
                            //initialBtn.Visible = true;
                            counter++;
                            initialBtn.BackColor = Color.FromArgb(51, 51, 76);
                        }
                        timer.Interval =500;
                    }
                }
                if (counter > 12)
                {
                    timer.Dispose();
                }
            };
            timer.Start();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Tai Le", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentButton.BackColor = Color.FromArgb(26, 26, 45);
                    btncloseform.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control initialBtn in panelmenu.Controls)
            {
                //if (previousBtn.GetType() == typeof(Button))
                if ((string)initialBtn.Tag == "initial")
                {
                    initialBtn.BackColor = Color.FromArgb(51, 51, 76);
                    initialBtn.ForeColor = Color.Gainsboro;
                    initialBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
            player.Stop();
        }
        private void btnElves_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Elves(), sender);
            if (timer.Enabled == true) { DisableButton(); }
            // player.SoundLocation = "Assets/elves-main.wav";
            //player.Play();
        }
        private void btnDraenei_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Draenei(), sender);
        }
        private void btnBroken_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Broken(), sender);
        }
        private void btnGnoll_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Gnoll(), sender);
        }
        //Drag moveable
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btncloseform_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
            player.Stop();
        }
        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "Home";
            currentButton = null;
            btncloseform.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            player.SoundLocation = "Assets/assisstantleaving.wav";

            player.PlaySync();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
