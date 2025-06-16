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
    public partial class frmFindPersoncs : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;



        public frmFindPersoncs()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

        }
        private void frmFindPersoncs_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            // Make the Event To send the PersonId When another form call the event Data back.
            DataBack?.Invoke(this, ctrlPersonCardWithFilter1.PersonID);
        }
    }
}
