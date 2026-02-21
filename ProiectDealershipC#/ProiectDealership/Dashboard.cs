using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProiectDealership
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            new Global();
        }

        private void btnSearchCar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Cautare.Text))
            {
                MessageBox.Show("Please enter a brand to search.");
                return;
            }
            else
            {
                DataView dv = new DataView(Global.ds.Tables["Dealership.tMasini"], "Brand =  '" + Cautare.Text + "'", null, DataViewRowState.CurrentRows);
                ResultData.DataSource = dv;
            }
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchClients_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Cautare.Text))
            {
                MessageBox.Show("Please enter an email to search.");
                return;
            }
            else
            {


                DataView dv = new DataView(Global.ds.Tables["Dealership.tClienti"], "Email =  '" + Cautare.Text + "'", null, DataViewRowState.CurrentRows);
                ResultData.DataSource = dv;
            }
        }

      
        private void btnShowCar_Click(object sender, EventArgs e)
        { 
            Modify modify = new Modify();
            modify.Show();
        }

        private void btnShowTestDrive_Click(object sender, EventArgs e)
        {
            DataView dv= new DataView(Global.ds.Tables["Dealership.tTestDrive"]);
            ResultData.DataSource = dv;
        }

        private void btnShowEmployee_Click(object sender, EventArgs e)
        {
           DataView dv = new DataView(Global.ds.Tables["Dealership.tAngajati"]);
           ResultData.DataSource = dv;
        }

        private void btnShowClients_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(Global.ds.Tables["Dealership.tClienti"]);
            ResultData.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestDrive testDrive = new TestDrive();
            testDrive.Show();
        }
    }
}
