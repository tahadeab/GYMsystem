using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using BusinessLayer_FinalProject;
using GymSystemFinalProject.GloabalClasses;


namespace GymSystemFinalProject.Subscribtions.SubscribtionType
{
    public partial class EditSubscribtion : Form
    {
        private int _SubscribtionTypeID = -1;
        private SubscribtionsTypeBusiness _SubscribtionType;

        public EditSubscribtion(int SubID)
        {
            InitializeComponent();
            _SubscribtionTypeID = SubID;
        }


        private void EditSubscribtion_Load(object sender, EventArgs e)
        {
            lblSubscribtionTypeID.Text = _SubscribtionTypeID.ToString();
            _SubscribtionType = SubscribtionsTypeBusiness.Find(_SubscribtionTypeID);
            if (_SubscribtionType != null)
            {
                txtName.Text = _SubscribtionType.Name;
                txtDetails.Text = _SubscribtionType.Details;
                txtPeriod.Text = _SubscribtionType.Period.ToString();
                txtPrice.Text = _SubscribtionType.Price.ToString();

            }

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtName, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txtName, null);
            };
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrice, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPrice, null);
            };


            if (!clsValidation.IsNumber(txtPrice.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrice, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txtPrice, null);
            };
        }

        private void txtDetails_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDetails.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDetails, "Details cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txtDetails, null);
            };
        }

        private void txtPeriod_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPeriod.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPeriod, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPeriod, null);
            };


            if (!clsValidation.IsNumber(txtPeriod.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPeriod, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txtPeriod, null);
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            _SubscribtionType.Name = txtName.Text;
            _SubscribtionType.Details = txtDetails.Text;
            _SubscribtionType.Price = Convert.ToDecimal(txtPrice.Text.Trim());
            _SubscribtionType.Period = Convert.ToInt16(txtPeriod.Text.Trim());

            if (_SubscribtionType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
