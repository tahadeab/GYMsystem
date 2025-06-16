using BusinessLayer_FinalProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymSystemFinalProject.HumanResorcies;
using GymSystemFinalProject.Users; 



namespace GymSystemFinalProject.Users
{
    public partial class ctrlUserInfoCard : UserControl
    {

        private clsUsers _User;
        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }



        public ctrlUserInfoCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _User = clsUsers.FindByUserID(UserID);
            if (_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {

            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName.ToString();

            if (_User.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";

        }

        private void _ResetPersonInfo()
        {

            ctrlPersonCard1.ResetPersonInfo();
            lblUserID.Text = "[???]";
            lblUserName.Text = "[???]";
            lblIsActive.Text = "[???]";
        }



        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void ctrlUserInfoCard_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
