
using System.IO;
using System.Data.SQLite;
namespace Week10_3
{
    public partial class Form1 : Form
    {

        public string dbName = "users.db";
        public Form1()
        {
            InitializeComponent();
        }

        public void manageDatabase()
        {
            if (!File.Exists(dbName))
            {
                //Create a db
                SQLiteConnection.CreateFile(dbName);
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    connection.Open();

                    SQLiteCommand cmd = new SQLiteCommand(connection);
                    cmd.CommandText = "CREATE TABLE users(id INTEGER NOT NULL UNIQUE, email TEXT NOT NULL UNIQUE, password TEXT NOT NULL, name TEXT NOT NULL, address TEXT, age INTEGER, PRIMARY KEY(id AUTOINCREMENT));";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE user_books(id INTEGER NOT NULL UNIQUE, user_id INTEGER NOT NULL, book_name TEXT NOT NULL, author TEXT NOT NULL, page_count INTEGER NOT NULL, PRIMARY KEY(id AUTOINCREMENT), FOREIGN KEY(user_id) REFERENCES users(id))";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manageDatabase();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(connection);
                    command.CommandText = "INSERT INTO users(email,password,name,address,age) VALUES(@email,@password,@name,@address,@age)";
                    command.Parameters.AddWithValue("@email", txtEmailRegister.Text);
                    command.Parameters.AddWithValue("@password", txtPasswordRegister.Text);
                    command.Parameters.AddWithValue("@name", txtName.Text);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                    command.ExecuteNonQuery();
                    tabControl1.SelectedIndex = 0;
                    MessageBox.Show("You are registered successfully");
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void handleLogout()
        {
            this.Visible = true;
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                using(SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(connection);
                    cmd.CommandText = "SELECT * FROM users where email=@email AND password=@password";
                    cmd.Parameters.AddWithValue("@email",txtEmailSignIn.Text);
                    cmd.Parameters.AddWithValue("@password",txtPasswordSignIn.Text);
                    SQLiteDataReader dataReader = cmd.ExecuteReader();

                    if (!dataReader.HasRows)
                    {
                        dataReader.Close();
                        connection.Close();
                        MessageBox.Show("Your credentials are not correct!!");
                        return;
                    }

                    dataReader.Read();
                    /*
                    string email = dataReader.GetValue(1).ToString();
                    string email2 = dataReader.GetString(1);
                    string email3 = dataReader[1].ToString();
                    string email4 = dataReader["email"].ToString();
                    */
                    int id = int.Parse(dataReader["id"].ToString());
                    int age = int.Parse(dataReader["age"].ToString());
                    string email = dataReader["email"].ToString();
                    string password = dataReader["password"].ToString();
                    string name = dataReader["name"].ToString();
                    string address = dataReader["address"].ToString();

                    User loggedInUser = new User(id,email,password,name,address,age);
                    this.Visible = false;
                    //txtPasswordSignIn.Text = "";
                    //txtEmailSignIn.Text = "";
                    dataReader.Close();
                    connection.Close();

                    Form2 frm2 = new Form2();
                    frm2.user = loggedInUser;
                    frm2.LogoutEvent += handleLogout;
                    frm2.ShowDialog();

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}