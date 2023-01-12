using AxWMPLib;
using Microsoft.Win32;
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

        //Save the mute button value in registry
        private static RegistryKey key = Registry.CurrentUser.CreateSubKey("MyApplication");
        public bool isMuted = Convert.ToBoolean(key.GetValue("IsMuted", false));

        public FormMainMenu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            btncloseform.Visible = false;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //Mute button 
            if (!isMuted)
            {
                mainassistant();
            }
            else
            {
                Mute_btn.Image = Resources.mute;
            }
        }
        //To make the MainWindow drag moveable 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods

        #region Assistant voice
        //Main assistant voice
        private void mainassistant()
        {
            Thread.Sleep(1000);
            player.SoundLocation = "Assets/mainassistant.wav";
            player.Play();
            timer.Interval = 8000;
            var counter = 0;
            panelDesktopPanel.BackgroundImage = Properties.Resources.Assist_pic;
            panelmenu.Visible = false;
            timer.Tick += (sender, e) =>
            {
                panelmenu.Visible = true;
                foreach (Control initialBtn in panelmenu.Controls)
                {
                    if ((string)initialBtn.Tag == "initial")
                    {
                        if (initialBtn.BackColor == Color.FromArgb(51, 51, 76))
                        {
                            initialBtn.BackColor = Color.FromArgb(63, 63, 90);
                        }
                        else
                        {
                            counter++;
                            initialBtn.BackColor = Color.FromArgb(51, 51, 76);
                        }
                        timer.Interval = 500;
                    }
                }
                if (counter > 12)
                {
                    panelDesktopPanel.BackgroundImage = Properties.Resources.Humanoid_group;
                    timer.Dispose();
                }
            };
            timer.Start();
        }
        #endregion
        #region Highlight buttons
        //Highlight the button of the active form
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
        //Reset the highlights of the buttons of forms
        private void DisableButton()
        {
            foreach (Control initialBtn in panelmenu.Controls)
            {
                if ((string)initialBtn.Tag == "initial")
                {
                    initialBtn.BackColor = Color.FromArgb(51, 51, 76);
                    initialBtn.ForeColor = Color.Gainsboro;
                    initialBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        #endregion
        #region OpenForm
        //Open the form
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
        #endregion
        #region Forms-Buttons
        private void btnElves_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Elves(this), sender);

           // if (timer.Enabled == true) { DisableButton(); }
        }
        private void btnDraenei_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Draenei(this), sender);
        }
        private void btnBroken_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Broken(this), sender);
        }
        private void btnGnoll_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Gnoll(this), sender);
        }
        #endregion

        #region Events
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
            if (!isMuted)
            {
                player.SoundLocation = "Assets/assisstantleaving.wav";

                player.PlaySync();
            }
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
        private void mute_btn_Click(object sender, EventArgs e)
        {
            isMuted = !isMuted;
            if (isMuted)
            {
                Mute_btn.Image = Resources.mute;
                if (player.IsLoadCompleted == true)
                {
                    player.Stop();
                    player.Dispose();
                    timer.Dispose();
                    panelmenu.Visible = true;
                    panelDesktopPanel.BackgroundImage = Properties.Resources.Humanoid_group;
                }
            }
            else
            {
                Mute_btn.Image = Resources.mute_gif;
            }
        }
        private void close(object sender, FormClosedEventArgs e)
        {
            key.SetValue("IsMuted", isMuted);
        }
        #endregion
    }
}
