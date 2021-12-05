using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        enum action { ADDING, DELETING, MODIFYING }
        static string oradb = "Data Source =(DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = orcl)));" +
            "User Id=c##usernam;" +
            "Password=password;";
        OracleConnection conn = new OracleConnection(oradb);
        OracleCommand cmd = new OracleCommand(oradb);
        int currentaction;

        public Form1()
        {
            InitializeComponent();
            conn.Open();
            Updatelist();
            BackToVisualisation();
            conn.Close();

        }

        private void listEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackToVisualisation();
            conn.Open();
            cmd.CommandText = "Select nom,prenom,note,ville FROM students WHERE idstudent = " + listEtudiant.SelectedItem.ToString();
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    nomTxtBox.Text = dr["nom"].ToString();
                    prenomTextBox.Text = dr["prenom"].ToString();
                    noteTextBox.Text = dr["note"].ToString();
                    villeTextBox.Text = dr["ville"].ToString();
                }
                
            }
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Message_Click(object sender, EventArgs e)
        {

        }
  
        private void Valider_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (currentaction == (int)action.ADDING)
            {
                
                if (!(string.IsNullOrEmpty(nomTxtBox.Text) || string.IsNullOrEmpty(prenomTextBox.Text) || string.IsNullOrEmpty(noteTextBox.Text)))
                {
                    cmd.CommandText = "Insert into students(idstudent, nom, prenom, note, ville) Values(STUD_SEQ.nextval,'" +
                        nomTxtBox.Text + "','" +
                        prenomTextBox.Text + "','" +
                        noteTextBox.Text + "','" +
                        villeTextBox.Text + "')";
                    cmd.ExecuteReader();
                    Updatelist();
                    BackToVisualisation();
                }
                else
                {
                    Message.Text = "veuillez remplir tous les bloques";
                    Message.ForeColor = System.Drawing.Color.Red;
                }
            }
            if (currentaction == (int)action.DELETING)
            {
                cmd.CommandText = "Delete from students where idstudent =" + listEtudiant.SelectedItem.ToString();
                cmd.ExecuteReader();
                Updatelist();
                BackToVisualisation();
            }
            if (currentaction == (int)action.MODIFYING)
            {

                if (!(string.IsNullOrEmpty(nomTxtBox.Text) || string.IsNullOrEmpty(prenomTextBox.Text) || string.IsNullOrEmpty(noteTextBox.Text)))
                {
                    cmd.CommandText = "Update students set " + 
                        " nom = '" + nomTxtBox.Text + "',"+
                        " prenom = '" + prenomTextBox.Text + "'," +
                        " note = '" + noteTextBox.Text + "'," +
                        " ville = '" + villeTextBox.Text + "'" +
                        " Where idstudent = " + listEtudiant.SelectedItem.ToString();
                    cmd.ExecuteReader();
                    Updatelist();
                    BackToVisualisation();
                }
                else
                {
                    Message.Text = "veuillez remplir tous les bloques";
                    Message.ForeColor = System.Drawing.Color.Red;
                }
            }
            conn.Close();
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            BackToVisualisation();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            GoToVisualisation();
            nomTxtBox.Enabled = false;
            prenomTextBox.Enabled = false;
            noteTextBox.Enabled = false;
            villeTextBox.Enabled = false;
            listEtudiant.Enabled = false;
            currentaction = (int)action.DELETING;
            Message.Text = "Cliquer sur Valider pour confirmer la suppression";
            Message.ForeColor = System.Drawing.Color.Black;
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            GoToVisualisation();
            nomTxtBox.Enabled = true;
            prenomTextBox.Enabled = true;
            noteTextBox.Enabled = true;
            villeTextBox.Enabled = true;
            listEtudiant.Enabled = false;
            currentaction = (int)action.MODIFYING;
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            GoToVisualisation();
            CleanTxtBoxes();
            nomTxtBox.Enabled = true;
            prenomTextBox.Enabled = true;
            noteTextBox.Enabled = true;
            villeTextBox.Enabled = true;
            listEtudiant.Enabled = false;
            currentaction = (int)action.ADDING;
        }
        private void CleanTxtBoxes()
        {
            nomTxtBox.Text = "";
            prenomTextBox.Text = "";
            noteTextBox.Text = "";
            villeTextBox.Text = "";
        }
        private void GoToVisualisation()
        {
            Valider.Enabled = true;
            Annuler.Enabled = true;
            Supprimer.Enabled = false;
            Modifier.Enabled = false;
            Ajouter.Enabled = false;
        }
        private void BackToVisualisation()
        {
            Valider.Enabled = false;
            Annuler.Enabled = false;

            Ajouter.Enabled = true;
            nomTxtBox.Enabled = false;
            prenomTextBox.Enabled = false;
            noteTextBox.Enabled = false;
            villeTextBox.Enabled = false;
            listEtudiant.Enabled = true;
            listEtudiant.Text = "--- Select ---";
            if (listEtudiant.SelectedItem == null)
            {
                Supprimer.Enabled = false;
                Modifier.Enabled = false;
            }
            else
            {

                Supprimer.Enabled = true;
                Modifier.Enabled = true;
            }
            currentaction = -1;
        }
        void Updatelist()
        {
            listEtudiant.Items.Clear();
            cmd.CommandText = "select * from students";
            cmd.Connection = conn;
            
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listEtudiant.Items.Add(dr["idstudent"]);
                }

            }
        }
    }
}
