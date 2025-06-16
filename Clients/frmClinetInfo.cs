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
    public partial class frmClinetInfo : Form
    {
        private int _ClientID = -1;



        public frmClinetInfo(int ClientID)
        {
            InitializeComponent();
             _ClientID = ClientID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlClientCard1_Load(object sender, EventArgs e)
        {
            ctrlClientCard1.LoadMemberCardInfo(_ClientID);

        }

        private void frmClinetInfo_Load(object sender, EventArgs e)
        {
         
        }
    }
}
