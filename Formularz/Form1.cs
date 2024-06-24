using System.Data.SqlClient;

namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-13HBPGP\SQLEXPRESS;Initial Catalog=Mati;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            string id = tbID.Text;
            string NazwaProgramu = tbNazwaProgramu.Text;

            string Query = "INSERT INTO licencje(id, NazwaProgramu) VALUES('" + id + "', '" + NazwaProgramu + "')";

            SqlCommand cmd = new SqlCommand(Query, cnn);
            cmd.ExecuteNonQuery();

            cnn.Close();

            MessageBox.Show("Dane zapisane");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}