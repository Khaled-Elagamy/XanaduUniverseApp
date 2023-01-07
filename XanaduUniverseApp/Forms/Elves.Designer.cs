namespace XanaduUniverseApp.Forms
{
    partial class Elves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elves));
            this.Speak_btn = new System.Windows.Forms.Button();
            this.Eat_btn = new System.Windows.Forms.Button();
            this.Socialize_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mediapanel = new System.Windows.Forms.Panel();
            this.volumebar = new System.Windows.Forms.TrackBar();
            this.pause_btn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btns_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.mediapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.btns_panel.SuspendLayout();
            this.SuspendLayout();
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
            // Eat_btn
            // 
            this.Eat_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Eat_btn.FlatAppearance.BorderSize = 0;
            this.Eat_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Eat_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.Eat_btn.Image = global::XanaduUniverseApp.Properties.Resources.Eat;
            this.Eat_btn.Location = new System.Drawing.Point(3, 131);
            this.Eat_btn.Name = "Eat_btn";
            this.Eat_btn.Size = new System.Drawing.Size(59, 58);
            this.Eat_btn.TabIndex = 7;
            this.Eat_btn.UseVisualStyleBackColor = true;
            this.Eat_btn.Click += new System.EventHandler(this.Eat_btn_Click);
            // 
            // Socialize_btn
            // 
            this.Socialize_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Socialize_btn.FlatAppearance.BorderSize = 0;
            this.Socialize_btn.Image = global::XanaduUniverseApp.Properties.Resources.Socialize;
            this.Socialize_btn.Location = new System.Drawing.Point(3, 67);
            this.Socialize_btn.Name = "Socialize_btn";
            this.Socialize_btn.Size = new System.Drawing.Size(59, 58);
            this.Socialize_btn.TabIndex = 3;
            this.Socialize_btn.UseVisualStyleBackColor = true;
            this.Socialize_btn.Click += new System.EventHandler(this.Socialize_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mediapanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MediaPlayer, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.90476F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.09524F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 326);
            this.tableLayoutPanel1.TabIndex = 25;
            this.tableLayoutPanel1.Visible = false;
            // 
            // mediapanel
            // 
            this.mediapanel.Controls.Add(this.volumebar);
            this.mediapanel.Controls.Add(this.pause_btn);
            this.mediapanel.Controls.Add(this.label1);
            this.mediapanel.Location = new System.Drawing.Point(3, 270);
            this.mediapanel.Name = "mediapanel";
            this.mediapanel.Size = new System.Drawing.Size(214, 50);
            this.mediapanel.TabIndex = 23;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(170, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "50 %";
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
            // btns_panel
            // 
            this.btns_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btns_panel.Controls.Add(this.Speak_btn);
            this.btns_panel.Controls.Add(this.Socialize_btn);
            this.btns_panel.Controls.Add(this.Eat_btn);
            this.btns_panel.Location = new System.Drawing.Point(520, 15);
            this.btns_panel.Name = "btns_panel";
            this.btns_panel.Size = new System.Drawing.Size(65, 250);
            this.btns_panel.TabIndex = 26;
            this.btns_panel.Visible = false;
            // 
            // Elves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btns_panel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Elves";
            this.Text = "Elves";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Elves_clsoe);
            this.Load += new System.EventHandler(this.Elves_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mediapanel.ResumeLayout(false);
            this.mediapanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.btns_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Socialize_btn;
        private System.Windows.Forms.Button Eat_btn;
        private System.Windows.Forms.Button Speak_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Panel mediapanel;
        private System.Windows.Forms.TrackBar volumebar;
        private System.Windows.Forms.PictureBox pause_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel btns_panel;
    }
}