
namespace Launcher
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelSideBalk = new System.Windows.Forms.Panel();
            this.panelSubmenu = new System.Windows.Forms.Panel();
            this.panelNavigator = new System.Windows.Forms.Panel();
            this.btnNotes = new System.Windows.Forms.Button();
            this.panelSubmenuTools = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btnThirdSubmenu = new System.Windows.Forms.Button();
            this.panelSubmenuMedia = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.btnSecondSubmenu = new System.Windows.Forms.Button();
            this.panelSubmenuGames = new System.Windows.Forms.Panel();
            this.button22 = new System.Windows.Forms.Button();
            this.btnSingleplayer = new System.Windows.Forms.Button();
            this.btnMultiplayer = new System.Windows.Forms.Button();
            this.btnLauncher = new System.Windows.Forms.Button();
            this.btnFirstSubmenu = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTopBar.SuspendLayout();
            this.panelSideBalk.SuspendLayout();
            this.panelSubmenu.SuspendLayout();
            this.panelSubmenuTools.SuspendLayout();
            this.panelSubmenuMedia.SuspendLayout();
            this.panelSubmenuGames.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelTopBar.Controls.Add(this.btnMinimize);
            this.panelTopBar.Controls.Add(this.btnMaximize);
            this.panelTopBar.Controls.Add(this.btnClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1000, 24);
            this.panelTopBar.TabIndex = 2;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.panelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.panelTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnMinimize.Location = new System.Drawing.Point(910, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 24);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnMaximize.Location = new System.Drawing.Point(940, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 24);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Text = "▢";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnClose.Location = new System.Drawing.Point(970, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 24);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelSideBalk
            // 
            this.panelSideBalk.AutoScroll = true;
            this.panelSideBalk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelSideBalk.Controls.Add(this.panelSubmenu);
            this.panelSideBalk.Controls.Add(this.panelLogo);
            this.panelSideBalk.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBalk.Location = new System.Drawing.Point(0, 24);
            this.panelSideBalk.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelSideBalk.Name = "panelSideBalk";
            this.panelSideBalk.Size = new System.Drawing.Size(249, 476);
            this.panelSideBalk.TabIndex = 3;
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.AutoScroll = true;
            this.panelSubmenu.Controls.Add(this.panelNavigator);
            this.panelSubmenu.Controls.Add(this.btnNotes);
            this.panelSubmenu.Controls.Add(this.panelSubmenuTools);
            this.panelSubmenu.Controls.Add(this.btnThirdSubmenu);
            this.panelSubmenu.Controls.Add(this.panelSubmenuMedia);
            this.panelSubmenu.Controls.Add(this.btnSecondSubmenu);
            this.panelSubmenu.Controls.Add(this.panelSubmenuGames);
            this.panelSubmenu.Controls.Add(this.btnFirstSubmenu);
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 88);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(249, 388);
            this.panelSubmenu.TabIndex = 1;
            // 
            // panelNavigator
            // 
            this.panelNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelNavigator.Location = new System.Drawing.Point(0, 0);
            this.panelNavigator.Name = "panelNavigator";
            this.panelNavigator.Size = new System.Drawing.Size(5, 50);
            this.panelNavigator.TabIndex = 8;
            // 
            // btnNotes
            // 
            this.btnNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotes.FlatAppearance.BorderSize = 0;
            this.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnNotes.Image = global::Launcher.Properties.Resources.Notes_icon;
            this.btnNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotes.Location = new System.Drawing.Point(0, 591);
            this.btnNotes.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(232, 39);
            this.btnNotes.TabIndex = 7;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            this.btnNotes.Leave += new System.EventHandler(this.btnNotes_Leave);
            // 
            // panelSubmenuTools
            // 
            this.panelSubmenuTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelSubmenuTools.Controls.Add(this.button3);
            this.panelSubmenuTools.Controls.Add(this.button4);
            this.panelSubmenuTools.Controls.Add(this.button10);
            this.panelSubmenuTools.Controls.Add(this.button15);
            this.panelSubmenuTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuTools.Location = new System.Drawing.Point(0, 434);
            this.panelSubmenuTools.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelSubmenuTools.Name = "panelSubmenuTools";
            this.panelSubmenuTools.Size = new System.Drawing.Size(232, 157);
            this.panelSubmenuTools.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.button3.Image = global::Launcher.Properties.Resources.Red_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(0, 108);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.button4.Image = global::Launcher.Properties.Resources.Red_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(0, 72);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 36);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.button10.Image = global::Launcher.Properties.Resources.Red_icon;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.Location = new System.Drawing.Point(0, 36);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(232, 36);
            this.button10.TabIndex = 1;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Top;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.button15.Image = global::Launcher.Properties.Resources.Red_icon;
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button15.Location = new System.Drawing.Point(0, 0);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(232, 36);
            this.button15.TabIndex = 0;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // btnThirdSubmenu
            // 
            this.btnThirdSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThirdSubmenu.FlatAppearance.BorderSize = 0;
            this.btnThirdSubmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThirdSubmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThirdSubmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnThirdSubmenu.Image = global::Launcher.Properties.Resources.Tools_icon1;
            this.btnThirdSubmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThirdSubmenu.Location = new System.Drawing.Point(0, 395);
            this.btnThirdSubmenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThirdSubmenu.Name = "btnThirdSubmenu";
            this.btnThirdSubmenu.Size = new System.Drawing.Size(232, 39);
            this.btnThirdSubmenu.TabIndex = 5;
            this.btnThirdSubmenu.Text = " Tools";
            this.btnThirdSubmenu.UseVisualStyleBackColor = true;
            this.btnThirdSubmenu.Click += new System.EventHandler(this.btnThirdSubmenu_Click);
            this.btnThirdSubmenu.Leave += new System.EventHandler(this.btnThirdSubmenu_Leave);
            // 
            // panelSubmenuMedia
            // 
            this.panelSubmenuMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelSubmenuMedia.Controls.Add(this.button17);
            this.panelSubmenuMedia.Controls.Add(this.button18);
            this.panelSubmenuMedia.Controls.Add(this.button19);
            this.panelSubmenuMedia.Controls.Add(this.button20);
            this.panelSubmenuMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuMedia.Location = new System.Drawing.Point(0, 233);
            this.panelSubmenuMedia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelSubmenuMedia.Name = "panelSubmenuMedia";
            this.panelSubmenuMedia.Size = new System.Drawing.Size(232, 162);
            this.panelSubmenuMedia.TabIndex = 4;
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Top;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.button17.Image = global::Launcher.Properties.Resources.Red_icon;
            this.button17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button17.Location = new System.Drawing.Point(0, 108);
            this.button17.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(232, 36);
            this.button17.TabIndex = 3;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Top;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.button18.Image = global::Launcher.Properties.Resources.Red_icon;
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button18.Location = new System.Drawing.Point(0, 72);
            this.button18.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(232, 36);
            this.button18.TabIndex = 2;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Top;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.button19.Image = global::Launcher.Properties.Resources.Red_icon;
            this.button19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button19.Location = new System.Drawing.Point(0, 36);
            this.button19.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(232, 36);
            this.button19.TabIndex = 1;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Dock = System.Windows.Forms.DockStyle.Top;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.button20.Image = global::Launcher.Properties.Resources.Red_icon;
            this.button20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button20.Location = new System.Drawing.Point(0, 0);
            this.button20.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(232, 36);
            this.button20.TabIndex = 0;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // btnSecondSubmenu
            // 
            this.btnSecondSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecondSubmenu.FlatAppearance.BorderSize = 0;
            this.btnSecondSubmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondSubmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSecondSubmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnSecondSubmenu.Image = global::Launcher.Properties.Resources.Logo_icon;
            this.btnSecondSubmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSecondSubmenu.Location = new System.Drawing.Point(0, 194);
            this.btnSecondSubmenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSecondSubmenu.Name = "btnSecondSubmenu";
            this.btnSecondSubmenu.Size = new System.Drawing.Size(232, 39);
            this.btnSecondSubmenu.TabIndex = 1;
            this.btnSecondSubmenu.Text = "Media";
            this.btnSecondSubmenu.UseVisualStyleBackColor = true;
            this.btnSecondSubmenu.Click += new System.EventHandler(this.btnSecondSubmenu_Click);
            this.btnSecondSubmenu.Leave += new System.EventHandler(this.btnSecondSubmenu_Leave);
            // 
            // panelSubmenuGames
            // 
            this.panelSubmenuGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelSubmenuGames.Controls.Add(this.button22);
            this.panelSubmenuGames.Controls.Add(this.btnSingleplayer);
            this.panelSubmenuGames.Controls.Add(this.btnMultiplayer);
            this.panelSubmenuGames.Controls.Add(this.btnLauncher);
            this.panelSubmenuGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuGames.Location = new System.Drawing.Point(0, 39);
            this.panelSubmenuGames.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelSubmenuGames.Name = "panelSubmenuGames";
            this.panelSubmenuGames.Size = new System.Drawing.Size(232, 155);
            this.panelSubmenuGames.TabIndex = 2;
            // 
            // button22
            // 
            this.button22.Dock = System.Windows.Forms.DockStyle.Top;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.button22.Image = global::Launcher.Properties.Resources.Red_icon;
            this.button22.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button22.Location = new System.Drawing.Point(0, 108);
            this.button22.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(232, 36);
            this.button22.TabIndex = 3;
            this.button22.Text = "button22";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // btnSingleplayer
            // 
            this.btnSingleplayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSingleplayer.FlatAppearance.BorderSize = 0;
            this.btnSingleplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSingleplayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnSingleplayer.Image = global::Launcher.Properties.Resources.Singleplayer_icon;
            this.btnSingleplayer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSingleplayer.Location = new System.Drawing.Point(0, 72);
            this.btnSingleplayer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSingleplayer.Name = "btnSingleplayer";
            this.btnSingleplayer.Size = new System.Drawing.Size(232, 36);
            this.btnSingleplayer.TabIndex = 2;
            this.btnSingleplayer.Text = "Singleplayer";
            this.btnSingleplayer.UseVisualStyleBackColor = true;
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMultiplayer.FlatAppearance.BorderSize = 0;
            this.btnMultiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnMultiplayer.Image = global::Launcher.Properties.Resources.Multiplayer_icon;
            this.btnMultiplayer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMultiplayer.Location = new System.Drawing.Point(0, 36);
            this.btnMultiplayer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(232, 36);
            this.btnMultiplayer.TabIndex = 1;
            this.btnMultiplayer.Text = "Multiplayer";
            this.btnMultiplayer.UseVisualStyleBackColor = true;
            // 
            // btnLauncher
            // 
            this.btnLauncher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLauncher.FlatAppearance.BorderSize = 0;
            this.btnLauncher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLauncher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLauncher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnLauncher.Image = global::Launcher.Properties.Resources.Launcher_icon;
            this.btnLauncher.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLauncher.Location = new System.Drawing.Point(0, 0);
            this.btnLauncher.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLauncher.Name = "btnLauncher";
            this.btnLauncher.Size = new System.Drawing.Size(232, 36);
            this.btnLauncher.TabIndex = 0;
            this.btnLauncher.Text = "Launchers";
            this.btnLauncher.UseVisualStyleBackColor = true;
            this.btnLauncher.Click += new System.EventHandler(this.btnLauncher_Click);
            // 
            // btnFirstSubmenu
            // 
            this.btnFirstSubmenu.AllowDrop = true;
            this.btnFirstSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFirstSubmenu.FlatAppearance.BorderSize = 0;
            this.btnFirstSubmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstSubmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFirstSubmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnFirstSubmenu.Image = global::Launcher.Properties.Resources.Game_icon;
            this.btnFirstSubmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirstSubmenu.Location = new System.Drawing.Point(0, 0);
            this.btnFirstSubmenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFirstSubmenu.Name = "btnFirstSubmenu";
            this.btnFirstSubmenu.Size = new System.Drawing.Size(232, 39);
            this.btnFirstSubmenu.TabIndex = 3;
            this.btnFirstSubmenu.Text = "Games";
            this.btnFirstSubmenu.UseVisualStyleBackColor = true;
            this.btnFirstSubmenu.Click += new System.EventHandler(this.btnFirstSubmenu_Click);
            this.btnFirstSubmenu.Leave += new System.EventHandler(this.btnFirstSubmenu_Leave);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(249, 88);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Launcher.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnSettings.Image = global::Launcher.Properties.Resources.Settings_icon;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(322, 819);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(249, 39);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(249, 24);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(751, 476);
            this.panelChildForm.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Launcher.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(202, 108);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 272);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.panelSideBalk);
            this.Controls.Add(this.panelTopBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MinimumSize = new System.Drawing.Size(500, 270);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Launcher";
            this.panelTopBar.ResumeLayout(false);
            this.panelSideBalk.ResumeLayout(false);
            this.panelSubmenu.ResumeLayout(false);
            this.panelSubmenuTools.ResumeLayout(false);
            this.panelSubmenuMedia.ResumeLayout(false);
            this.panelSubmenuGames.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelSideBalk;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSubmenu;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Panel panelSubmenuTools;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btnThirdSubmenu;
        private System.Windows.Forms.Panel panelSubmenuMedia;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button btnSecondSubmenu;
        private System.Windows.Forms.Panel panelSubmenuGames;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button btnSingleplayer;
        private System.Windows.Forms.Button btnMultiplayer;
        private System.Windows.Forms.Button btnLauncher;
        private System.Windows.Forms.Button btnFirstSubmenu;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelNavigator;
    }
}

