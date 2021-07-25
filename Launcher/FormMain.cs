using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Launcher
{
    public partial class FormMain : Form
    {
        public FormMain() // Constructor
        {
            InitializeComponent();
            customizeDesign();
            hideNavi();
        }

        #region Drag window
        bool mouseDown;
        private Point offset;

        // Move window functions
        private void mouseDown_Event(object sender, MouseEventArgs e)
        {

            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        #region Window controls
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Navigation
        private void customizeDesign()
        {
            panelSubmenuGames.Visible = false;
            panelSubmenuMedia.Visible = false;
            panelSubmenuTools.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubmenuGames.Visible == true)
                panelSubmenuGames.Visible = false;
            if (panelSubmenuMedia.Visible == true)
                panelSubmenuMedia.Visible = false;
            if (panelSubmenuTools.Visible == true)
                panelSubmenuTools.Visible = false;
        }
        private void navi_Click(Button btn, Panel submenu)
        {
            showSubMenu(submenu);
            if (btn.BackColor == Color.FromArgb(15, 5, 5))
            {
                btn.BackColor = Color.FromArgb(50, 5, 5);
                panelNavigator.Visible = true;
                panelNavigator.Height = btn.Height;
                panelNavigator.Top = btn.Top;
            }
            else
            {
                btn.BackColor = Color.FromArgb(15, 5, 5);
                panelNavigator.Visible = false;
            }
        }



        private void navi_Leave(Button btn)
        {
            btn.BackColor = Color.FromArgb(15, 5, 5);
        }

        private void hideNavi()
        {
            panelNavigator.Hide();
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu == null)
            {
                hideSubMenu();
            }
            else
            {
                if (subMenu.Visible == false)
                {
                    hideSubMenu();
                    subMenu.Visible = true;
                }
                else
                {
                    subMenu.Visible = false;
                }
            }
            
        }
        #endregion

        #region FirstSubmenu
        private void btnFirstSubmenu_Click(object sender, EventArgs e)
        {
            navi_Click(btnFirstSubmenu, panelSubmenuGames);
        }
        private void btnFirstSubmenu_Leave(object sender, EventArgs e)
        {
            navi_Leave(btnFirstSubmenu);
        }

        private void btnLauncher_Click(object sender, EventArgs e)
        {
            if (activeForm == new FormLaunchers())
                activeForm.Close();
            else
                openChildForm(new FormLaunchers());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        #endregion

        #region SecondSubMenu
        private void btnSecondSubmenu_Click(object sender, EventArgs e)
        {
            navi_Click(btnSecondSubmenu, panelSubmenuMedia);
        }
        private void btnSecondSubmenu_Leave(object sender, EventArgs e)
        {
            navi_Leave(btnSecondSubmenu);
        }
        #endregion

        #region ThirdSubmenu
        private void btnThirdSubmenu_Click(object sender, EventArgs e)
        {
            navi_Click(btnThirdSubmenu, panelSubmenuTools);
        }

        private void btnThirdSubmenu_Leave(object sender, EventArgs e)
        {
            navi_Leave(btnThirdSubmenu);
        }
        #endregion

        private void btnNotes_Click(object sender, EventArgs e)
        {
            navi_Click(btnNotes, null);
        }

        private void btnNotes_Leave(object sender, EventArgs e)
        {
            navi_Leave(btnNotes);
        }

        #region Forms controls
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        #endregion

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            activeForm.Close();
        }
    }
}
