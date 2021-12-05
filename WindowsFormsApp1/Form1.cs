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
        // Les actions en cours
        enum action { ADDING, DELETING, MODIFYING }
        // Connection String
        static string oradb = "Data Source =(DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = orcl)));" +
            "User Id=c##usernam;" +
            "Password=password;";
        // Instantiation du connection à la base de données de oracle
        OracleConnection conn = new OracleConnection(oradb);
        // Instantiation du commande
        OracleCommand cmd = new OracleCommand(oradb);
        // l'Action en cours
        int currentaction;

        // Constructeur de la forme
        public Form1()
        {
            InitializeComponent();
            conn.Open();
            Updatelist();
            BackToVisualisation();
            conn.Close();

        }
        //
        private void listEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            BackToVisualisation();
            conn.Open();

            // REQUETE SQL

            cmd.CommandText = "Select nom,prenom,note,ville FROM students WHERE idstudent = " + listEtudiant.SelectedItem.ToString();
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    // AJOUT DE DONNEES DANS LES TEXTBOXS
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

            // ETAT D AJOUT
            if (currentaction == (int)action.ADDING)
            {
                // SI TOUT LES TEXTBOX SONT REMPLIS
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

            // ETAT DE SUPPRESSION
            if (currentaction == (int)action.DELETING)
            {
                cmd.CommandText = "Delete from students where idstudent =" + listEtudiant.SelectedItem.ToString();
                cmd.ExecuteReader();
                Updatelist();
                BackToVisualisation();
            }

            // ETAT DE MODIFICATION
            if (currentaction == (int)action.MODIFYING)
            {
                // SI LES TEXTBOX SONT TOUS REMPLIS
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
            // CHANGEMENT D ETAT DE BUTTONS ET BOXS 
            nomTxtBox.Enabled = false;
            prenomTextBox.Enabled = false;
            noteTextBox.Enabled = false;
            villeTextBox.Enabled = false;
            listEtudiant.Enabled = false;
            // CHANGEMENT D ACTION
            currentaction = (int)action.DELETING;
            Message.Text = "Cliquer sur Valider pour confirmer la suppression";
            Message.ForeColor = System.Drawing.Color.Black;
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            GoToVisualisation();
            // CHANGEMENT D ETAT DE BUTTONS ET BOXS
            nomTxtBox.Enabled = true;
            prenomTextBox.Enabled = true;
            noteTextBox.Enabled = true;
            villeTextBox.Enabled = true;
            listEtudiant.Enabled = false;
            // CHANGEMENT D ACTION
            currentaction = (int)action.MODIFYING;
            Message.Text = "Cliquer sur Valider pour confirmer la modification";
            Message.ForeColor = System.Drawing.Color.Black;
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            GoToVisualisation();
            CleanTxtBoxes();
            // CHANGEMENT D ETAT DE BUTTONS ET BOXS
            nomTxtBox.Enabled = true;
            prenomTextBox.Enabled = true;
            noteTextBox.Enabled = true;
            villeTextBox.Enabled = true;
            listEtudiant.Enabled = false;
            // CHANGEMENT D ACTION
            currentaction = (int)action.ADDING;
            Message.Text = "Cliquer sur Valider pour confirmer l'ajout";
            Message.ForeColor = System.Drawing.Color.Black;
        }
        private void CleanTxtBoxes()
        {
            nomTxtBox.Text = "";
            prenomTextBox.Text = "";
            noteTextBox.Text = "";
            villeTextBox.Text = "";
        }
        private void GoFromVisualisation()
        {
            // QUITTER ETAT DE VISUALISATION
            Valider.Enabled = true;
            Annuler.Enabled = true;
            Supprimer.Enabled = false;
            Modifier.Enabled = false;
            Ajouter.Enabled = false;
        }
        private void BackToVisualisation()
        {
            // VERS ETAT DE VISUALISATION
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
            // REFLECHIR LE COMBOBOX
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
