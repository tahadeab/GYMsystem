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
using System.IO;
using GymSystemFinalProject.Properties;
using GymSystemFinalProject.GloabalClasses;


namespace GymSystemFinalProject.HumanResorcies
{
    public partial class frmAddUpdatePerson : Form
    {
        
        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;


        enum enMode {AddNew=0, Update =1}
        enum enGender {Male =0, Female =1}
        
         enMode Mode;
         clsPerson _Person;
         private int _PersonID =-1;


        public frmAddUpdatePerson()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            Mode= enMode.Update;
            _PersonID = PersonID;
        }

        private void _FellCompoBoxWithCountries()
        {
            DataTable dt = clsCountry.GetAllCountries();

            foreach(DataRow row in dt.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }



        private void _ResetDefaultValue()
        {
            _FellCompoBoxWithCountries();

            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "Update Person Info";
            }

            if(rbMale.Checked)
            {
                pbPersonImage.Image = Resources.Male_512;
            }
            else
            {
                pbPersonImage.Image = Resources.Female_512;
            }


            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-12);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            cbCountry.SelectedIndex = cbCountry.FindString("Yemen");

            txtFirstName.Text ="";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtCountryID.Text = clsCountry.Find("Yemen").ID.ToString();
            rbMale.Checked = true;
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";



        }

        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);
            if(_Person == null)
            {
                MessageBox.Show($"Sorry, The Person With ID {_Person.PersonID} Is Not Exist!  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName.ToString();
            txtSecondName.Text= _Person.SecondName.ToString();
            txtThirdName.Text= _Person.ThirdName.ToString();
            txtLastName.Text = _Person.LastName.ToString();
            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(_Person.CountryID).CountryName);
            txtCountryID.Text= _Person.CountryID.ToString();
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            if(_Person.Gender == 0)
            {
                rbMale.Checked= true;
            }
            else
            {
                rbFemale.Checked= true;
            }

            txtPhone.Text = _Person.PhoneNum;
            if (_Person.Email != "")
                txtPhone.Text = _Person.Email;
            else
                txtPhone.Text = "No Email Assigned..";



            if (_Person.Address != "")
                txtAddress.Text = _Person.Address;
            else
                txtAddress.Text = "No Address Assigned..";



            if(_Person.ImagePath != "")
            pbPersonImage.ImageLocation = _Person.ImagePath ;

            // To Handel The Remove LinkLable in the Form:
            llRemoveImage.Visible = (_Person.ImagePath != "");




        }







        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
            if (Mode == enMode.Update)
            {
                _LoadData();
            }
        }




        //هنا تم اصلاح التعارضات التي تحدث مع مسار الصوره المخزن في قاعدة البيانات والذي تم تحميله بالبرنامج 
        private bool _HandlePersonImage()
        {
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    //هنا بيكون معنا مسارين مختلفين الاول في الاداة والثاني هو القديم الي تحمل من قاعدة البيانات
                    //يتم حذف المسار القديم إذا وجد
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // في حالة لم نستطع حذف المسار القديم
                      
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    //نعيد تسمية الصورة الجديدة ونخزن المسار الخاص بها
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandlePersonImage())
                return;


            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.PhoneNum = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.CountryID = Convert.ToInt32( txtCountryID.Text.Trim());

            if (rbMale.Checked)
                _Person.Gender = (short)enGender.Male;
            else
                _Person.Gender = (short)enGender.Female;

            // Handel the fu---ing  Image Path again :(
            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";


            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                //Affter Adding new person Change the Mode to Update .
                Mode = enMode.Update;
                lblTitle.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 // Fire The User Define Event
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // Make sure that the Form propirty (AllowValidate) = EnableAllowFocusChange 👍
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }

        }

    

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Male_512;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Female_512;
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);//or  pbPersonImage.ImageLocation;
                llRemoveImage.Visible = true;  
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pbPersonImage.ImageLocation = null;



            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            llRemoveImage.Visible = false;
        }

        private void txtEmail_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;


            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            };

        }
    }
}
