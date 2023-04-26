
namespace PROJET_PPE2._1_KARATE
{
    partial class Frm_Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Notes));
            this.Grid_Inscription = new System.Windows.Forms.DataGridView();
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_LICENCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_compet = new System.Windows.Forms.Label();
            this.txt_numCompet = new System.Windows.Forms.TextBox();
            this.lbl_numLicence = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_numLicence = new System.Windows.Forms.TextBox();
            this.lbl_jury1 = new System.Windows.Forms.Label();
            this.txt_noteJury1 = new System.Windows.Forms.TextBox();
            this.txt_noteJury2 = new System.Windows.Forms.TextBox();
            this.lbl_jury2 = new System.Windows.Forms.Label();
            this.Cmd_SaisirNote = new System.Windows.Forms.Button();
            this.cmd_Quitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Inscription)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Inscription
            // 
            this.Grid_Inscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Inscription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION,
            this.NUM_LICENCE});
            this.Grid_Inscription.Location = new System.Drawing.Point(211, 87);
            this.Grid_Inscription.Name = "Grid_Inscription";
            this.Grid_Inscription.RowHeadersWidth = 62;
            this.Grid_Inscription.RowTemplate.Height = 28;
            this.Grid_Inscription.Size = new System.Drawing.Size(596, 256);
            this.Grid_Inscription.TabIndex = 0;
            // 
            // NUM_COMPETITION
            // 
            this.NUM_COMPETITION.HeaderText = "NUM_COMPETITION";
            this.NUM_COMPETITION.MinimumWidth = 8;
            this.NUM_COMPETITION.Name = "NUM_COMPETITION";
            this.NUM_COMPETITION.ReadOnly = true;
            this.NUM_COMPETITION.Width = 150;
            // 
            // NUM_LICENCE
            // 
            this.NUM_LICENCE.HeaderText = "NUM_LICENCE";
            this.NUM_LICENCE.MinimumWidth = 8;
            this.NUM_LICENCE.Name = "NUM_LICENCE";
            this.NUM_LICENCE.ReadOnly = true;
            this.NUM_LICENCE.Width = 150;
            // 
            // lbl_compet
            // 
            this.lbl_compet.AutoSize = true;
            this.lbl_compet.BackColor = System.Drawing.Color.Transparent;
            this.lbl_compet.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_compet.Location = new System.Drawing.Point(57, 379);
            this.lbl_compet.Name = "lbl_compet";
            this.lbl_compet.Size = new System.Drawing.Size(268, 36);
            this.lbl_compet.TabIndex = 1;
            this.lbl_compet.Text = "Numéro de compétition :";
            // 
            // txt_numCompet
            // 
            this.txt_numCompet.Location = new System.Drawing.Point(354, 383);
            this.txt_numCompet.Name = "txt_numCompet";
            this.txt_numCompet.Size = new System.Drawing.Size(159, 26);
            this.txt_numCompet.TabIndex = 2;
            // 
            // lbl_numLicence
            // 
            this.lbl_numLicence.AutoSize = true;
            this.lbl_numLicence.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numLicence.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numLicence.Location = new System.Drawing.Point(57, 442);
            this.lbl_numLicence.Name = "lbl_numLicence";
            this.lbl_numLicence.Size = new System.Drawing.Size(215, 36);
            this.lbl_numLicence.TabIndex = 3;
            this.lbl_numLicence.Text = "Numéro de licence :";
            // 
            // txt_numLicence
            // 
            this.txt_numLicence.Location = new System.Drawing.Point(354, 442);
            this.txt_numLicence.Name = "txt_numLicence";
            this.txt_numLicence.Size = new System.Drawing.Size(159, 26);
            this.txt_numLicence.TabIndex = 4;
            // 
            // lbl_jury1
            // 
            this.lbl_jury1.AutoSize = true;
            this.lbl_jury1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jury1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jury1.Location = new System.Drawing.Point(57, 499);
            this.lbl_jury1.Name = "lbl_jury1";
            this.lbl_jury1.Size = new System.Drawing.Size(161, 36);
            this.lbl_jury1.TabIndex = 5;
            this.lbl_jury1.Text = "Note du jury 1 :";
            // 
            // txt_noteJury1
            // 
            this.txt_noteJury1.Location = new System.Drawing.Point(354, 499);
            this.txt_noteJury1.Name = "txt_noteJury1";
            this.txt_noteJury1.Size = new System.Drawing.Size(159, 26);
            this.txt_noteJury1.TabIndex = 6;
            // 
            // txt_noteJury2
            // 
            this.txt_noteJury2.Location = new System.Drawing.Point(354, 557);
            this.txt_noteJury2.Name = "txt_noteJury2";
            this.txt_noteJury2.Size = new System.Drawing.Size(159, 26);
            this.txt_noteJury2.TabIndex = 7;
            // 
            // lbl_jury2
            // 
            this.lbl_jury2.AutoSize = true;
            this.lbl_jury2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jury2.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jury2.Location = new System.Drawing.Point(57, 553);
            this.lbl_jury2.Name = "lbl_jury2";
            this.lbl_jury2.Size = new System.Drawing.Size(164, 36);
            this.lbl_jury2.TabIndex = 8;
            this.lbl_jury2.Text = "Note du jury 2 :";
            // 
            // Cmd_SaisirNote
            // 
            this.Cmd_SaisirNote.BackColor = System.Drawing.Color.Peru;
            this.Cmd_SaisirNote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmd_SaisirNote.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_SaisirNote.ForeColor = System.Drawing.Color.White;
            this.Cmd_SaisirNote.Location = new System.Drawing.Point(610, 450);
            this.Cmd_SaisirNote.Name = "Cmd_SaisirNote";
            this.Cmd_SaisirNote.Size = new System.Drawing.Size(145, 65);
            this.Cmd_SaisirNote.TabIndex = 9;
            this.Cmd_SaisirNote.Text = "INSERER";
            this.Cmd_SaisirNote.UseVisualStyleBackColor = false;
            this.Cmd_SaisirNote.Click += new System.EventHandler(this.Cmd_SaisirNote_Click);
            // 
            // cmd_Quitter
            // 
            this.cmd_Quitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_Quitter.BackgroundImage")));
            this.cmd_Quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Quitter.FlatAppearance.BorderSize = 2;
            this.cmd_Quitter.Location = new System.Drawing.Point(916, 516);
            this.cmd_Quitter.Name = "cmd_Quitter";
            this.cmd_Quitter.Size = new System.Drawing.Size(78, 78);
            this.cmd_Quitter.TabIndex = 10;
            this.cmd_Quitter.UseVisualStyleBackColor = true;
            this.cmd_Quitter.Click += new System.EventHandler(this.cmd_Quitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 70);
            this.label1.TabIndex = 11;
            this.label1.Text = "AJOUT DE NOTES";
            // 
            // Frm_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1016, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_Quitter);
            this.Controls.Add(this.Cmd_SaisirNote);
            this.Controls.Add(this.lbl_jury2);
            this.Controls.Add(this.txt_noteJury2);
            this.Controls.Add(this.txt_noteJury1);
            this.Controls.Add(this.lbl_jury1);
            this.Controls.Add(this.txt_numLicence);
            this.Controls.Add(this.lbl_numLicence);
            this.Controls.Add(this.txt_numCompet);
            this.Controls.Add(this.lbl_compet);
            this.Controls.Add(this.Grid_Inscription);
            this.Name = "Frm_Notes";
            this.Text = "Ajouter note";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Inscription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Inscription;
        private System.Windows.Forms.Label lbl_compet;
        private System.Windows.Forms.TextBox txt_numCompet;
        private System.Windows.Forms.Label lbl_numLicence;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_numLicence;
        private System.Windows.Forms.Label lbl_jury1;
        private System.Windows.Forms.TextBox txt_noteJury1;
        private System.Windows.Forms.TextBox txt_noteJury2;
        private System.Windows.Forms.Label lbl_jury2;
        private System.Windows.Forms.Button Cmd_SaisirNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_LICENCE;
        private System.Windows.Forms.Button cmd_Quitter;
        private System.Windows.Forms.Label label1;
    }
}