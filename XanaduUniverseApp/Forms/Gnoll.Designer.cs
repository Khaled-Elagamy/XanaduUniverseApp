namespace XanaduUniverseApp.Forms
{
    partial class Gnoll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gnoll));
            this.label2 = new System.Windows.Forms.Label();
            this.volumebar = new System.Windows.Forms.TrackBar();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.writecode_btn = new System.Windows.Forms.Button();
            this.Socialize_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.volumebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(205, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "50 %";
            // 
            // volumebar
            // 
            this.volumebar.BackColor = System.Drawing.SystemColors.Control;
            this.volumebar.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.volumebar.Location = new System.Drawing.Point(93, 253);
            this.volumebar.Maximum = 100;
            this.volumebar.Name = "volumebar";
            this.volumebar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.volumebar.Size = new System.Drawing.Size(115, 45);
            this.volumebar.TabIndex = 21;
            this.volumebar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumebar.Value = 50;
            this.volumebar.Scroll += new System.EventHandler(this.volumebar_Scroll);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(12, 12);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(379, 235);
            this.MediaPlayer.TabIndex = 19;
            // 
            // writecode_btn
            // 
            this.writecode_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.writecode_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.writecode_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.writecode_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.writecode_btn.Location = new System.Drawing.Point(551, 117);
            this.writecode_btn.Name = "writecode_btn";
            this.writecode_btn.Size = new System.Drawing.Size(112, 54);
            this.writecode_btn.TabIndex = 18;
            this.writecode_btn.Text = "WriteCode";
            this.writecode_btn.UseVisualStyleBackColor = true;
            this.writecode_btn.Click += new System.EventHandler(this.writecode_btn_Click);
            // 
            // Socialize_btn
            // 
            this.Socialize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Socialize_btn.Location = new System.Drawing.Point(551, 188);
            this.Socialize_btn.Name = "Socialize_btn";
            this.Socialize_btn.Size = new System.Drawing.Size(112, 54);
            this.Socialize_btn.TabIndex = 16;
            this.Socialize_btn.Text = "Socialize";
            this.Socialize_btn.UseVisualStyleBackColor = true;
            this.Socialize_btn.Click += new System.EventHandler(this.Socialize_btn_Click);
            // 
            // pause_btn
            // 
            this.pause_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause_btn.Image = global::XanaduUniverseApp.Properties.Resources.play_pause;
            this.pause_btn.Location = new System.Drawing.Point(12, 253);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(49, 45);
            this.pause_btn.TabIndex = 20;
            this.pause_btn.TabStop = false;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // Gnoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.volumebar);
            this.Controls.Add(this.pause_btn);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.writecode_btn);
            this.Controls.Add(this.Socialize_btn);
            this.Name = "Gnoll";
            this.Text = "Gnoll";
            this.Load += new System.EventHandler(this.Gnoll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar volumebar;
        private System.Windows.Forms.PictureBox pause_btn;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Button writecode_btn;
        private System.Windows.Forms.Button Socialize_btn;
    }
}