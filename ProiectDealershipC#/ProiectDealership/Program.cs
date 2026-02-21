using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectDealership
{
    class Global
    {
        public static string stringConectare = @"Data Source=DESKTOP-2G64H2I;Initial Catalog = DealershipProiect;Integrated Security=True";
        public static SqlConnection con;

        public static DataSet ds;

        public static SqlDataAdapter daMasina;
        public static SqlDataAdapter daClienti;
        public static SqlDataAdapter daAngajati;
        public static SqlDataAdapter daVanzari;
        public static SqlDataAdapter daProgramari;
        public static SqlDataAdapter da;



        public Global()
        {
            con = new SqlConnection(stringConectare);
            ds = new DataSet();
            string strSelectMasina = "Select * from Dealership.tMasini";
            daMasina = new SqlDataAdapter(strSelectMasina, con);
            daMasina.Fill(ds, "Dealership.tMasini");

            string strSelectClienti = "Select * from Dealership.tClienti";
            daClienti = new SqlDataAdapter(strSelectClienti, con);
            daClienti.Fill(ds, "Dealership.tClienti");

            string strSelectAngajati = "Select * from Dealership.tAngajati";
            daAngajati = new SqlDataAdapter(strSelectAngajati, con);
            daAngajati.Fill(ds, "Dealership.tAngajati");

            string strSelectVanzari = "Select * from Dealership.tVanzari";
            Global.daVanzari = new SqlDataAdapter(strSelectVanzari, con);
            Global.daVanzari.Fill(ds, "Dealership.tVanzari");

            string strSelectProgamari = "Select * from Dealership.tTestDrive";
            daProgramari = new SqlDataAdapter(strSelectProgamari, con);
            daProgramari.Fill(ds, "Dealership.tTestDrive");

            SqlCommandBuilder cb= new SqlCommandBuilder(daMasina);
            daMasina.InsertCommand = cb.GetInsertCommand();
            daMasina.UpdateCommand = cb.GetUpdateCommand();
            daMasina.DeleteCommand = cb.GetDeleteCommand();

            SqlCommandBuilder cb1 = new SqlCommandBuilder(daClienti);
            daClienti.InsertCommand = cb1.GetInsertCommand();
            daClienti.UpdateCommand = cb1.GetUpdateCommand();
            daClienti.DeleteCommand = cb1.GetDeleteCommand();

            SqlCommandBuilder cb2 = new SqlCommandBuilder(daAngajati);
            daAngajati.InsertCommand = cb2.GetInsertCommand();
            daAngajati.UpdateCommand = cb2.GetUpdateCommand();
            daAngajati.DeleteCommand = cb2.GetDeleteCommand();

            SqlCommandBuilder cb3 = new SqlCommandBuilder(daVanzari);
            daVanzari.InsertCommand = cb3.GetInsertCommand();
            daVanzari.UpdateCommand = cb3.GetUpdateCommand();
            daVanzari.DeleteCommand = cb3.GetDeleteCommand();

            SqlCommandBuilder cb4 = new SqlCommandBuilder(daProgramari);
            daProgramari.InsertCommand = cb4.GetInsertCommand();
            daProgramari.UpdateCommand = cb4.GetUpdateCommand();
            daProgramari.DeleteCommand = cb4.GetDeleteCommand();

            DataRelation rel1 = new DataRelation("AngajatVanzari", ds.Tables["Dealership.tAngajati"].Columns["IdAngajat"], ds.Tables["Dealership.tVanzari"].Columns["IdAngajat"]);
            DataRelation rel2 = new DataRelation("ClientVanzari", ds.Tables["Dealership.tClienti"].Columns["IdClient"], ds.Tables["Dealership.tVanzari"].Columns["IdClient"]);
            DataRelation rel3 = new DataRelation("MasinaVanzari", ds.Tables["Dealership.tMasini"].Columns["IdMasina"], ds.Tables["Dealership.tVanzari"].Columns["IdMasina"]);
            Global.ds.Relations.Add(rel1);
            Global.ds.Relations.Add(rel2);
            Global.ds.Relations.Add(rel3);

        }
    }

    public static class Program
    {
      
      
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
