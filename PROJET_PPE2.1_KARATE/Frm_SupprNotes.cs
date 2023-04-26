using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJET_PPE2._1_KARATE
{
    public partial class Frm_SupprNotes : Form
    {
        public Frm_SupprNotes()
        {
            InitializeComponent();


            MySqlConnection conn = bdd.ConnectionBD();

            conn.Open();
            string sqlnote= "SELECT NUM_COMPETITION, NUM_LICENCE, NUM_ENTRAINEUR, NOTE FROM note";

            MySqlCommand cmdNote = new MySqlCommand(sqlnote, conn);
            MySqlDataReader readerNote = cmdNote.ExecuteReader();

            while (readerNote.Read())
            {
                string NUM_LICENCE = (readerNote["NUM_LICENCE"].ToString());
                string NUM_ENTRAINEUR = (readerNote["NUM_ENTRAINEUR"].ToString());
                string NOTE = (readerNote["NOTE"].ToString());
                string NUM_COMPETITION = (readerNote["NUM_COMPETITION"].ToString());


                GridView_Note.Rows.Add(NUM_COMPETITION,NUM_LICENCE, NUM_ENTRAINEUR, NOTE);
            }

            readerNote.Close();
            conn.Close();
        }

        private void Cmd_delete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();

            conn.Open();

            int ligne = GridView_Note.CurrentCell.RowIndex;

            decimal note = Convert.ToDecimal(GridView_Note[3, ligne].Value);
            int numEntraineur = Convert.ToInt32(GridView_Note[2, ligne].Value);
            string numLicence = GridView_Note[1, ligne].Value.ToString();
            int numCompet = Convert.ToInt32(GridView_Note[0, ligne].Value);

            string sqlDelete = "DELETE FROM note WHERE NOTE = @note AND NUM_LICENCE =@numLicence AND NUM_ENTRAINEUR=@numEntraineur AND NUM_COMPETITION=@numCompet";

            // J'ai mis la variable valeur ici qui permet d'avoir l'ID.

            MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, conn);

            cmdDelete.Parameters.AddWithValue("@note", note);
            cmdDelete.Parameters.AddWithValue("@numCompet", numCompet);
            cmdDelete.Parameters.AddWithValue("@numEntraineur", numEntraineur);
            cmdDelete.Parameters.AddWithValue("@numLicence", numLicence);
           
            cmdDelete.ExecuteNonQuery();
            conn.Close();

            this.Close();
        }

        private void cmd_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
