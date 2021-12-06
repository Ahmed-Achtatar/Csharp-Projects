using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp1
{
    class Connection
    {
        private static string oradb = "Data Source =(DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = orcl)));" +
            "User Id=c##usernam;" +
            "Password=password;";
        OracleConnection con = new OracleConnection(oradb);
        OracleCommand cmd = new OracleCommand(oradb);
        

        public void Ajouter(string nom, string prenom, string note, string ville)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Insert into students(idstudent, nom, prenom, note, ville) Values(STUD_SEQ.nextval,'" +
                        nom + "','" +
                        prenom + "','" +
                        note + "','" +
                        ville + "')";
            cmd.ExecuteReader();
            con.Close();
        }
        public void Modifier(string id, string nom, string prenom, string note, string ville)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Update students set " +
                        " nom = '" + nom + "'," +
                        " prenom = '" + prenom + "'," +
                        " note = '" + note + "'," +
                        " ville = '" + ville + "'" +
                        " Where idstudent = " + id;
            cmd.ExecuteReader();
            con.Close();
        }
        public void supprimer(string id)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Delete from students where idstudent =" + id;
            cmd.ExecuteReader();
            con.Close();
        }
        public void List(ComboBox C)
        {
            con.Open();
            cmd.Connection = con;
            // REFLECHIR LE COMBOBOX
            C.Items.Clear();
            cmd.CommandText = "select * from students";
            cmd.Connection = con;

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    C.Items.Add(dr["idstudent"]);
                }

            }

            con.Close();
        }
        public OracleDataReader Read(string id)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select nom, prenom, note, ville FROM students WHERE idstudent = " + id;
            OracleDataReader dr = cmd.ExecuteReader();
            con.Close();
            return dr;
            
        }
    }
}
