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

namespace GymSystemFinalProject.Clients
{
    public partial class ctrlClientCard : UserControl
    {
        private int _MemberID=-1;
        private clsClient _Client;

        public int MemberID
        {
            get { return _MemberID; }
        }


        public ctrlClientCard()
        {
            InitializeComponent();
        }

        public void _ResetMemberCardInfo()
        {
            ctrlPersonCard1.ResetPersonInfo();
            lblMemberID.Text = "???";
            lblWeight.Text = "???";
            lblLength.Text = "???";
            lblIsActive.Text = "???";
            lblEmrgencyPhone.Text = "???";
        }

        private void _FillMemberCardInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_Client.PersonID);
            lblMemberID.Text = MemberID.ToString() ;
            lblWeight.Text = _Client.BodyWeight.ToString();
            if( _Client.Length > 0 )
            {
                lblLength.Text = _Client.Length.ToString();
            }
            else
                lblLength.Text = "Not Valid";

            if( _Client.IsActive )
            {
                 lblIsActive.Text = "Yes";
            }
            else
                lblIsActive.Text = "No";

            lblEmrgencyPhone.Text = _Client.EmergencyPhone;

        }

        public void LoadMemberCardInfo(int MemberID)
        {
            _Client = clsClient.FindClient(MemberID);
            if (_Client == null)
            { 
                _ResetMemberCardInfo();
                MessageBox.Show($"No Member With The ID: {MemberID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillMemberCardInfo();
        }


        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctrlClientCard_Load(object sender, EventArgs e)
        {
        
        }
    }
}
