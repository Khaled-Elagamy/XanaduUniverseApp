namespace XanaduUniverseApp
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.Mute_btn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bntMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btncloseform = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnElves = new System.Windows.Forms.Button();
            this.btnBroken = new System.Windows.Forms.Button();
            this.btnGnoll = new System.Windows.Forms.Button();
            this.btnDraenei = new System.Windows.Forms.Button();
            this.panelTitleBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelTitleBar.Controls.Add(this.Mute_btn);
            this.panelTitleBar.Controls.Add(this.panelLogo);
            this.panelTitleBar.Controls.Add(this.bntMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btncloseform);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(882, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // Mute_btn
            // 
            this.Mute_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mute_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.Mute_btn.FlatAppearance.BorderSize = 0;
            this.Mute_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mute_btn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mute_btn.Image = global::XanaduUniverseApp.Properties.Resources.mute_gif;
            this.Mute_btn.Location = new System.Drawing.Point(633, 22);
            this.Mute_btn.Name = "Mute_btn";
            this.Mute_btn.Size = new System.Drawing.Size(56, 33);
            this.Mute_btn.TabIndex = 3;
            this.Mute_btn.UseVisualStyleBackColor = false;
            this.Mute_btn.Click += new System.EventHandler(this.mute_btn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xanadu Universe";
            // 
            // bntMinimize
            // 
            this.bntMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.bntMinimize.FlatAppearance.BorderSize = 0;
            this.bntMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMinimize.Image = ((System.Drawing.Image)(resources.GetObject("bntMinimize.Image")));
            this.bntMinimize.Location = new System.Drawing.Point(771, 12);
            this.bntMinimize.Name = "bntMinimize";
            this.bntMinimize.Size = new System.Drawing.Size(30, 24);
            this.bntMinimize.TabIndex = 2;
            this.bntMinimize.UseVisualStyleBackColor = false;
            this.bntMinimize.Click += new System.EventHandler(this.bntMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::XanaduUniverseApp.Properties.Resources.maximize_btn;
            this.btnMaximize.Location = new System.Drawing.Point(805, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(28, 24);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::XanaduUniverseApp.Properties.Resources.close_btn;
            this.btnClose.Location = new System.Drawing.Point(830, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btncloseform
            // 
            this.btncloseform.FlatAppearance.BorderSize = 0;
            this.btncloseform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncloseform.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncloseform.Image = global::XanaduUniverseApp.Properties.Resources.return_btn;
            this.btncloseform.Location = new System.Drawing.Point(219, 23);
            this.btncloseform.Name = "btncloseform";
            this.btncloseform.Size = new System.Drawing.Size(43, 34);
            this.btncloseform.TabIndex = 0;
            this.btncloseform.UseVisualStyleBackColor = true;
            this.btncloseform.Click += new System.EventHandler(this.btncloseform_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(388, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(78, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(0, 75);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(882, 443);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelmenu.Controls.Add(this.btnElves);
            this.panelmenu.Controls.Add(this.btnBroken);
            this.panelmenu.Controls.Add(this.btnGnoll);
            this.panelmenu.Controls.Add(this.btnDraenei);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelmenu.Location = new System.Drawing.Point(0, 466);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(882, 52);
            this.panelmenu.TabIndex = 3;
            // 
            // btnElves
            // 
            this.btnElves.FlatAppearance.BorderSize = 0;
            this.btnElves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElves.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElves.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnElves.Location = new System.Drawing.Point(450, 0);
            this.btnElves.Name = "btnElves";
            this.btnElves.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnElves.Size = new System.Drawing.Size(131, 52);
            this.btnElves.TabIndex = 1;
            this.btnElves.Tag = "initial";
            this.btnElves.Text = "Elves";
            this.btnElves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnElves.UseVisualStyleBackColor = true;
            this.btnElves.Click += new System.EventHandler(this.btnElves_Click);
            // 
            // btnBroken
            // 
            this.btnBroken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnBroken.FlatAppearance.BorderSize = 0;
            this.btnBroken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBroken.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBroken.Location = new System.Drawing.Point(300, 0);
            this.btnBroken.Name = "btnBroken";
            this.btnBroken.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBroken.Size = new System.Drawing.Size(131, 52);
            this.btnBroken.TabIndex = 3;
            this.btnBroken.Tag = "initial";
            this.btnBroken.Text = "Broken";
            this.btnBroken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBroken.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBroken.UseVisualStyleBackColor = false;
            this.btnBroken.Click += new System.EventHandler(this.btnBroken_Click);
            // 
            // btnGnoll
            // 
            this.btnGnoll.FlatAppearance.BorderSize = 0;
            this.btnGnoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGnoll.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGnoll.Location = new System.Drawing.Point(150, 0);
            this.btnGnoll.Name = "btnGnoll";
            this.btnGnoll.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGnoll.Size = new System.Drawing.Size(131, 52);
            this.btnGnoll.TabIndex = 4;
            this.btnGnoll.Tag = "initial";
            this.btnGnoll.Text = "Gnoll";
            this.btnGnoll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGnoll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGnoll.UseVisualStyleBackColor = true;
            this.btnGnoll.Click += new System.EventHandler(this.btnGnoll_Click);
            // 
            // btnDraenei
            // 
            this.btnDraenei.FlatAppearance.BorderSize = 0;
            this.btnDraenei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraenei.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDraenei.Location = new System.Drawing.Point(0, 0);
            this.btnDraenei.Name = "btnDraenei";
            this.btnDraenei.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDraenei.Size = new System.Drawing.Size(131, 52);
            this.btnDraenei.TabIndex = 2;
            this.btnDraenei.Tag = "initial";
            this.btnDraenei.Text = "Draenei";
            this.btnDraenei.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDraenei.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDraenei.UseVisualStyleBackColor = true;
            this.btnDraenei.Click += new System.EventHandler(this.btnDraenei_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(882, 518);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.close);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button bntMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button btnElves;
        private System.Windows.Forms.Button btnBroken;
        private System.Windows.Forms.Button btnGnoll;
        private System.Windows.Forms.Button btnDraenei;
        private System.Windows.Forms.Button btncloseform;
        private System.Windows.Forms.Button Mute_btn;
    }
}

