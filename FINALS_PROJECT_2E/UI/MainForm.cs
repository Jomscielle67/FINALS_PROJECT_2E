using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALS_PROJECT_2E.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_courseSubmenu);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void customizeDesign()
        {
            panel_stdntSubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if(panel_stdntSubmenu.Visible = true)         
               panel_stdntSubmenu.Visible = false;
            if(panel_courseSubmenu.Visible = true)
               panel_courseSubmenu.Visible = false;
            if(panel_scoreSubmenu.Visible = true)
               panel_scoreSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;             
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void STUDENT_BUTTON_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdntSubmenu);
        }

        private void button_stdntRegistration_Click(object sender, EventArgs e)
        {
            //...
            //..Your Code
            //
            hideSubmenu();
        }

        private void button_stdntManage_Click(object sender, EventArgs e)
        {
            //...
            //..Your Code
            //
            hideSubmenu();
        }

        private void button_stdntStatus_Click(object sender, EventArgs e)
        {
            //...
            //..Your Code
            //
            hideSubmenu();
        }

        private void button_stdntPrint_Click(object sender, EventArgs e)
        {
            //...
            //..Your Code
            //
            hideSubmenu();
        }

        private void button_courseNew_Click(object sender, EventArgs e)
        {
            //...
            //..Your Code
            //
            hideSubmenu();
        }

        private void buttong_courseManage_Click(object sender, EventArgs e)
        {
            //...
            //..Your Code
            //
            hideSubmenu();
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {
            //...
            //..Your Code
            //
            hideSubmenu();
        }

        private void SCORE_BUTTON_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoreSubmenu);
        }

        private void button_addScore_Click(object sender, EventArgs e)
        {
            //...
            //..Your Code
            //
            hideSubmenu();
        }

        private void button_scoreManage_Click(object sender, EventArgs e)
        {
            //...
            //..Your Code
            //
            hideSubmenu();
        }

        private void button_scorePrint_Click(object sender, EventArgs e)
        {
            //...
            //..Your Code
            //
            hideSubmenu();
        }

        private void EXIT_BUTTON_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

      
    }
}
