
namespace FormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listeEtudiant = new System.Windows.Forms.ComboBox();
            this.Modifier = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Ajouter = new System.Windows.Forms.Button();
            this.nomTxtBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listeEtudiant
            // 
            this.listeEtudiant.FormattingEnabled = true;
            resources.ApplyResources(this.listeEtudiant, "listeEtudiant");
            this.listeEtudiant.Name = "listeEtudiant";
            this.listeEtudiant.SelectedIndexChanged += new System.EventHandler(this.listeEtudiant_SelectedIndexChanged);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.MediumSeaGreen;
            resources.ApplyResources(this.Modifier, "Modifier");
            this.Modifier.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.Modifier.FlatAppearance.BorderSize = 2;
            this.Modifier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Modifier.Name = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.Annuler, "Annuler");
            this.Annuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Annuler.FlatAppearance.BorderSize = 2;
            this.Annuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Annuler.Name = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Valider
            // 
            this.Valider.BackColor = System.Drawing.Color.MediumSpringGreen;
            resources.ApplyResources(this.Valider, "Valider");
            this.Valider.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Valider.FlatAppearance.BorderSize = 2;
            this.Valider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Valider.Name = "Valider";
            this.Valider.UseVisualStyleBackColor = false;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Name = "label6";
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.YellowGreen;
            this.Ajouter.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.Ajouter.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.Ajouter, "Ajouter");
            this.Ajouter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // nomTxtBox
            // 
            resources.ApplyResources(this.nomTxtBox, "nomTxtBox");
            this.nomTxtBox.Name = "nomTxtBox";
            this.nomTxtBox.TextChanged += new System.EventHandler(this.nomTxtBox_TextChanged);
            // 
            // prenomTextBox
            // 
            resources.ApplyResources(this.prenomTextBox, "prenomTextBox");
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.TextChanged += new System.EventHandler(this.prenomTextBox_TextChanged);
            // 
            // noteTextBox
            // 
            resources.ApplyResources(this.noteTextBox, "noteTextBox");
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.TextChanged += new System.EventHandler(this.noteTextBox_TextChanged);
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.Supprimer, "Supprimer");
            this.Supprimer.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Supprimer.FlatAppearance.BorderSize = 2;
            this.Supprimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Message
            // 
            resources.ApplyResources(this.Message, "Message");
            this.Message.BackColor = System.Drawing.Color.Transparent;
            this.Message.ForeColor = System.Drawing.Color.Red;
            this.Message.Name = "Message";
            this.Message.Click += new System.EventHandler(this.Message_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.Message);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(this.nomTxtBox);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.listeEtudiant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox listeEtudiant;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.TextBox nomTxtBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Label Message;
    }
}

