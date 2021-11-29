using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace FormApp
{
    public partial class Form1 : Form
    {

        List<Etdiant> listetudiants = new();
        enum action { ADDING, DELETING, MODIFYING }
        int currentaction;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            CleanTxtBoxes();
            GoToVisualisation();
            nomTxtBox.Enabled = false;
            prenomTextBox.Enabled = false;
            noteTextBox.Enabled = false;
            listeEtudiant.Enabled = false;
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
            listeEtudiant.Enabled = false;
            currentaction = (int)action.MODIFYING;
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            BackToVisualisation();
        }

        private void Valider_Click(object sender, EventArgs e)
        {

            if (currentaction == (int)action.ADDING){
                if (!(string.IsNullOrEmpty(nomTxtBox.Text) || string.IsNullOrEmpty(prenomTextBox.Text) || string.IsNullOrEmpty(noteTextBox.Text)))
                {
                    listetudiants.Add(new Etdiant(nomTxtBox.Text, prenomTextBox.Text, Convert.ToDouble(noteTextBox.Text)));
                    listeEtudiant.Items.Add(nomTxtBox.Text + " " + prenomTextBox.Text);
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
                listetudiants.Remove(listetudiants.ElementAt(listeEtudiant.SelectedIndex));
                listeEtudiant.Items.Remove(listeEtudiant.SelectedItem);
                
                BackToVisualisation();
            }
            if (currentaction == (int)action.MODIFYING)
            {
                
                 if (!(string.IsNullOrEmpty(nomTxtBox.Text) || string.IsNullOrEmpty(prenomTextBox.Text) || string.IsNullOrEmpty(noteTextBox.Text)))
                {

                    listetudiants.ElementAt(listeEtudiant.SelectedIndex).Nom = nomTxtBox.Text;
                    listetudiants.ElementAt(listeEtudiant.SelectedIndex).Prenom = prenomTextBox.Text;
                    listetudiants.ElementAt(listeEtudiant.SelectedIndex).Note = Convert.ToDouble(noteTextBox.Text);

                    listeEtudiant.Items[listeEtudiant.SelectedIndex] = (nomTxtBox.Text + " " + prenomTextBox.Text);
                    BackToVisualisation();
                }
                else
                {
                    Message.Text = "veuillez remplir tous les bloques";
                    Message.ForeColor = System.Drawing.Color.Red;
                }
            }

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            GoToVisualisation();
            CleanTxtBoxes();
            nomTxtBox.Enabled = true;
            prenomTextBox.Enabled = true;
            noteTextBox.Enabled = true;
            listeEtudiant.Enabled = false;
            currentaction = (int)action.ADDING;
        }

        private void prenomTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomTxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listeEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            var current = from et in listetudiants
                          where listetudiants.IndexOf(et) == listeEtudiant.SelectedIndex
                              select et;
            Etdiant a = current.ElementAt(0);
            nomTxtBox.Text = a.Nom;
            prenomTextBox.Text = a.Prenom;
            noteTextBox.Text = a.Note.ToString();
        }

        private void Message_Click(object sender, EventArgs e)
        {
            
        }
        private void GoToVisualisation()
        {
            Valider.Enabled = true;
            Annuler.Enabled = true;
            Supprimer.Enabled = false;
            Modifier.Enabled = false;
            Ajouter.Enabled = false;
        }
        private void CleanTxtBoxes (){
            nomTxtBox.Text = "";
            prenomTextBox.Text = "";
            noteTextBox.Text = "";
        }
        private void BackToVisualisation()
        {
            Valider.Enabled = false;
            Annuler.Enabled = false;
            
            Ajouter.Enabled = true;
            nomTxtBox.Enabled = false;
            prenomTextBox.Enabled = false;
            noteTextBox.Enabled = false;
            listeEtudiant.Enabled = true;
            listeEtudiant.Text = "--- Select ---";
            if (listetudiants.Any()) { 
                Supprimer.Enabled = true;
                Modifier.Enabled = true;
            }
            else { 
             Supprimer.Enabled = false;
              Modifier.Enabled = false;
            }
            currentaction = -1;
        }
    }
}
