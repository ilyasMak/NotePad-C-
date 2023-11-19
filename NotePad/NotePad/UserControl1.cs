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
using static NotePad.Form1;

namespace NotePad
{
    public partial class UserControl1 : UserControl
    {

        private DateTime dateModification;
        private string titre;
        private string note;
        private Button edit;
        private Button delete; 

        public DateTime DateModification { get { return dateModification;  } set { dateModification = value; Labeldate.Text = value.ToShortDateString(); } }

        public string Titre { get { return titre; } set { titre = value; labelTitre.Text = value; } }
        public string Note { get { return note; } set { note = value; labelNote.Text = value; } }

      

        
        public UserControl1()
        {
          
            InitializeComponent();

        }
        public UserControl1(DateTime d , string t,string n)
        {
            this.dateModification = d;
            this.titre = t;
            this.note = n;
            InitializeComponent();
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        public delegate void EditEventHandler(DateTime d, string titre);

        // Déclarer l'événement avec le délégué
        public event EditEventHandler EditButtonClick;


        protected virtual void OnEditButtonClick(DateTime d , string titre)
        {
            // Vérifier si des gestionnaires sont inscrits à l'événement
            EditButtonClick?.Invoke(d,titre);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OnEditButtonClick(DateTime.Parse(Labeldate.Text),labelTitre.Text);




        }

        private void del_Click(object sender, EventArgs e)
        {
            String cnxString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\pc\Desktop\INFO2\S3\Langage C# et ASP .NET\Langage C#\NotePad\NotePad\Notes.mdf"";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(cnxString))
            {
                con.Open();
                String sql = "DELETE FROM Notes WHERE Titre = @t";
                SqlCommand command = new SqlCommand(sql, con);

                command.Parameters.AddWithValue("@t", labelTitre.Text);

                command.ExecuteNonQuery();
                con.Close();
                OnSuppressionNote();


            }
        }
        public event EventHandler SuppressionNote;
        protected virtual void OnSuppressionNote()
        {
            // Vérifiez si des gestionnaires sont inscrits à l'événement
            SuppressionNote?.Invoke(this, EventArgs.Empty);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
