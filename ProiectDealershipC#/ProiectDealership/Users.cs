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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            comboBox1.Items.Add("Angajat");
            comboBox1.Items.Add("Client");
            comboBox1.SelectedIndex = 0;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            new Global();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Angajat")
            {
                DataView dv = new DataView(Global.ds.Tables["Dealership.tAngajati"]);
                ResultData5.DataSource = dv;
            }
            else
            {
                DataView dv = new DataView(Global.ds.Tables["Dealership.tClienti"]);
                ResultData5.DataSource = dv;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Angajat")
            {
                DataSet ds = Global.ds;
                SqlCommandBuilder cb = new SqlCommandBuilder(Global.daAngajati);
                DataSet dsChange = ds.GetChanges();
                if (dsChange != null)
                {
                    Global.daAngajati.Update(dsChange, "Dealership.tAngajati");
                    ds.AcceptChanges();
                    MessageBox.Show("Modificari salvate cu succes!");
                }
                else
                {
                    MessageBox.Show("Nu exista modificari de salvat!");
                }
            }
            else
            {
                DataSet ds = Global.ds;
                SqlCommandBuilder cb = new SqlCommandBuilder(Global.daClienti);
                DataSet dsChange = ds.GetChanges();
                if (dsChange != null)
                {
                    Global.daClienti.Update(dsChange, "Dealership.tClienti");
                    ds.AcceptChanges();
                    MessageBox.Show("Modificari salvate cu succes!");
                }
                else
                {
                    MessageBox.Show("Nu exista modificari de salvat!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Angajat")
            {
                if (ResultData5.CurrentRow == null)
                {
                    MessageBox.Show("Selecteaza un rand!");
                    return;
                }
                int IdAngajat = Convert.ToInt32(ResultData5.CurrentRow.Cells["IdAngajat"].Value);
                DialogResult confirm = MessageBox.Show( "Sigur vrei sa stergi acest user?",    "Confirmare",   MessageBoxButtons.YesNo,  MessageBoxIcon.Warning);

                if (confirm == DialogResult.No)
                    return;
                SqlConnection con = new SqlConnection(Global.stringConectare);
                {
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Dealership.tAngajati WHERE IdAngajat=@id", con);

                    cmd.Parameters.AddWithValue("@id", IdAngajat);

                    con.Open();
                    cmd.ExecuteNonQuery();

                }
                int rowIndex = ResultData5.CurrentRow.Index;
                ResultData5.Rows.RemoveAt(rowIndex);
                MessageBox.Show("Rand sters cu succes!");
            }
            else
            {
                if (ResultData5.CurrentRow == null)
                {
                    MessageBox.Show("Selecteaza un rand!");
                    return;
                }
                int IdClient = Convert.ToInt32(ResultData5.CurrentRow.Cells["IdClient"].Value);
                DialogResult confirm = MessageBox.Show(  "Sigur vrei sa stergi aceasta programare?",  "Confirmare",  MessageBoxButtons.YesNo,   MessageBoxIcon.Warning);

                if (confirm == DialogResult.No)
                    return;
                SqlConnection con = new SqlConnection(Global.stringConectare);
                {
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Dealership.tClienti WHERE IdClient=@id", con);

                    cmd.Parameters.AddWithValue("@id", IdClient);

                    con.Open();
                    cmd.ExecuteNonQuery();

                }
                int rowIndex = ResultData5.CurrentRow.Index;
                ResultData5.Rows.RemoveAt(rowIndex);
                MessageBox.Show("Rand sters cu succes!");
            }
        }
        
        
    }
}
