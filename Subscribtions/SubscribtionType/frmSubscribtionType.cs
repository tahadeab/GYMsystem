using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer_FinalProject;
using GymSystemFinalProject.Subscribtions.SubscribtionType;


namespace GymSystemFinalProject.Subscribtions
{
    public partial class frmSubscribtionType : Form
    {

        private DataTable _SubscribtionType;

        public frmSubscribtionType()
        {
            InitializeComponent();
        }

        private void frmSubscribtionType_Load(object sender, EventArgs e)
        {
            _SubscribtionType = SubscribtionsTypeBusiness.GetAllSubscribtionType();
            dgvSubscribtionType.DataSource = _SubscribtionType;
            lblRecordsCount.Text = dgvSubscribtionType.Rows.Count.ToString();
            if (dgvSubscribtionType.Rows.Count > 0)
            {
                dgvSubscribtionType.Columns[0].HeaderText = "SubsicribtionID";
                dgvSubscribtionType.Columns[0].Width = 100;
                dgvSubscribtionType.Columns[1].HeaderText = "Name";
                dgvSubscribtionType.Columns[1].Width = 150;
                dgvSubscribtionType.Columns[2].HeaderText = "Period";
                dgvSubscribtionType.Columns[2].Width = 100;
                dgvSubscribtionType.Columns[3].HeaderText = "Details";
                dgvSubscribtionType.Columns[3].Width = 500;
                dgvSubscribtionType.Columns[4].HeaderText = "Price";
                dgvSubscribtionType.Columns[4].Width = 100;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSubscribtion frm = new EditSubscribtion((int)dgvSubscribtionType.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmSubscribtionType_Load(null, null);
        }
    }
}
