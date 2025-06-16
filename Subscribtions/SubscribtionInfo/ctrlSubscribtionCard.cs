using BusinessLayer_FinalProject;
using GymSystemFinalProject.HumanResorcies.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSystemFinalProject.Subscribtions.SubscribtionInfo
{
    public partial class ctrlSubscribtionCard : UserControl
    {
        private int _SubscribionID = -1;
        private clsSubscribtion _Subscribion;
        public int SubscribionID { get { return _SubscribionID; } }



        public ctrlSubscribtionCard()
        {
            InitializeComponent();
        }

        private void _ResetSubscribtionCardInfo()
        {
            ctrlClientCard1._ResetMemberCardInfo();
            lblSubID.Text = "???";
            lblSubType.Text = "???";
            dtpStartDate.Value = DateTime.Now;
            dtpEmdDate.Value = DateTime.Now;
            lblTotalPrice.Text = "???";
            lblCash.Text = "???";
            lblremainder.Text = "???";

        }

        private void _FillSubscribtionCardInfo()
        {
            ctrlClientCard1.LoadMemberCardInfo(_Subscribion.MemberID);
            lblSubID.Text = _Subscribion.SubscribtionID.ToString();
            lblSubType.Text = _Subscribion.SubsicribtionTypeID.ToString();
            dtpStartDate.Value = _Subscribion.StartDate;
            dtpEmdDate.Value = _Subscribion.EndDate;
            lblTotalPrice.Text = _Subscribion.SubscribtionType.Price.ToString();
            lblCash.Text = _Subscribion.Cash.ToString();
            lblremainder.Text = _Subscribion.remainder.ToString();
           
            if(_Subscribion.CoachID >0)
               lblCoachID.Text = _Subscribion.CoachID.ToString();
            else
                lblCoachID.Text = "No Coach Is Available";

        
        }

        public void LoadSubscribtionInfoCard(int SubID)
        {
            _Subscribion = clsSubscribtion.FindSubscribtionByID(SubID);
            if (_Subscribion == null)
            {
                _ResetSubscribtionCardInfo();
                MessageBox.Show($"No Subscribtion With The ID: {SubID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                _FillSubscribtionCardInfo();
        }





        private void ctrlClientCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
