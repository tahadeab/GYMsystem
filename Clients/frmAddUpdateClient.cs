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
    public partial class frmAddUpdateClient : Form
    {
        enum enMode { AddNew=0, Update =1}
        enMode Mode;
        private int _ClientID = -1;
        private clsClient _Client;

        public frmAddUpdateClient()
        {
            InitializeComponent();
        }
        public frmAddUpdateClient(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
            Mode = enMode.Update;
        }
         private void _ResetDefualtValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Client";
                _Client = new clsClient();
                this.Text = lblTitle.Text;
                tcpMembershipInfo.Enabled = false;
                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                lblTitle.Text = "Update Client";
                this.Text = lblTitle.Text;
                tcpMembershipInfo.Enabled = true ;
                btnSave.Enabled = true;
            }

            lblMemberID.Text = "???";
            txtEmergencyPhone.Text = "";
            txtLength.Text = "";
            txtWeight.Text = "";
            chkIsActive.Checked = true;

        }


        private void _Load()
        {
            _Client = clsClient.FindClient(_ClientID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            if( _Client == null )
            {
                MessageBox.Show("No Client with ID = " + _ClientID, "Client Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            lblMemberID.Text = _ClientID.ToString();
            lblMemberID.Enabled = false;
            txtEmergencyPhone.Text = _Client.EmergencyPhone;
            if(_Client.Length > 0 )
            txtLength.Text = _Client.Length.ToString();
            else
            txtLength.Text = "No Valid Length";

            txtWeight.Text = _Client.BodyWeight.ToString() ;
            if(_Client.IsActive)
            {
              chkIsActive.Checked = true;
            }
            else
                chkIsActive.Checked = false;

            ctrlPersonCardWithFilter1.LoadPersonInfo(_Client.PersonID);

        }








        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void tcpPersonalInfo_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUpdateClient_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (Mode == enMode.Update)  
                _Load();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }



        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tcpMembershipInfo.Enabled = true;
                tcClientInfo.SelectedTab = tcClientInfo.TabPages["tcpMembershipInfo"];
                return;
            }

            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {
                if(clsClient.IsClientExistbyPersonID(ctrlPersonCardWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected Person is already Member, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tcpMembershipInfo.Enabled = true;
                    tcClientInfo.SelectedTab = tcClientInfo.TabPages["tcpMembershipInfo"];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.Validate())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
            }
            _Client.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _Client.BodyWeight = Convert.ToDecimal(txtWeight.Text.Trim());
           if(txtLength.Text != "")
            _Client.Length = Convert.ToDecimal(txtLength.Text.Trim());
           else
             _Client.Length = 0;

           _Client.EmergencyPhone = txtEmergencyPhone.Text;
            
            if(chkIsActive.Checked )
                _Client.IsActive = true;
            else
                _Client.IsActive = false;

            if(_Client.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void txtWeight_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtWeight.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtWeight,"Weight can not be blank");
            }
            else
            {
                errorProvider1.SetError(txtWeight, null);
            };
        }

        private void txtLength_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtLength.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtWeight, "Length can not be blank");
            }
            else
            {
                errorProvider1.SetError(txtLength, null);
            };
        }

        private void txtEmergencyPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmergencyPhone.Text))
            {
                e.Cancel = true;  
                errorProvider1.SetError(txtEmergencyPhone, "Emergency Phone Can Not Be Blank"); ;
            }
            else
            {
                errorProvider1.SetError (txtEmergencyPhone, null);
            }
        }

        private void tcClientInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCardWithFilter1_Load_1(object sender, EventArgs e)
        {

        }

        private void tcpMembershipInfo_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblMemberID_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmergencyPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
