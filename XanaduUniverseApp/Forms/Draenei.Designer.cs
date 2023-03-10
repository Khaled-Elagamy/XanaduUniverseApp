namespace XanaduUniverseApp.Forms
{
    partial class Draenei
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Draenei));
            this.label2 = new System.Windows.Forms.Label();
            this.volumebar = new System.Windows.Forms.TrackBar();
            this.mediapanel = new System.Windows.Forms.Panel();
            this.pause_btn = new System.Windows.Forms.PictureBox();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.media_panel = new System.Windows.Forms.TableLayoutPanel();
            this.btns_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Speak_btn = new System.Windows.Forms.Button();
            this.writecode_btn = new System.Windows.Forms.Button();
            this.Dance_btn = new System.Windows.Forms.Button();
            this.Snore_btn = new System.Windows.Forms.Button();
            this.Socialize_btn = new System.Windows.Forms.Button();
            this.Sing_btn = new System.Windows.Forms.Button();
            this.Play_checker = new System.Windows.Forms.Timer(this.components);
            this.About_label = new System.Windows.Forms.Label();
            this.humanoid_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.volumebar)).BeginInit();
            this.mediapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pause_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.media_panel.SuspendLayout();
            this.btns_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humanoid_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(170, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "50 %";
            // 
            // volumebar
            // 
            this.volumebar.BackColor = System.Drawing.Color.DarkCyan;
            this.volumebar.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.volumebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.volumebar.Location = new System.Drawing.Point(49, 0);
            this.volumebar.Maximum = 100;
            this.volumebar.Name = "volumebar";
            this.volumebar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.volumebar.Size = new System.Drawing.Size(121, 45);
            this.volumebar.TabIndex = 21;
            this.volumebar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumebar.Value = 50;
            this.volumebar.Scroll += new System.EventHandler(this.volumebar_Scroll);
            // 
            // mediapanel
            // 
            this.mediapanel.Controls.Add(this.volumebar);
            this.mediapanel.Controls.Add(this.pause_btn);
            this.mediapanel.Controls.Add(this.label2);
            this.mediapanel.Location = new System.Drawing.Point(3, 270);
            this.mediapanel.Name = "mediapanel";
            this.mediapanel.Size = new System.Drawing.Size(214, 50);
            this.mediapanel.TabIndex = 23;
            // 
            // pause_btn
            // 
            this.pause_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pause_btn.Image = global::XanaduUniverseApp.Properties.Resources.play_pause;
            this.pause_btn.Location = new System.Drawing.Point(0, 0);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(49, 50);
            this.pause_btn.TabIndex = 20;
            this.pause_btn.TabStop = false;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(3, 3);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(423, 261);
            this.MediaPlayer.TabIndex = 19;
            // 
            // media_panel
            // 
            this.media_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.media_panel.BackColor = System.Drawing.Color.Transparent;
            this.media_panel.ColumnCount = 1;
            this.media_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.media_panel.Controls.Add(this.mediapanel, 0, 1);
            this.media_panel.Controls.Add(this.MediaPlayer, 0, 0);
            this.media_panel.Location = new System.Drawing.Point(12, 12);
            this.media_panel.Name = "media_panel";
            this.media_panel.RowCount = 2;
            this.media_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.90476F));
            this.media_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.09524F));
            this.media_panel.Size = new System.Drawing.Size(429, 326);
            this.media_panel.TabIndex = 24;
            this.media_panel.Visible = false;
            // 
            // btns_panel
            // 
            this.btns_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btns_panel.Controls.Add(this.Speak_btn);
            this.btns_panel.Controls.Add(this.writecode_btn);
            this.btns_panel.Controls.Add(this.Dance_btn);
            this.btns_panel.Controls.Add(this.Snore_btn);
            this.btns_panel.Controls.Add(this.Socialize_btn);
            this.btns_panel.Controls.Add(this.Sing_btn);
            this.btns_panel.Location = new System.Drawing.Point(529, 15);
            this.btns_panel.Name = "btns_panel";
            this.btns_panel.Size = new System.Drawing.Size(140, 223);
            this.btns_panel.TabIndex = 29;
            // 
            // Speak_btn
            // 
            this.Speak_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Speak_btn.FlatAppearance.BorderSize = 0;
            this.Speak_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Speak_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.Speak_btn.Image = global::XanaduUniverseApp.Properties.Resources.Speak;
            this.Speak_btn.Location = new System.Drawing.Point(3, 3);
            this.Speak_btn.Name = "Speak_btn";
            this.Speak_btn.Size = new System.Drawing.Size(59, 58);
            this.Speak_btn.TabIndex = 8;
            this.Speak_btn.UseVisualStyleBackColor = true;
            this.Speak_btn.Click += new System.EventHandler(this.Speak_btn_Click);
            // 
            // writecode_btn
            // 
            this.writecode_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.writecode_btn.FlatAppearance.BorderSize = 0;
            this.writecode_btn.Image = global::XanaduUniverseApp.Properties.Resources.code;
            this.writecode_btn.Location = new System.Drawing.Point(68, 3);
            this.writecode_btn.Name = "writecode_btn";
            this.writecode_btn.Size = new System.Drawing.Size(59, 58);
            this.writecode_btn.TabIndex = 11;
            this.writecode_btn.UseVisualStyleBackColor = true;
            this.writecode_btn.Click += new System.EventHandler(this.writecode_btn_Click);
            // 
            // Dance_btn
            // 
            this.Dance_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Dance_btn.FlatAppearance.BorderSize = 0;
            this.Dance_btn.Image = global::XanaduUniverseApp.Properties.Resources.dance;
            this.Dance_btn.Location = new System.Drawing.Point(3, 67);
            this.Dance_btn.Name = "Dance_btn";
            this.Dance_btn.Size = new System.Drawing.Size(59, 58);
            this.Dance_btn.TabIndex = 9;
            this.Dance_btn.UseVisualStyleBackColor = true;
            this.Dance_btn.Click += new System.EventHandler(this.Dance_btn_Click);
            // 
            // Snore_btn
            // 
            this.Snore_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Snore_btn.FlatAppearance.BorderSize = 0;
            this.Snore_btn.Image = global::XanaduUniverseApp.Properties.Resources.snore;
            this.Snore_btn.Location = new System.Drawing.Point(68, 67);
            this.Snore_btn.Name = "Snore_btn";
            this.Snore_btn.Size = new System.Drawing.Size(59, 58);
            this.Snore_btn.TabIndex = 12;
            this.Snore_btn.UseVisualStyleBackColor = true;
            this.Snore_btn.Click += new System.EventHandler(this.Snore_btn_Click);
            // 
            // Socialize_btn
            // 
            this.Socialize_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Socialize_btn.FlatAppearance.BorderSize = 0;
            this.Socialize_btn.Image = global::XanaduUniverseApp.Properties.Resources.Socialize;
            this.Socialize_btn.Location = new System.Drawing.Point(3, 131);
            this.Socialize_btn.Name = "Socialize_btn";
            this.Socialize_btn.Size = new System.Drawing.Size(59, 58);
            this.Socialize_btn.TabIndex = 3;
            this.Socialize_btn.UseVisualStyleBackColor = true;
            this.Socialize_btn.Click += new System.EventHandler(this.Socialize_btn_Click);
            // 
            // Sing_btn
            // 
            this.Sing_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Sing_btn.FlatAppearance.BorderSize = 0;
            this.Sing_btn.Image = global::XanaduUniverseApp.Properties.Resources.sing;
            this.Sing_btn.Location = new System.Drawing.Point(68, 131);
            this.Sing_btn.Name = "Sing_btn";
            this.Sing_btn.Size = new System.Drawing.Size(59, 58);
            this.Sing_btn.TabIndex = 10;
            this.Sing_btn.UseVisualStyleBackColor = true;
            this.Sing_btn.Visible = false;
            this.Sing_btn.Click += new System.EventHandler(this.Sing_btn_Click);
            // 
            // Play_checker
            // 
            this.Play_checker.Tick += new System.EventHandler(this.Play_checker_Tick);
            // 
            // About_label
            // 
            this.About_label.AutoSize = true;
            this.About_label.BackColor = System.Drawing.SystemColors.InfoText;
            this.About_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_label.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_label.ForeColor = System.Drawing.Color.White;
            this.About_label.Location = new System.Drawing.Point(12, 245);
            this.About_label.MaximumSize = new System.Drawing.Size(700, 0);
            this.About_label.Name = "About_label";
            this.About_label.Size = new System.Drawing.Size(0, 20);
            this.About_label.TabIndex = 31;
            // 
            // humanoid_pic
            // 
            this.humanoid_pic.Image = global::XanaduUniverseApp.Properties.Resources.Draenei_pic;
            this.humanoid_pic.Location = new System.Drawing.Point(12, 12);
            this.humanoid_pic.Name = "humanoid_pic";
            this.humanoid_pic.Size = new System.Drawing.Size(230, 230);
            this.humanoid_pic.TabIndex = 32;
            this.humanoid_pic.TabStop = false;
            // 
            // Draenei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.media_panel);
            this.Controls.Add(this.About_label);
            this.Controls.Add(this.btns_panel);
            this.Controls.Add(this.humanoid_pic);
            this.Name = "Draenei";
            this.Text = "Draenei";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Darenei_close);
            ((System.ComponentModel.ISupportInitialize)(this.volumebar)).EndInit();
            this.mediapanel.ResumeLayout(false);
            this.mediapanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pause_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.media_panel.ResumeLayout(false);
            this.btns_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.humanoid_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar volumebar;
        private System.Windows.Forms.PictureBox pause_btn;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Panel mediapanel;
        private System.Windows.Forms.TableLayoutPanel media_panel;
        private System.Windows.Forms.FlowLayoutPanel btns_panel;
        private System.Windows.Forms.Button Speak_btn;
        private System.Windows.Forms.Button writecode_btn;
        private System.Windows.Forms.Button Dance_btn;
        private System.Windows.Forms.Button Socialize_btn;
        private System.Windows.Forms.Button Sing_btn;
        private System.Windows.Forms.Button Snore_btn;
        private System.Windows.Forms.Timer Play_checker;
        private System.Windows.Forms.Label About_label;
        private System.Windows.Forms.PictureBox humanoid_pic;
    }
}