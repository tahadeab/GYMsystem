using GymSystemFinalProject.Clients;
using GymSystemFinalProject.GloabalClasses;
using GymSystemFinalProject.HumanResorcies;
using GymSystemFinalProject.LogIn;
using GymSystemFinalProject.Subscribtions;
using GymSystemFinalProject.Subscribtions.SubscribtionInfo;
using GymSystemFinalProject.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GymSystemFinalProject
{
    public partial class frm_MainForm : Form
    {
        frmLogin _frmLogin;

        public frm_MainForm(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        //    lblLoggedInUser.Text = "LoggedIn User: " + clsGlobal.CurrentUser.UserName;
            this.Refresh();
        }

        private void monthlyPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Ms_Persons_Click(object sender, EventArgs e)
        {
            Form frm = new frmListPeople();
            frm.ShowDialog();
        }

        private void Ms_CurrentUser_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
             frm.ShowDialog();

        }

        private void Ms_ChangPassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void Ms_Users_Click(object sender, EventArgs e)
        {
            Form frm = new frmListUserscs();
            frm.ShowDialog();
        }

        private void Ms_AccountSetting_Click(object sender, EventArgs e)
        {

        }

        private void ptx_MainScreen_Click(object sender, EventArgs e)
        {

        }

        private void Ms_SignOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void ms_ManageSubs_Click(object sender, EventArgs e)
        {
            frmSubscribtionType frm = new frmSubscribtionType();    
            frm.ShowDialog();

        }

        private void Ms_Subscribtion_Click(object sender, EventArgs e)
        {

        }

        private void Ms_Members_Click(object sender, EventArgs e)
        {
            Form frm = new frmListClient();
            frm.ShowDialog();
        }

        private void proTrailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateSubscribtion frm = new frmAddUpdateSubscribtion(1, 1);
            frm.ShowDialog();
            
        }

        private void proTrailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdateSubscribtion frm = new frmAddUpdateSubscribtion(0, 1);
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolstribSubList_Click(object sender, EventArgs e)
        {
            frmSubscribtionList frm = new frmSubscribtionList();
            frm.ShowDialog();
        }

        private void defaultTrailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateSubscribtion frm = new frmAddUpdateSubscribtion(1, 0);
            frm.ShowDialog();
        }

        private void defaultTrailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdateSubscribtion frm = new frmAddUpdateSubscribtion(0, 0);
            frm.ShowDialog();
        }
    }
}
