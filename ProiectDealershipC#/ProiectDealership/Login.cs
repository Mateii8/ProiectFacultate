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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            roleBox.Items.Add("Administrator");
            roleBox.Items.Add("Manager Vanzari");
            roleBox.Items.Add("Test Drive Specialist");
            roleBox.Items.Add("Contabilitate");
            roleBox.SelectedIndex = 0;
        }

       
        private void Login_Load(object sender, EventArgs e)
        {
            new Global();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text;
            if(string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Introduceti un username valid!");
                return;
            }
            SqlConnection con = new SqlConnection(Global.stringConectare);
            {
                try
                {
                    con.Open();
                    string role = roleBox.SelectedItem.ToString();
                    string query = "SELECT * FROM Dealership.tAngajati WHERE Nume=@username AND Functie=@role";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@role", role);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string numeAngajat = reader["Nume"].ToString();
                        MessageBox.Show("Autentificare reusita! Bine ai venit, " + numeAngajat + "!");
                        this.Hide();
                        switch (role)
                        {
                           case "Administrator":
                                Administrator admin = new Administrator();
                                admin.ShowDialog();
                                break;

                            case "Manager Vanzari":
                                Dashboard manager = new Dashboard();
                                manager.ShowDialog();
                                break;

                           case "Test Drive Specialist":
                                TestDrive testDrive = new TestDrive();
                                testDrive.ShowDialog();
                                break;
                           case "Contabilitate":
                                 GestionareVanzari contabil = new GestionareVanzari();
                                 contabil.ShowDialog();
                                 break;

                            default:
                                MessageBox.Show("Rol necunoscut!");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Autentificare esuata! Verificati username-ul si rolul.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la conectarea la baza de date: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
