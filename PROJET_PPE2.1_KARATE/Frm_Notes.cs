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
    public partial class Frm_Notes : Form
    {
            public Frm_Notes()
            {
                InitializeComponent();

                MySqlConnection conn = bdd.ConnectionBD();

                conn.Open();

                string sqlInscription = "SELECT * FROM inscription";

                MySqlCommand cmdNote1 = new MySqlCommand(sqlInscription, conn);

                MySqlDataReader readerInscription = cmdNote1.ExecuteReader();

                while (readerInscription.Read())
                {
                    string NUM_COMPETITION = (readerInscription["NUM_COMPETITION"].ToString());
                    string NUM_LICENCE = (readerInscription["NUM_LICENCE"].ToString());
                

                    Grid_Inscription.Rows.Add(NUM_COMPETITION, NUM_LICENCE);
                }



                conn.Close();

            }

        private void Cmd_SaisirNote_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();

            conn.Open();

            string noteSQL = "INSERT INTO note (NUM_COMPETITION,NUM_LICENCE,NUM_ENTRAINEUR,NOTE) VALUES (@numCompet,@numLicence,1,@note)";

            MySqlCommand cmdNote1 = new MySqlCommand(noteSQL, conn);

            if (txt_noteJury1.Text !="" && txt_noteJury2.Text != "" && txt_numCompet.Text != "" && txt_numLicence.Text != "")
            {
                try
                {
                    cmdNote1.Parameters.AddWithValue("@numCompet", int.Parse(txt_numCompet.Text));
                    cmdNote1.Parameters.AddWithValue("@numLicence", txt_numLicence.Text);
                    cmdNote1.Parameters.AddWithValue("@note", int.Parse(txt_noteJury1.Text));

                    string note2SQL = "INSERT INTO note (NUM_COMPETITION,NUM_LICENCE,NUM_ENTRAINEUR,NOTE) VALUES (@numCompet,@numLicence,2,@note2)";

                    MySqlCommand cmdNote2 = new MySqlCommand(note2SQL, conn);

                    cmdNote2.Parameters.AddWithValue("@numCompet", int.Parse(txt_numCompet.Text));
                    cmdNote2.Parameters.AddWithValue("@numLicence", txt_numLicence.Text);
                    cmdNote2.Parameters.AddWithValue("@note2", int.Parse(txt_noteJury2.Text));


                    cmdNote1.ExecuteNonQuery();
                    cmdNote2.ExecuteNonQuery();
                    MessageBox.Show("Ajout des notes : SUCCES");
                }
                catch(MySqlException p)
                {
                    MessageBox.Show("Une note à déjà été inséré");
                }
                
            }
            else
            {
                MessageBox.Show("Erreur veuillez recommencer");
            }
            this.Close();
        }

        private void cmd_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
