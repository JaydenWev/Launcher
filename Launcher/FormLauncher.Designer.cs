
namespace Launcher
{
    partial class FormLauncher
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
            this.btnSteam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSteam
            // 
            this.btnSteam.AllowDrop = true;
            this.btnSteam.FlatAppearance.BorderSize = 0;
            this.btnSteam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSteam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnSteam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSteam.Location = new System.Drawing.Point(50, 100);
            this.btnSteam.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSteam.Name = "btnSteam";
            this.btnSteam.Size = new System.Drawing.Size(100, 75);
            this.btnSteam.TabIndex = 10;
            this.btnSteam.Text = "Steam";
            this.btnSteam.UseVisualStyleBackColor = true;
            this.btnSteam.Click += new System.EventHandler(this.btnSteam_Click);
            // 
            // FormLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.btnSteam);
            this.Name = "FormLauncher";
            this.Text = "FormLauncher";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSteam;
    }
}