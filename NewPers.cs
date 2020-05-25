using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace NAUKA_CMS
{

    //Форма для регистрации нового персонажа.
    public partial class NewPers : Form                                                  
    {
        const string Password = "Qasw12qasw12";
        const string UserID = "isinkt123_nauka";
        const string host = "isinkt123.beget.tech";
        const string database = "isinkt123_nauka";
        string connectionString = $"Server={host};Database={database};port=3306;User Id={UserID};password={Password}";
        MySqlConnection MysqlConnection;
        public NewPers()
        {
            InitializeComponent();
        }


        // Событие нажатия кнопки To registrate
        private async void Send_B_Click(object sender, EventArgs e)
        {
            try
            {
                using (MysqlConnection = new MySqlConnection(connectionString))
                {
                    await MysqlConnection.OpenAsync();
                    using (var command = new MySqlCommand($"INSERT INTO {Dep_CB.Text} (FirstName, LastName, Patronymic, DateofBirth, Addres, Email, AboutMyself)" +            //Формарование запроса на вставку записи в таблицу
                                                    "VALUES (@FirstName, @LastName, @Patronymic, @DateofBirth, @Addres, @Email, @AboutMyself)", MysqlConnection))
                    {
                        command.Parameters.AddWithValue("FirstName", FName_T.Text);
                        command.Parameters.AddWithValue("LastName", LName_T.Text);
                        command.Parameters.AddWithValue("Patronymic", Patr_T.Text);
                        command.Parameters.AddWithValue("DateofBirth", Date.Value);
                        command.Parameters.AddWithValue("Addres", Addr_T.Text);
                        command.Parameters.AddWithValue("Email", Email_T.Text);
                        command.Parameters.AddWithValue("AboutMyself", AbM_T.Text);

                        await command.ExecuteNonQueryAsync();

                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }                     


        // Установка соединения с загрузкой формы для считывания и предварительного выделения фракции
        private async void NewPers_Load(object sender, EventArgs e)
        {
            try
            {
                using (MysqlConnection = new MySqlConnection(connectionString))
                {
                    await MysqlConnection.OpenAsync();
                    using (var command = new MySqlCommand("SELECT * FROM TheDep", MysqlConnection))
                    {
                        using (var sqlReader = await command.ExecuteReaderAsync())
                        {
                            while (await sqlReader.ReadAsync())
                            {
                                Dep_CB.Items.Add(Convert.ToString(sqlReader["The Departament"]));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            Dep_CB.SelectedItem = "Одиночки";
        }                    

       
    }
}
