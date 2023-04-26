
namespace PROJET_PPE2._1_KARATE
{
    partial class Frm_SupprNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SupprNotes));
            this.GridView_Note = new System.Windows.Forms.DataGridView();
            this.Lbl_Competition = new System.Windows.Forms.Label();
            this.Cmd_delete = new System.Windows.Forms.Button();
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_LICENCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd_Quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Note)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView_Note
            // 
            this.GridView_Note.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Note.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION,
            this.NUM_LICENCE,
            this.NUM_ENTRAINEUR,
            this.NOTE});
            this.GridView_Note.Location = new System.Drawing.Point(96, 101);
            this.GridView_Note.Name = "GridView_Note";
            this.GridView_Note.RowHeadersWidth = 62;
            this.GridView_Note.RowTemplate.Height = 28;
            this.GridView_Note.Size = new System.Drawing.Size(995, 286);
            this.GridView_Note.TabIndex = 0;
            // 
            // Lbl_Competition
            // 
            this.Lbl_Competition.AutoSize = true;
            this.Lbl_Competition.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Competition.Font = new System.Drawing.Font("Poppins Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Competition.Location = new System.Drawing.Point(393, 31);
            this.Lbl_Competition.Name = "Lbl_Competition";
            this.Lbl_Competition.Size = new System.Drawing.Size(386, 58);
            this.Lbl_Competition.TabIndex = 4;
            this.Lbl_Competition.Text = "SUPPRIMER UNE NOTE";
            this.Lbl_Competition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmd_delete
            // 
            this.Cmd_delete.BackColor = System.Drawing.Color.IndianRed;
            this.Cmd_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmd_delete.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_delete.ForeColor = System.Drawing.Color.White;
            this.Cmd_delete.Location = new System.Drawing.Point(503, 455);
            this.Cmd_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cmd_delete.Name = "Cmd_delete";
            this.Cmd_delete.Size = new System.Drawing.Size(172, 56);
            this.Cmd_delete.TabIndex = 9;
            this.Cmd_delete.Text = "SUPPRIMER";
            this.Cmd_delete.UseVisualStyleBackColor = false;
            this.Cmd_delete.Click += new System.EventHandler(this.Cmd_delete_Click);
            // 
            // NUM_COMPETITION
            // 
            this.NUM_COMPETITION.HeaderText = "NUM_COMPETITION";
            this.NUM_COMPETITION.MinimumWidth = 8;
            this.NUM_COMPETITION.Name = "NUM_COMPETITION";
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
            // NUM_ENTRAINEUR
            // 
            this.NUM_ENTRAINEUR.HeaderText = "NUM_ENTRAINEUR";
            this.NUM_ENTRAINEUR.MinimumWidth = 8;
            this.NUM_ENTRAINEUR.Name = "NUM_ENTRAINEUR";
            this.NUM_ENTRAINEUR.ReadOnly = true;
            this.NUM_ENTRAINEUR.Width = 150;
            // 
            // NOTE
            // 
            this.NOTE.HeaderText = "NOTE";
            this.NOTE.MinimumWidth = 8;
            this.NOTE.Name = "NOTE";
            this.NOTE.ReadOnly = true;
            this.NOTE.Width = 150;
            // 
            // cmd_Quitter
            // 
            this.cmd_Quitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_Quitter.BackgroundImage")));
            this.cmd_Quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Quitter.FlatAppearance.BorderSize = 2;
            this.cmd_Quitter.Location = new System.Drawing.Point(1094, 491);
            this.cmd_Quitter.Name = "cmd_Quitter";
            this.cmd_Quitter.Size = new System.Drawing.Size(78, 78);
            this.cmd_Quitter.TabIndex = 11;
            this.cmd_Quitter.UseVisualStyleBackColor = true;
            this.cmd_Quitter.Click += new System.EventHandler(this.cmd_Quitter_Click);
            // 
            // Frm_SupprNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 581);
            this.Controls.Add(this.cmd_Quitter);
            this.Controls.Add(this.Cmd_delete);
            this.Controls.Add(this.Lbl_Competition);
            this.Controls.Add(this.GridView_Note);
            this.Name = "Frm_SupprNotes";
            this.Text = "Supprimer note";
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Note)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView_Note;
        private System.Windows.Forms.Label Lbl_Competition;
        private System.Windows.Forms.Button Cmd_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_LICENCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_ENTRAINEUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE;
        private System.Windows.Forms.Button cmd_Quitter;
    }
}