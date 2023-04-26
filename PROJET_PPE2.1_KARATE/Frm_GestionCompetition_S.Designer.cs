
namespace PROJET_PPE2._1_KARATE
{
    partial class Frm_GestionCompetition_S
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GestionCompetition_S));
            this.Lbl_Competition = new System.Windows.Forms.Label();
            this.Cmd_supprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewClub = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmd_modifier = new System.Windows.Forms.Button();
            this.txt_club = new System.Windows.Forms.TextBox();
            this.lbl_Club = new System.Windows.Forms.Label();
            this.lbl_compet = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_Quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClub)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Competition
            // 
            this.Lbl_Competition.AutoSize = true;
            this.Lbl_Competition.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Competition.Font = new System.Drawing.Font("Poppins Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Competition.Location = new System.Drawing.Point(254, 24);
            this.Lbl_Competition.Name = "Lbl_Competition";
            this.Lbl_Competition.Size = new System.Drawing.Size(531, 58);
            this.Lbl_Competition.TabIndex = 3;
            this.Lbl_Competition.Text = "SUPPRIMER UNE COMPETITION";
            this.Lbl_Competition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmd_supprimer
            // 
            this.Cmd_supprimer.BackColor = System.Drawing.Color.Peru;
            this.Cmd_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmd_supprimer.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_supprimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Cmd_supprimer.Location = new System.Drawing.Point(421, 315);
            this.Cmd_supprimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cmd_supprimer.Name = "Cmd_supprimer";
            this.Cmd_supprimer.Size = new System.Drawing.Size(172, 56);
            this.Cmd_supprimer.TabIndex = 5;
            this.Cmd_supprimer.Text = "SUPPRIMER";
            this.Cmd_supprimer.UseVisualStyleBackColor = false;
            this.Cmd_supprimer.Click += new System.EventHandler(this.Cmd_supprimer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION,
            this.NUM_CLUB,
            this.DATE_COMPETITION});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(155, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 196);
            this.dataGridView1.TabIndex = 6;
            // 
            // NUM_COMPETITION
            // 
            this.NUM_COMPETITION.HeaderText = "NUM_COMPETITION";
            this.NUM_COMPETITION.MinimumWidth = 6;
            this.NUM_COMPETITION.Name = "NUM_COMPETITION";
            this.NUM_COMPETITION.Width = 125;
            // 
            // NUM_CLUB
            // 
            this.NUM_CLUB.HeaderText = "NUM_CLUB";
            this.NUM_CLUB.MinimumWidth = 6;
            this.NUM_CLUB.Name = "NUM_CLUB";
            this.NUM_CLUB.Width = 125;
            // 
            // DATE_COMPETITION
            // 
            this.DATE_COMPETITION.HeaderText = "DATE_COMPETITION";
            this.DATE_COMPETITION.MinimumWidth = 6;
            this.DATE_COMPETITION.Name = "DATE_COMPETITION";
            this.DATE_COMPETITION.Width = 150;
            // 
            // dataGridViewClub
            // 
            this.dataGridViewClub.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridViewClub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewClub.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nom_club});
            this.dataGridViewClub.Location = new System.Drawing.Point(277, 487);
            this.dataGridViewClub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewClub.Name = "dataGridViewClub";
            this.dataGridViewClub.RowHeadersWidth = 51;
            this.dataGridViewClub.RowTemplate.Height = 24;
            this.dataGridViewClub.Size = new System.Drawing.Size(467, 196);
            this.dataGridViewClub.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "NUM_CLUB";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // nom_club
            // 
            this.nom_club.HeaderText = "NOM_CLUB";
            this.nom_club.MinimumWidth = 6;
            this.nom_club.Name = "nom_club";
            this.nom_club.Width = 125;
            // 
            // Cmd_modifier
            // 
            this.Cmd_modifier.BackColor = System.Drawing.Color.IndianRed;
            this.Cmd_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmd_modifier.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_modifier.ForeColor = System.Drawing.Color.White;
            this.Cmd_modifier.Location = new System.Drawing.Point(421, 716);
            this.Cmd_modifier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cmd_modifier.Name = "Cmd_modifier";
            this.Cmd_modifier.Size = new System.Drawing.Size(172, 56);
            this.Cmd_modifier.TabIndex = 8;
            this.Cmd_modifier.Text = "MODIFIER";
            this.Cmd_modifier.UseVisualStyleBackColor = false;
            this.Cmd_modifier.Click += new System.EventHandler(this.Cmd_modifier_Click);
            // 
            // txt_club
            // 
            this.txt_club.Location = new System.Drawing.Point(240, 755);
            this.txt_club.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_club.Name = "txt_club";
            this.txt_club.Size = new System.Drawing.Size(122, 26);
            this.txt_club.TabIndex = 11;
          
            // 
            // lbl_Club
            // 
            this.lbl_Club.AutoSize = true;
            this.lbl_Club.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Club.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Club.Location = new System.Drawing.Point(270, 716);
            this.lbl_Club.Name = "lbl_Club";
            this.lbl_Club.Size = new System.Drawing.Size(101, 37);
            this.lbl_Club.TabIndex = 12;
            this.lbl_Club.Text = "N° CLUB";
            // 
            // lbl_compet
            // 
            this.lbl_compet.AutoSize = true;
            this.lbl_compet.BackColor = System.Drawing.Color.Transparent;
            this.lbl_compet.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_compet.Location = new System.Drawing.Point(631, 716);
            this.lbl_compet.Name = "lbl_compet";
            this.lbl_compet.Size = new System.Drawing.Size(267, 37);
            this.lbl_compet.TabIndex = 13;
            this.lbl_compet.Text = "Date de la Compétition ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(637, 755);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 58);
            this.label1.TabIndex = 15;
            this.label1.Text = "MODIFIER UNE COMPETITION";
            // 
            // cmd_Quitter
            // 
            this.cmd_Quitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_Quitter.BackgroundImage")));
            this.cmd_Quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Quitter.FlatAppearance.BorderSize = 2;
            this.cmd_Quitter.Location = new System.Drawing.Point(907, 800);
            this.cmd_Quitter.Name = "cmd_Quitter";
            this.cmd_Quitter.Size = new System.Drawing.Size(78, 78);
            this.cmd_Quitter.TabIndex = 16;
            this.cmd_Quitter.UseVisualStyleBackColor = true;
            this.cmd_Quitter.Click += new System.EventHandler(this.cmd_Quitter_Click);
            // 
            // Frm_GestionCompetition_S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PROJET_PPE2._1_KARATE.Properties.Resources.degrade_gris;
            this.ClientSize = new System.Drawing.Size(997, 890);
            this.Controls.Add(this.cmd_Quitter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_compet);
            this.Controls.Add(this.lbl_Club);
            this.Controls.Add(this.txt_club);
            this.Controls.Add(this.Cmd_modifier);
            this.Controls.Add(this.dataGridViewClub);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cmd_supprimer);
            this.Controls.Add(this.Lbl_Competition);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_GestionCompetition_S";
            this.Text = "Editer compétition";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Competition;
        private System.Windows.Forms.Button Cmd_supprimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_club;
        private System.Windows.Forms.Button Cmd_modifier;
        private System.Windows.Forms.TextBox txt_club;
        private System.Windows.Forms.Label lbl_Club;
        private System.Windows.Forms.Label lbl_compet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_Quitter;
    }
}