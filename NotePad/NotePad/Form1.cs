using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotePad
{
   
    public partial class Form1 : Form
    {
        List<Note> list = new List<Note>();
        List<UserControl1> l;
        public string TitreNoteAModifier = "";
       

        private void UserControl_SuppressionNote(object sender, EventArgs e)
        {
            // Code à exécuter lorsqu'une note est supprimée
            // Par exemple, supprimez la UserControl associée au sender
            flowLayoutPanel1.Controls.Remove((Control)sender);
        }
      
        private void UserControl_EditButtonClick(DateTime d,string titre)
        {
            TBtitre.Text = d.ToString();
            TBtitre.Text = titre;
    
            TitreNoteAModifier = titre;

            string cnxString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\pc\Desktop\INFO2\S3\Langage C# et ASP .NET\Langage C#\NotePad\NotePad\Notes.mdf"";Integrated Security=True";
            SqlConnection cnx = new SqlConnection(cnxString);
            cnx.Open();
            string sql = "SELECT Note FROM Notes WHERE Titre = @t";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            cmd.Parameters.AddWithValue("@t", titre);
            SqlDataReader r = cmd.ExecuteReader();
            r.Read();
            TBnote.Text = r[0].ToString();
            r.Close();
            cnx.Close();

        }



        public Form1()
        {
            InitializeComponent();
           getNotes();
        
        }
      

        public  void changeContent(string note)
        {
            TBnote.Text = note;
        }
        public void getNotes()
        {
            string cnxString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\pc\Desktop\INFO2\S3\Langage C# et ASP .NET\Langage C#\NotePad\NotePad\Notes.mdf"";Integrated Security=True";
            SqlConnection cnx = new SqlConnection(cnxString);
            cnx.Open();
            string sql = "SELECT * FROM Notes";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            SqlDataReader re = cmd.ExecuteReader();

           l= new List<UserControl1>();
            int i = 0;
            flowLayoutPanel1.Controls.Clear();
            while (re.Read())
            {
                list.Add(new Note(re.GetString(1), re.GetString(2), re.GetDateTime(0)));
                UserControl1 c = new UserControl1();
               
                c.SuppressionNote += UserControl_SuppressionNote;
                 c.EditButtonClick += UserControl_EditButtonClick;
               
                c.DateModification = re.GetDateTime(0);
                c.Titre = re.GetString(1);
                //-------
             
                string texte = re.GetString(2);

                // Diviser la chaîne en mots
                string[] mots = texte.Split(' ');
                string troisPremiersMots="";

                if (mots.Length > 3)
                {
                    troisPremiersMots = string.Join(" ", mots.Take(3));
                    c.Note = troisPremiersMots + " ...";
                }
                else
                {
                    c.Note = texte;
                }


                //-------
                l.Add(c);
                flowLayoutPanel1.Controls.Add(l[i]);
                i++; 
                /// label1.Text += re.GetString(1); 
            }
            re.Close();
            cnx.Close();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
     
          
        }
        public class Note
        {
            string titre;
            string note;
            DateTime dateModification;

            public Note(string tit, string n, DateTime dm)
            {
                this.titre = tit;
                this.note = n;
                this.dateModification = dm;
            }
        }

     
      private void NewNote_Click(object sender, EventArgs e)
        {
            string cnxString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\pc\Desktop\INFO2\S3\Langage C# et ASP .NET\Langage C#\NotePad\NotePad\Notes.mdf"";Integrated Security=True";

            using (SqlConnection cnxConn = new SqlConnection(cnxString))
            {
                try
                {
                    cnxConn.Open();

                    if (!string.IsNullOrEmpty(TBtitre.Text) && !string.IsNullOrEmpty(TBnote.Text))
                    {
                        string com = "INSERT INTO Notes (DateModification, Titre, Note) VALUES (@d, @t, @n)";

                        using (SqlCommand cmnnd = new SqlCommand(com, cnxConn))
                        {
                            cmnnd.Parameters.AddWithValue("@d", DateTime.Now); 
                            cmnnd.Parameters.AddWithValue("@t", TBtitre.Text);
                            cmnnd.Parameters.AddWithValue("@n", TBnote.Text);
                            int i = cmnnd.ExecuteNonQuery();
                            TBnote.Text = "";
                            TBtitre.Text = "";
                            getNotes();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please complete all fields ! ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void TBnote_TextChanged(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
        public void ModifierN(DateTime d , string t , string n,string ancienNote)
        {
             String cnxString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\pc\Desktop\INFO2\S3\Langage C# et ASP .NET\Langage C#\NotePad\NotePad\Notes.mdf"";Integrated Security=True";
             using (SqlConnection con = new SqlConnection(cnxString))
              {
                 con.Open();
                 String sql = "UPDATE Notes SET DateModification=@d , Titre=@t , Note=@n WHERE Titre=@at ";
                 SqlCommand command = new SqlCommand(sql, con);
                 command.Parameters.AddWithValue("@d", DateTime.Now);
                 command.Parameters.AddWithValue("@t", TBtitre.Text);
                 command.Parameters.AddWithValue("@n", TBnote.Text);
                 command.Parameters.AddWithValue("@at", ancienNote);


                 command.ExecuteNonQuery();
                con.Close();
                 getNotes();

             }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (TitreNoteAModifier.Equals(""))
            {
                MessageBox.Show("You have to select Note that you want to edit");
            }else
            {
                ModifierN(DateTime.Now, TBtitre.Text, TBnote.Text, TitreNoteAModifier);
                TitreNoteAModifier = "";
                TBtitre.Text = "";
                TBnote.Text = "";
            }
        }

        private void Arreter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void red_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
