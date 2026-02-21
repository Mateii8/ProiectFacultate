using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectDealership
{
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
            comboBox1.Items.Add("Disponibila");
            comboBox1.Items.Add("Vanduta");
            comboBox1.SelectedIndex = 0;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DataView dv = new DataView(Global.ds.Tables["Dealership.tMasini"], "StatusMasina =  '" + comboBox1.SelectedItem.ToString() + "'", null, DataViewRowState.CurrentRows);
              ResultData2.DataSource = dv;
        }

        private void ResultData2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Modify_Load(object sender, EventArgs e)
        {
           new Global();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = Global.ds;
            SqlCommandBuilder cb = new SqlCommandBuilder(Global.daMasina);
           DataSet dsChange = ds.GetChanges();
           if(dsChange != null)
           {
              Global.daMasina.Update(dsChange, "Dealership.tMasini");
              ds.AcceptChanges();
              MessageBox.Show("Modificari salvate cu succes!");
           }
           else
           {
              MessageBox.Show("Nu exista modificari de salvat!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (ResultData2.CurrentRow == null)
            {
                MessageBox.Show("Selectează un rand!");
                return;
            }
            int idMasina = Convert.ToInt32(ResultData2.CurrentRow.Cells["idMasina"].Value);
            DialogResult confirm = MessageBox.Show(
             "Sigur vrei să stergi această masina?",
            "Confirmare",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(Global.stringConectare);
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Dealership.tMasini WHERE idMasina=@id", con);

                cmd.Parameters.AddWithValue("@id", idMasina);

                con.Open();
                cmd.ExecuteNonQuery();
                
            }
            int rowIndex = ResultData2.CurrentRow.Index;
            ResultData2.Rows.RemoveAt(rowIndex);
            MessageBox.Show("Rand sters cu succes!");
        }
    }
}
