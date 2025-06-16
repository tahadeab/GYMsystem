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

namespace GymSystemFinalProject.HumanResorcies
{
    public partial class frmListPeople : Form
    {
        private static DataTable _dtAllPeople = clsPerson.GetAllPeople();

        //only select the columns that you want to show in the grid
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "CountryID",
                                                         "FirstName", "SecondName", "ThirdName", "LastName",
                                                         "GenderCaption", "DateOfBirth", "CountryName",
                                                         "PhoneNum", "Email");

        private void _RefreshPeoplList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "CountryID",
                                                         "FirstName", "SecondName", "ThirdName", "LastName",
                                                         "GenderCaption", "DateOfBirth", "CountryName",
                                                         "PhoneNum", "Email");

            dgvPeople.DataSource = _dtPeople;
            lblRecordsCount1.Text = dgvPeople.Rows.Count.ToString();
        }

        public frmListPeople()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmListPeoplecs_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = _dtPeople;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount1.Text = dgvPeople.Rows.Count.ToString();
            if (dgvPeople.Rows.Count > 0)
            {

                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "CountryID.";
                dgvPeople.Columns[1].Width = 120;


                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 120;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 140;


                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Gender";
                dgvPeople.Columns[6].Width = 120;

                dgvPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].Width = 140;

                dgvPeople.Columns[8].HeaderText = "Nationality";
                dgvPeople.Columns[8].Width = 120;


                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].Width = 120;


                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].Width = 300;

                
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            
            switch (cbFilterBy1.Text)
            { 
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "CountryID.":
                    FilterColumn = "CountryID";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gender":
                    FilterColumn = "GenderCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //لو مافي أي فلتر محدد 
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsCount1.Text = dgvPeople.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID")
                //يعني بنتعامل مع ارقام وليس نصوص

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount1.Text = dgvPeople.Rows.Count.ToString();
        }

        private void cbFilterBy1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy1.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

   

        private void showDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            Form frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void cmsPeople_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshPeoplList();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();

            _RefreshPeoplList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeoplList();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //لاما يحلها الله
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //لاما يحلها الله
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmAddUpdatePerson();
            frm1.ShowDialog();
            _RefreshPeoplList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPeople_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //يقبل ارقام بس اذا كان بل ايدي
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
