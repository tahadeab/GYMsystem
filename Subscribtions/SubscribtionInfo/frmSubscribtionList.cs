using BusinessLayer_FinalProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSystemFinalProject.Subscribtions.SubscribtionInfo
{
    public partial class frmSubscribtionList : Form
    {
        private static DataTable _DataList;



        public frmSubscribtionList()
        {
            InitializeComponent();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
                      //None
                  //SubscribtionID
                  //SubscribtionName
                  //Person ID
                  //Full Name

            string filterValue = "";
            switch(cbFilterBy.Text)
            {
                case "SubscribtionID":
                    filterValue = "SubscribtionID";
                break;
                case "SubscribtionName" :
                    filterValue = "Name";
                    break;
                case "Person ID":
                    filterValue= "PersonID";
                    break;
                case "Full Name":
                    filterValue = "FullName";
                    break;
                default:
                    filterValue = "None";
                    break;
            }

            if(txtFilterValue.Text == "" || filterValue == "None")
            {
                _DataList.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvSubscribtion.Rows.Count.ToString();
                return;
            }
            if (filterValue != "FullName" && filterValue != "Name")
                _DataList.DefaultView.RowFilter = string.Format("[{0}] = 1", filterValue, txtFilterValue.Text.Trim());
            else
                _DataList.DefaultView.RowFilter = string.Format("[{0}] like'{1}%'", filterValue, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvSubscribtion.Rows.Count.ToString();
        }

        public void frmSubscribtionList_Load(object sender, EventArgs e)
        {
            _DataList = clsSubscribtion.GetAllSubscribtions();
            dgvSubscribtion.DataSource = _DataList;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvSubscribtion.Rows.Count.ToString();
            if(dgvSubscribtion.Rows.Count > 0 )
            {
                dgvSubscribtion.Columns[0].HeaderText = "Subscribtion ID";
                dgvSubscribtion.Columns[0].Width = 50;

                dgvSubscribtion.Columns[1].HeaderText = "Subscribtion Type ID";
                dgvSubscribtion.Columns[1].Width = 50;

                dgvSubscribtion.Columns[2].HeaderText = "Name";
                dgvSubscribtion.Columns[2].Width = 100;

                dgvSubscribtion.Columns[3].HeaderText = "Person ID";
                dgvSubscribtion.Columns[3].Width = 50;

                dgvSubscribtion.Columns[4].HeaderText = "Member ID";
                dgvSubscribtion.Columns[4].Width = 50;

                dgvSubscribtion.Columns[5].HeaderText = "Member Name ";
                dgvSubscribtion.Columns[5].Width = 250;

                dgvSubscribtion.Columns[6].HeaderText = "Member Wheight";
                dgvSubscribtion.Columns[6].Width = 50;

                dgvSubscribtion.Columns[7].HeaderText = "Start Date";
                dgvSubscribtion.Columns[7].Width = 50;
                
                dgvSubscribtion.Columns[8].HeaderText = "End Date";
                dgvSubscribtion.Columns[8].Width = 50;
                
                dgvSubscribtion.Columns[9].HeaderText = "Total Price";
                dgvSubscribtion.Columns[9].Width = 50;

                dgvSubscribtion.Columns[10].HeaderText = "Cash";
                dgvSubscribtion.Columns[10].Width = 50;

                dgvSubscribtion.Columns[11].HeaderText = "Remainder";
                dgvSubscribtion.Columns[11].Width = 50;

                dgvSubscribtion.Columns[12].HeaderText = "Coach ID";
                dgvSubscribtion.Columns[12].Width = 50;

                dgvSubscribtion.Columns[13].HeaderText = "Is Active";
                dgvSubscribtion.Columns[13].Width = 50;

            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            if(cbFilterBy.Text == "None" )
                txtFilterValue.Enabled = false;
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();



        }

        private void btnAddSubscribtion_Click(object sender, EventArgs e)
        {
            frmAddUpdateSubscribtion frm = new frmAddUpdateSubscribtion(0, 0);
            frm.ShowDialog();
            frmSubscribtionList_Load(null, null);
        }

        private void sub2ToolstribPro_Click(object sender, EventArgs e)
        {
            frmAddUpdateSubscribtion frm = new frmAddUpdateSubscribtion(1,1);
            frm.ShowDialog();
            frmSubscribtionList_Load(null,null);

        }

        private void subToolstribMonthly_Click(object sender, EventArgs e)
        {
          
        }

        private void sub2ToolstribDefault_Click(object sender, EventArgs e)
        {
            frmAddUpdateSubscribtion frm = new frmAddUpdateSubscribtion(1, 0);
            frm.ShowDialog();
            frmSubscribtionList_Load(null, null);
        }

        private void sub2ToolstribPromonth_Click(object sender, EventArgs e)
        {
            frmAddUpdateSubscribtion frm = new frmAddUpdateSubscribtion(0, 1);
            frm.ShowDialog();
            frmSubscribtionList_Load(null, null);
        }

        private void sub2ToolstribDefaultMonth_Click(object sender, EventArgs e)
        {
            frmAddUpdateSubscribtion frm = new frmAddUpdateSubscribtion(0, 0);
            frm.ShowDialog();
            frmSubscribtionList_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubscribtionInfo frm = new frmSubscribtionInfo((int)dgvSubscribtion.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateSubscribtion frm = new frmAddUpdateSubscribtion((int)dgvSubscribtion.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmSubscribtionList_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SubscribtionID = (int)dgvSubscribtion.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are You Sure You Want To Delete This Subscribtion?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
               if (clsSubscribtion.DeleteSubscribtion(SubscribtionID))
               {
                   MessageBox.Show("Subscribtion has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   frmSubscribtionList_Load(null, null);
               }  
               else
                   MessageBox.Show("Subscribtion is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Subscribtion is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "Member ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvSubscribtion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSubscribtionInfo frm = new frmSubscribtionInfo((int)dgvSubscribtion.CurrentRow.Cells[0].Value);
            frm .ShowDialog();

        }
    }
}
