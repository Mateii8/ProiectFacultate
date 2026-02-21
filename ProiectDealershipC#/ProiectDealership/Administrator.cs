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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            modify.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            new Global();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text.Trim();

            if (username == "")
            {
                MessageBox.Show("Introdu username!");
                return;
            }

            string query = @"UPDATE Dealership.tAngajati  SET FunctieVeche = Functie, Functie = 'Administrator'  WHERE Nume = @username";
            SqlConnection con = new SqlConnection(Global.stringConectare);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@username", username);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                    MessageBox.Show($"Angajatul {username} este acum ADMIN");
                else
                    MessageBox.Show("Username inexistent!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text.Trim();

            string query = @"   UPDATE Dealership.tAngajati  SET Functie = FunctieVeche,   FunctieVeche = NULL  WHERE Nume = @username";
            SqlConnection con = new SqlConnection(Global.stringConectare);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@username", username);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Admin sters – rolul anterior a fost restaurat");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GestionareVanzari contabil = new GestionareVanzari();  
            contabil.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }
    }
}
