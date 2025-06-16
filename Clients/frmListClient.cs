using BusinessLayer_FinalProject;
using GymSystemFinalProject.Users;
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
using System.Xml.Linq;

namespace GymSystemFinalProject.Clients
{
    public partial class frmListClient : Form
    {
        private static DataTable _DataList;


        public frmListClient()
        {
            InitializeComponent();
        }

        private void frmListClient_Load(object sender, EventArgs e)
        {
            _DataList = clsClient.GetAllClients();
            dgvClients.DataSource = _DataList;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = _DataList.Rows.Count.ToString();
            if(dgvClients.Rows.Count> 0)
            {
                dgvClients.Columns[0].HeaderText = "Client ID";
                dgvClients.Columns[0].Width = 100;
              
                dgvClients.Columns[1].HeaderText = "Person ID";
                dgvClients.Columns[1].Width = 100;
                
                dgvClients.Columns[2].HeaderText = "Full Name";
                dgvClients.Columns[2].Width = 300;
                
                dgvClients.Columns[3].HeaderText = "Body Wieght";
                dgvClients.Columns[3].Width = 100;
                
                dgvClients.Columns[4].HeaderText = "Length";
                dgvClients.Columns[4].Width = 100;
                
                dgvClients.Columns[5].HeaderText = "Emergancy Phone";
                dgvClients.Columns[5].Width = 150;

                dgvClients.Columns[6].HeaderText = "Is Active";
                dgvClients.Columns[6].Width = 100;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbIsActive.Enabled = false;
                if (cbFilterBy.Text == "None")
                {
                    txtFilterValue.Enabled = false;
                }
                else
                {
                    txtFilterValue.Enabled = true;
                }
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FillterBy = "";
            switch (cbFilterBy.Text)
            {
                case "Member ID":
                      FillterBy = "MemberID";
                    break;
                case "Person ID":
                    FillterBy = "PerosnID";
                    break;
                case "Full Name":
                    FillterBy = "FullName";         
                    break;
                default:
                    FillterBy = "None";
                    break;

            }

            if (txtFilterValue.Text.Trim() =="" || FillterBy == "")
            {
                _DataList.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvClients.Rows.Count.ToString();
                return;
            }
            else
            {
                if(FillterBy == "FullName")
                {
                    _DataList.DefaultView.RowFilter = string.Format("[{0}] like'{1}%'", FillterBy, txtFilterValue.Text.Trim());
                }
                else
                    _DataList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FillterBy,txtFilterValue.Text.Trim());

                lblRecordsCount.Text = dgvClients.Rows.Count.ToString();
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FillterColumn = "IsActive";
            string FillterValue = cbIsActive.Text;
            switch (FillterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FillterValue = "1";
                    break;
                case "No":
                    FillterValue = "0";
                    break;
            }

            if (FillterValue == "All")
            {
                _DataList.DefaultView.RowFilter = "";
            }
            else
                _DataList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FillterColumn, FillterValue);

             lblRecordsCount.Text = dgvClients.Rows.Count.ToString();

        }

      

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            frmAddUpdateClient frm = new frmAddUpdateClient();
            frm.ShowDialog();
            frmListClient_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClinetInfo frm = new frmClinetInfo((int)dgvClients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdateClient frm = new frmAddUpdateClient();
            frm.ShowDialog();
            frmListClient_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ClientID = (int)dgvClients.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are You Sure You Want To Delete this User!","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK)
            {
                if(clsClient.DeleteClient(ClientID))
                {
                    MessageBox.Show("Delete Has Been Done Succissfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Delete Has Faild!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               frmListClient_Load(null, null);
            }

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "Client ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvClients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           frmClinetInfo Frm1 = new frmClinetInfo((int)dgvClients.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateClient frm = new frmAddUpdateClient((int)dgvClients.CurrentRow.Cells[0].Value);
             frm.ShowDialog();
            frmListClient_Load(null, null);
        }
    }
    }
