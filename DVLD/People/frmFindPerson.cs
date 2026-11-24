using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmFindPerson : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;


        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void frmFindPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            DataBack?.Invoke(this, ctrlPersonCardWithFilter1.PersonID);
        }
    }
    
}

