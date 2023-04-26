using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET_PPE2._1_KARATE
{
    public partial class Frm_AccueilCompetition : Form
    {
        public Frm_AccueilCompetition()
        {
            InitializeComponent();
        }

        private void Cmd_Ajouter_Click(object sender, EventArgs e)
        {
            Frm_GestionCompetition_AJ frm = new Frm_GestionCompetition_AJ();
            frm.Show();
        }

        private void Cmd_Supprimer_Click(object sender, EventArgs e)
        {
            Frm_GestionCompetition_S frm2 = new Frm_GestionCompetition_S();
            frm2.Show();
        }

        private void cmd_Quitter_Click(object sender, EventArgs e)
        {
            
            Form.ActiveForm.Close();
        }

        private void Cmd_SaisirNote_Click(object sender, EventArgs e)
        {

            Frm_Notes frmNote = new Frm_Notes();
            frmNote.Show();
        }

        private void Cmd_SupprNote_Click(object sender, EventArgs e)
        {
            Frm_SupprNotes frm_SupprNotes = new Frm_SupprNotes();
            frm_SupprNotes.Show();

        }
    }
}

