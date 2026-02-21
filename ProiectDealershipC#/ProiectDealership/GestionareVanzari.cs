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
    public partial class GestionareVanzari : Form
    {
        public GestionareVanzari()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(Global.ds.Tables["Dealership.tVanzari"]);
            resultData4.DataSource = dv;
        }

        private void GestionareVanzari_Load(object sender, EventArgs e)
        {
            new Global();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataSet ds = Global.ds;
            SqlCommandBuilder cb = new SqlCommandBuilder(Global.daVanzari);
            DataSet dsChange = ds.GetChanges();
            if (dsChange != null)
            {
                Global.daVanzari.Update(dsChange, "Dealership.tVanzari");
                ds.AcceptChanges();
                MessageBox.Show("Modificari salvate cu succes!");
            }
            else
            {
                MessageBox.Show("Nu exista modificari de salvat!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (resultData4.CurrentRow == null)
            {
                MessageBox.Show("Selecteaza un rand!");
                return;
            }
            int idVanzare = Convert.ToInt32(resultData4.CurrentRow.Cells["idVanzare"].Value);
            DialogResult confirm = MessageBox.Show( "Sigur vrei sa stergi aceasta programare?", "Confirmare",  MessageBoxButtons.YesNo,     MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(Global.stringConectare);
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Dealership.tVanzari WHERE idVanzare=@id", con);

                cmd.Parameters.AddWithValue("@id", idVanzare);

                con.Open();
                cmd.ExecuteNonQuery();

            }
            int rowIndex = resultData4.CurrentRow.Index;
            resultData4.Rows.RemoveAt(rowIndex);
            MessageBox.Show("Rand sters cu succes!");
        }
    }
    
}
