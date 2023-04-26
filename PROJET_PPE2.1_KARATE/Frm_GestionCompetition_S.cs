using MySql.Data.MySqlClient;
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
    public partial class Frm_GestionCompetition_S : Form
    {
        public Frm_GestionCompetition_S()
        {
            InitializeComponent();
        

            MySqlConnection conn = bdd.ConnectionBD();

            conn.Open();

            string sqlCompet = "SELECT * FROM competition";

            MySqlCommand cmdCompet = new MySqlCommand(sqlCompet, conn);

            MySqlDataReader readerMembre = cmdCompet.ExecuteReader();

            while (readerMembre.Read())
            {
                string NUM_COMPETITION = (readerMembre["NUM_COMPETITION"].ToString());
                string NUM_CLUB = (readerMembre["NUM_CLUB"].ToString());
                string DATE_COMPETITION = (readerMembre["DATE_COMPETITION"].ToString());

                dataGridView1.Rows.Add(NUM_COMPETITION, NUM_CLUB, DATE_COMPETITION);
            }


            readerMembre.Close();

            conn.Close();

            conn.Open();
            string sqlClub = "SELECT NUM_CLUB, NOM_CLUB FROM club";

            MySqlCommand cmdClub = new MySqlCommand(sqlClub, conn);
            MySqlDataReader readerClub = cmdClub.ExecuteReader();

            while (readerClub.Read())
            {
                string NUM_CLUB = (readerClub["NUM_CLUB"].ToString());
                string NOM_CLUB = (readerClub["NOM_CLUB"].ToString());
          

                dataGridViewClub.Rows.Add(NUM_CLUB, NOM_CLUB, DATE_COMPETITION);
            }

            readerClub.Close();
            conn.Close();
        }

   
        private void Cmd_supprimer_Click(object sender, EventArgs e)

        {
            
            MySqlConnection conn = bdd.ConnectionBD();

            conn.Open();
       
            int ligne = dataGridView1.CurrentCell.RowIndex;
            int numCompet = Convert.ToInt16(dataGridView1[0, ligne].Value);

            string sqlDelete = "DELETE FROM competition WHERE NUM_COMPETITION = @numCompet";
            MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, conn);
            cmdDelete.Parameters.AddWithValue("@numCompet", numCompet);


            string sqlNumCompet = "SELECT NUM_COMPETITION FROM inscription";
            MySqlCommand cmdCompet = new MySqlCommand(sqlNumCompet, conn);

            // gestion de l'erreur au niveau de la requete SQL
            try
            {
                cmdDelete.ExecuteNonQuery();
            }
            catch(MySqlException a)
            {
                
                MessageBox.Show("Impossible de suppimer des compétitions avec des personnes inscrites");
            }
            conn.Close();
            Form.ActiveForm.Close();
        }

       

        private void Cmd_modifier_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();

            int ligne = dataGridViewClub.CurrentCell.RowIndex;
            int numCompet = Convert.ToInt16(dataGridView1[0, ligne].Value);

            if (txt_club.Text != "")
            {
                int numClub = int.Parse(txt_club.Text);
                string SqlNumClub = "SELECT NUM_CLUB FROM club where num_club=@numClub";
                MySqlCommand cmdClub = new MySqlCommand(SqlNumClub, conn);
                cmdClub.Parameters.AddWithValue("@numClub", numClub);

                MySqlDataReader reader = cmdClub.ExecuteReader();
  

                if (dateTimePicker1.Value.Date >= DateTime.Today && txt_club.Text != "")
                {           
                    if (reader.Read())
                    {
                        conn.Close();
                        conn.Open();
                       
                        string updateSQL = "UPDATE competition SET NUM_CLUB =@numClub ," +
                       "DATE_COMPETITION=@dateCompet WHERE NUM_COMPETITION=@numCompet ";
                        MySqlCommand cmdUpdate = new MySqlCommand(updateSQL, conn);
                        cmdUpdate.Parameters.AddWithValue("@numClub", numClub);
                        cmdUpdate.Parameters.AddWithValue("@dateCompet", dateTimePicker1.Value);
                        cmdUpdate.Parameters.AddWithValue("@numCompet", numCompet);

                        cmdUpdate.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Club inexistant");
                    }
                }
                else
                {
                    MessageBox.Show("Date incorrect");
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("Club invalide");
            }

            conn.Close();
            Form.ActiveForm.Close();

        }

        private void txt_club_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmd_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
