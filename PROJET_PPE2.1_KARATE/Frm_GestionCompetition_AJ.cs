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
    public partial class Frm_GestionCompetition_AJ : Form
    {
        public Frm_GestionCompetition_AJ()
        {
            InitializeComponent();
        }

        private void Cmd_Ajouter_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();


            // Selection du plus grand NUM_COMPETITION de la table pour auto incrémenter
            string SqlNumCompet = "SELECT MAX(NUM_COMPETITION) as Max_Compet FROM competition";

            MySqlCommand cmd = new MySqlCommand(SqlNumCompet, conn); 

            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            // conversion en entier le numéro obtenu
            int nb = Int32.Parse(reader["Max_Compet"].ToString());

            reader.Close();

           

            
            // Vérification numéro de club existant

            string sqlNumClub = "SELECT NUM_CLUB FROM club where num_club=@numClub";

            MySqlCommand cmdClub = new MySqlCommand(sqlNumClub, conn);

            cmdClub.Parameters.AddWithValue("@numClub", Txt_Num_Club.Text);

            MySqlDataReader readerClub = cmdClub.ExecuteReader();

            if (readerClub.Read())
            {
                conn.Close();
                conn.Open();

                string sql = "INSERT INTO competition (NUM_COMPETITION,NUM_CLUB,DATE_COMPETITION)" +
                    " VALUES(@numCompet,@numClubSaisie,@DateCompet)";
                MySqlCommand cmdInsert = new MySqlCommand(sql, conn);

                cmdInsert.Parameters.AddWithValue("@numCompet", nb + 1);
                cmdInsert.Parameters.AddWithValue("@numClubSaisie", Txt_Num_Club.Text);
                cmdInsert.Parameters.AddWithValue("@DateCompet", Date_Competition.Value);

                if (Date_Competition.Value.Date >= DateTime.Today && Txt_Num_Club.Text!="")
                {
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("Compétition ajoutée");
                    Txt_Num_Club.Clear();
                }
                else
                {
                    MessageBox.Show("Date incorrect");
                }

            }
            else
            {
                MessageBox.Show("Numéro de club inexistant");
            }
            

            conn.Close();
        }

        private void Cmd_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Num_Club_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
