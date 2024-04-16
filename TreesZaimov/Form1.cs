using MySqlConnector;

namespace TreesZaimov
{
    public partial class Form1 : Form
    {
        string connstr = "server=10.6.0.127;" +
            "port=3306;" +
            "user=PC1;" +
            "password=1111;" +
            "database=trees_zaimov";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MessageBox.Show("Conection now open!");

            string insertSql = "INSERT INTO trees_zaimov.razred (`name`, `name_bg`) VALUES (@name,@name_bg)";
            //2step
            MySqlCommand query = new MySqlCommand(insertSql, connect);

            query.Parameters.AddWithValue("@name", txtName.Text);
            query.Parameters.AddWithValue("@name_bg", txtNameBG.Text);

          
            query.ExecuteNonQuery();
            MessageBox.Show("Dobavih v tablica razred");
            connect.Close();

        }
    }
}
