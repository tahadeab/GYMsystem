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
    public partial class frmSubscribtionInfo : Form
    {
        private int _SubscribtionID;
        public frmSubscribtionInfo(int SubscritionID)
        {
            InitializeComponent();
            _SubscribtionID = SubscritionID;
        }

        private void frmSubscribtionInfo_Load(object sender, EventArgs e)
        {
            ctrlSubscribtionCard1.LoadSubscribtionInfoCard(_SubscribtionID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
