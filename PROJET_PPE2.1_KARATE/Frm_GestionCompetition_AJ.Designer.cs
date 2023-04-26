namespace PROJET_PPE2._1_KARATE
{
    partial class Frm_GestionCompetition_AJ
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GestionCompetition_AJ));
            this.Cmd_Ajouter = new System.Windows.Forms.Button();
            this.Cmd_Annuler = new System.Windows.Forms.Button();
            this.Lbl_Competition = new System.Windows.Forms.Label();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Lbl_Num_Club = new System.Windows.Forms.Label();
            this.Txt_Num_Club = new System.Windows.Forms.TextBox();
            this.Date_Competition = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Cmd_Ajouter
            // 
            this.Cmd_Ajouter.BackColor = System.Drawing.Color.Peru;
            this.Cmd_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmd_Ajouter.Font = new System.Drawing.Font("Poppins Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Ajouter.ForeColor = System.Drawing.Color.White;
            this.Cmd_Ajouter.Location = new System.Drawing.Point(217, 360);
            this.Cmd_Ajouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmd_Ajouter.Name = "Cmd_Ajouter";
            this.Cmd_Ajouter.Size = new System.Drawing.Size(122, 38);
            this.Cmd_Ajouter.TabIndex = 0;
            this.Cmd_Ajouter.Text = "AJOUTER";
            this.Cmd_Ajouter.UseVisualStyleBackColor = false;
            this.Cmd_Ajouter.Click += new System.EventHandler(this.Cmd_Ajouter_Click);
            // 
            // Cmd_Annuler
            // 
            this.Cmd_Annuler.BackColor = System.Drawing.Color.IndianRed;
            this.Cmd_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmd_Annuler.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Annuler.ForeColor = System.Drawing.Color.White;
            this.Cmd_Annuler.Location = new System.Drawing.Point(430, 360);
            this.Cmd_Annuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmd_Annuler.Name = "Cmd_Annuler";
            this.Cmd_Annuler.Size = new System.Drawing.Size(122, 38);
            this.Cmd_Annuler.TabIndex = 1;
            this.Cmd_Annuler.Text = "FERMER";
            this.Cmd_Annuler.UseVisualStyleBackColor = false;
            this.Cmd_Annuler.Click += new System.EventHandler(this.Cmd_Annuler_Click);
            // 
            // Lbl_Competition
            // 
            this.Lbl_Competition.AutoSize = true;
            this.Lbl_Competition.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Competition.Font = new System.Drawing.Font("Poppins Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Competition.Location = new System.Drawing.Point(164, 49);
            this.Lbl_Competition.Name = "Lbl_Competition";
            this.Lbl_Competition.Size = new System.Drawing.Size(472, 56);
            this.Lbl_Competition.TabIndex = 2;
            this.Lbl_Competition.Text = "AJOUT D\'UNE COMPETITION";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Date.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Date.Location = new System.Drawing.Point(90, 251);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(206, 28);
            this.Lbl_Date.TabIndex = 5;
            this.Lbl_Date.Text = "Date de la compétition :";
            // 
            // Lbl_Num_Club
            // 
            this.Lbl_Num_Club.AutoSize = true;
            this.Lbl_Num_Club.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Num_Club.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Num_Club.Location = new System.Drawing.Point(90, 196);
            this.Lbl_Num_Club.Name = "Lbl_Num_Club";
            this.Lbl_Num_Club.Size = new System.Drawing.Size(152, 28);
            this.Lbl_Num_Club.TabIndex = 6;
            this.Lbl_Num_Club.Text = "Numéro du club :";
            // 
            // Txt_Num_Club
            // 
            this.Txt_Num_Club.Location = new System.Drawing.Point(302, 195);
            this.Txt_Num_Club.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Num_Club.Name = "Txt_Num_Club";
            this.Txt_Num_Club.Size = new System.Drawing.Size(200, 26);
            this.Txt_Num_Club.TabIndex = 8;
            this.Txt_Num_Club.TextChanged += new System.EventHandler(this.Txt_Num_Club_TextChanged);
            // 
            // Date_Competition
            // 
            this.Date_Competition.Location = new System.Drawing.Point(302, 251);
            this.Date_Competition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Date_Competition.Name = "Date_Competition";
            this.Date_Competition.Size = new System.Drawing.Size(200, 26);
            this.Date_Competition.TabIndex = 9;
            // 
            // Frm_GestionCompetition_AJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Date_Competition);
            this.Controls.Add(this.Txt_Num_Club);
            this.Controls.Add(this.Lbl_Num_Club);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.Lbl_Competition);
            this.Controls.Add(this.Cmd_Annuler);
            this.Controls.Add(this.Cmd_Ajouter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_GestionCompetition_AJ";
            this.Text = "Ajouter compétition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cmd_Ajouter;
        private System.Windows.Forms.Button Cmd_Annuler;
        private System.Windows.Forms.Label Lbl_Competition;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.Label Lbl_Num_Club;
        private System.Windows.Forms.TextBox Txt_Num_Club;
        private System.Windows.Forms.DateTimePicker Date_Competition;
    }
}

