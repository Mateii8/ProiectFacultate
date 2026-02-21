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
    public partial class TestDrive : Form
    {
        public TestDrive()
        {
            InitializeComponent();
            this.Load += TestDrive_Load;
        }

        private void TestDrive_Load(object sender, EventArgs e)
        {
            new Global();
            try
            {
                if (Global.daProgramari == null)
                {
                    Global.daProgramari = new SqlDataAdapter("SELECT * FROM Dealership.tTestDrive", Global.stringConectare);
                    SqlCommandBuilder cb = new SqlCommandBuilder(Global.daProgramari);
                }

                if (Global.ds == null)
                {
                    Global.ds = new DataSet();
                }

              
                if (!Global.ds.Tables.Contains("Dealership.tTestDrive"))
                {
                    Global.daProgramari.Fill(Global.ds, "Dealership.tTestDrive");
                }

                
                resultData3.DataSource = Global.ds.Tables["Dealership.tTestDrive"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcarea datelor: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = Global.ds;
            SqlCommandBuilder cb = new SqlCommandBuilder(Global.daProgramari);
            DataSet dsChange = ds.GetChanges();
            
            if (dsChange != null)
            {
                Global.daProgramari.Update(dsChange, "Dealership.tTestDrive");
                ds.AcceptChanges();
                MessageBox.Show("Modificari salvate cu succes!");
            }
            else
            {
                MessageBox.Show("Nu exista modificari de salvat!");
            }
        }

        private void resultData3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (resultData3.CurrentRow == null)
            {
                MessageBox.Show("Selecteaza un rand!");
                return;
            }
            int idTestDrive = Convert.ToInt32(resultData3.CurrentRow.Cells["idTestDrive"].Value);
            DialogResult confirm = MessageBox.Show(
             "Sigur vrei sa stergi aceasta programare?",
            "Confirmare",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(Global.stringConectare);
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Dealership.tTestDrive WHERE idTestDrive=@id", con);

                cmd.Parameters.AddWithValue("@id", idTestDrive);

                con.Open();
                cmd.ExecuteNonQuery();

            }
            int rowIndex = resultData3.CurrentRow.Index;
            resultData3.Rows.RemoveAt(rowIndex);
            MessageBox.Show("Rand sters cu succes!");
        }
    }
}    
    


