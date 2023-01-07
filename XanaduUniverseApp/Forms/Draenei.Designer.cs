﻿namespace XanaduUniverseApp.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Draenei));
            this.label2 = new System.Windows.Forms.Label();
            this.volumebar = new System.Windows.Forms.TrackBar();
            this.Snore_btn = new System.Windows.Forms.Button();
            this.Eat_btn = new System.Windows.Forms.Button();
            this.Socialize_btn = new System.Windows.Forms.Button();
            this.mediapanel = new System.Windows.Forms.Panel();
            this.pause_btn = new System.Windows.Forms.PictureBox();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.volumebar)).BeginInit();
            this.mediapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pause_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            // Snore_btn
            // 
            this.Snore_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Snore_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Snore_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Snore_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.Snore_btn.Location = new System.Drawing.Point(507, 123);
            this.Snore_btn.Name = "Snore_btn";
            this.Snore_btn.Size = new System.Drawing.Size(112, 54);
            this.Snore_btn.TabIndex = 18;
            this.Snore_btn.Text = "Snore";
            this.Snore_btn.UseVisualStyleBackColor = true;
            this.Snore_btn.Click += new System.EventHandler(this.Snore_btn_Click);
            // 
            // Eat_btn
            // 
            this.Eat_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Eat_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Eat_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Eat_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.Eat_btn.Location = new System.Drawing.Point(507, 47);
            this.Eat_btn.Name = "Eat_btn";
            this.Eat_btn.Size = new System.Drawing.Size(112, 54);
            this.Eat_btn.TabIndex = 17;
            this.Eat_btn.Text = "Eat";
            this.Eat_btn.UseVisualStyleBackColor = true;
            this.Eat_btn.Click += new System.EventHandler(this.Eat_btn_Click);
            // 
            // Socialize_btn
            // 
            this.Socialize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Socialize_btn.Location = new System.Drawing.Point(507, 194);
            this.Socialize_btn.Name = "Socialize_btn";
            this.Socialize_btn.Size = new System.Drawing.Size(112, 54);
            this.Socialize_btn.TabIndex = 16;
            this.Socialize_btn.Text = "Socialize";
            this.Socialize_btn.UseVisualStyleBackColor = true;
            this.Socialize_btn.Click += new System.EventHandler(this.Socialize_btn_Click);
            // 
            // mediapanel
            // 
            this.mediapanel.Controls.Add(this.volumebar);
            this.mediapanel.Controls.Add(this.pause_btn);
            this.mediapanel.Controls.Add(this.label2);
            this.mediapanel.Location = new System.Drawing.Point(3, 253);
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
            this.MediaPlayer.Size = new System.Drawing.Size(423, 244);
            this.MediaPlayer.TabIndex = 19;
            this.MediaPlayer.Enter += new System.EventHandler(this.MediaPlayer_Enter);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 326);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // Draenei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Snore_btn);
            this.Controls.Add(this.Eat_btn);
            this.Controls.Add(this.Socialize_btn);
            this.Name = "Draenei";
            this.Text = "Draenei";
            this.Load += new System.EventHandler(this.Draenei_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumebar)).EndInit();
            this.mediapanel.ResumeLayout(false);
            this.mediapanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pause_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar volumebar;
        private System.Windows.Forms.PictureBox pause_btn;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Button Snore_btn;
        private System.Windows.Forms.Button Eat_btn;
        private System.Windows.Forms.Button Socialize_btn;
        private System.Windows.Forms.Panel mediapanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}