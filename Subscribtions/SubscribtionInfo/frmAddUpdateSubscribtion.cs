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
using BusinessLayer_FinalProject;


namespace GymSystemFinalProject.Subscribtions.SubscribtionInfo
{
    public partial class frmAddUpdateSubscribtion : Form
    {
        enum enMode { AddNew = 0, Update = 1 }
        enum enPeriod {Monthly=0, Yearly=1 };
        enum enTypeOfSubscribtion { Default = 0, Pro = 1};
        enMode _Mode;
        enPeriod _Period;
        enTypeOfSubscribtion _TypeOfSubscribtion;


        //private clsClient _Client;
        private int _SubscribtionID;
        private clsSubscribtion _Subscribtion;
        public frmAddUpdateSubscribtion(int Period ,int Type)
        {
            InitializeComponent();
            if(Period == 0)  _Period = enPeriod.Monthly;
            else   _Period = enPeriod.Yearly;

            if (Type == 0) _TypeOfSubscribtion = enTypeOfSubscribtion.Default;
            else _TypeOfSubscribtion = enTypeOfSubscribtion.Pro;
                       
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateSubscribtion(int SubID)
        {
            InitializeComponent();
            _SubscribtionID = SubID;
            _Subscribtion = clsSubscribtion.FindSubscribtionByID(_SubscribtionID);
            if(_Subscribtion.SubsicribtionTypeID == 1)
            {
                _Period = enPeriod.Monthly;
                _TypeOfSubscribtion = enTypeOfSubscribtion.Pro;
            }
            else if(_Subscribtion.SubsicribtionTypeID == 6)
            {
                _Period = enPeriod.Yearly;
                _TypeOfSubscribtion = enTypeOfSubscribtion.Pro;
            }
            else if(_Subscribtion.SubsicribtionTypeID == 8)
            {
                _Period = enPeriod.Monthly;
                _TypeOfSubscribtion = enTypeOfSubscribtion.Default;
            }
            else
            {
                _Period = enPeriod.Yearly;
                _TypeOfSubscribtion = enTypeOfSubscribtion.Default;
            }
            _Mode = enMode.Update;

            _SubscribtionID = SubID;
        }

        private void _ResetDefualtValues()
        { 
             if(_Mode  == enMode.AddNew) 
            {
                lblTitle.Text = "New Subscribtion";
                _Subscribtion = new clsSubscribtion();
                tcpMembershipInfo.Enabled = false;
                tcpSubInfo.Enabled = false;
                this.Text = "New Subscribtion";
                ctrlPersonCardWithFilter1.FilterFocus();

            }
            else
            {
                lblTitle.Text = "Update Subscribtion";
                this.Text = "Update Subscribtion";
                tcpMembershipInfo.Enabled = true;
                tcpSubInfo.Enabled = true;
            }

         
             

            lblSubID.Text = "???";
            dtpStartDate.Value = DateTime.Now;
            dtpEmdDate.Value = DateTime.Now;    
            if(_Period == enPeriod.Monthly)
            {

                if (_TypeOfSubscribtion == enTypeOfSubscribtion.Default)
                {
                    lblSubType.Text = "Monthly";
                    lblTotalPric.Text = "8";
                    lblCoachID.Text = "No availble coach";

                }

                else
                {
                    lblTotalPric.Text = "10";
                    lblSubType.Text = "Monthly Pro";
                    lblCoachID.Text = "2";
                }
            }
            else
            {

                if (_TypeOfSubscribtion == enTypeOfSubscribtion.Default)
                {
                     lblSubType.Text = "Yearly";
                    lblCoachID.Text = "No availble coach";
                    lblTotalPric.Text = "95";
                }
                else
                {
                    lblTotalPric.Text = "115";
                    lblSubType.Text = "Yearly Pro";
                    lblCoachID.Text = "1";
                }
            }
            lblremainder.Text = "???";
            


        }

        private void _LoadSubInfo()
        {

            
            if( _Subscribtion == null )
            {
                MessageBox.Show("No Subscribtion with ID = " + _SubscribtionID, "Subscribtion Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            ctrlPersonCardWithFilter1.LoadPersonInfo(_Subscribtion.Client.PersonID);
            lblMemberID.Text = _Subscribtion.Client.MemberID.ToString();
            txtWeight.Text = _Subscribtion.Client.BodyWeight.ToString();
            txtLength.Text = _Subscribtion.Client.Length.ToString();
            txtEmergencyPhone.Text = _Subscribtion.Client.EmergencyPhone;
            if(_Subscribtion.Client.IsActive ) {
                chkIsActive.Checked = true;
            }
            else { chkIsActive.Checked = false;}

            gbxMembershipInfo.Enabled = false;

            lblSubID.Text = _Subscribtion.SubscribtionID.ToString();
            lblSubType.Text = _Subscribtion.SubscribtionType.Name;
            dtpStartDate.Value = _Subscribtion.StartDate;
            dtpEmdDate.Value = _Subscribtion.EndDate;
            lblTotalPric.Text = _Subscribtion.SubscribtionType.Price.ToString();
            lblCash.Text = _Subscribtion.Cash.ToString();
            lblremainder.Text = _Subscribtion.remainder.ToString();
            if (_Subscribtion.CoachID > 0)
            {
                lblCoachID.Text = _Subscribtion.CoachID.ToString();
            }
            else
                lblCoachID.Text = "No availble coach";




        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if(clsClient.IsClientExistbyPersonID(ctrlPersonCardWithFilter1.PersonID))
            {
              _Subscribtion.Client = clsClient.FindClientByPersonID(ctrlPersonCardWithFilter1.PersonID);
              tcpMembershipInfo.Enabled = true;
              tcSubscribtionInfo.SelectedTab = tcSubscribtionInfo.TabPages["tcpMembershipInfo"];
              
                gbxMembershipInfo.Enabled = false;
                lblMemberID.Text = _Subscribtion.Client.MemberID.ToString();
                txtEmergencyPhone.Text = _Subscribtion.Client.EmergencyPhone;
                txtLength.Text = _Subscribtion.Client.Length.ToString();
                txtWeight.Text = _Subscribtion.Client.BodyWeight.ToString();
                chkIsActive.Checked = _Subscribtion.Client.IsActive;
                
            }
            else
            {
                MessageBox.Show("Selected Person is not a member ", "Select Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tcSubscribtionInfo.SelectedTab = tcSubscribtionInfo.TabPages["tcpPersonalInfo"];
            }
        }

        public void frmAddUpdateSubscribtion_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if(_Mode == enMode.Update)
                _LoadSubInfo(); 
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSubIfoNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tcpSubInfo.Enabled = true;
                tcSubscribtionInfo.SelectedTab = tcSubscribtionInfo.TabPages["tcSubInfo"];
                return;
            }

            if(ctrlPersonCardWithFilter1.PersonID != -1)
            {
                if (clsSubscribtion.IsSubscribtionExistByMemberID(_Subscribtion.Client.MemberID))
                {
                    MessageBox.Show("Selected Member Has Already A Subscribtion Chose Another Member ","Select Member ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    tcSubscribtionInfo.SelectedTab = tcSubscribtionInfo.TabPages["tcpPersonalInfo"];
                    ctrlPersonCardWithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tcpSubInfo.Enabled = true;
                    tcSubscribtionInfo.SelectedTab = tcSubscribtionInfo.TabPages["tcSubInfo"];

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

            _Subscribtion.StartDate = dtpStartDate.Value;
            _Subscribtion.EndDate = dtpEmdDate.Value;
            _Subscribtion.MemberID = Convert.ToInt32(lblMemberID.Text);
            _Subscribtion.Cash += Convert.ToDecimal(lblCash.Text);
            if(lblCoachID.Text == "No availble coach")
            _Subscribtion.CoachID = -1;
            else
                _Subscribtion.CoachID = Convert.ToInt32(lblCoachID.Text.Trim());

            _Subscribtion.SubscribtionType = SubscribtionsTypeBusiness.FindByName(lblSubType.Text);
            _Subscribtion.SubsicribtionTypeID = _Subscribtion.SubscribtionType.SubscribtionTypeID;

            lblremainder.Text =  (_Subscribtion.SubscribtionType.Price - _Subscribtion.Cash).ToString();
            

            if (_Subscribtion.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            
        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void tcpSubInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
