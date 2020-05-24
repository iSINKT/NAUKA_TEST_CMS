using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NAUKA_CMS
{
    public partial class NewPers : Form                                                   //Форма для регистрации нового персонажа.
    {
        SqlConnection sqlConnection;
        public NewPers()
        {
            InitializeComponent();
        }

        private async void Send_B_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [" + Dep_CB.Text + "] (FirstName, LastName, Patronymic, DateofBirth, Addres, Email, AboutMyself)" +            //Формарование запроса на вставку записи в таблицу
                                                "VALUES (@FirstName, @LastName, @Patronymic, @DateofBirth, @Addres, @Email, @AboutMyself)", sqlConnection);

            command.Parameters.AddWithValue("FirstName", FName_T.Text);
            command.Parameters.AddWithValue("LastName", LName_T.Text);
            command.Parameters.AddWithValue("Patronymic", Patr_T.Text);
            command.Parameters.AddWithValue("DateofBirth", Date.Value);
            command.Parameters.AddWithValue("Addres", Addr_T.Text);
            command.Parameters.AddWithValue("Email", Email_T.Text);
            command.Parameters.AddWithValue("AboutMyself", AbM_T.Text);

            try
            {
                await command.ExecuteNonQueryAsync();
            }
            catch
            {

            }
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }                     // Событие нажатия кнопки To registrate

        private async void NewPers_Load(object sender, EventArgs e)
        {
            string strConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\Database.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(strConnect);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [TheDep]", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    Dep_CB.Items.Add(Convert.ToString(sqlReader["The Departament"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null) sqlReader.Close();
            }
            Dep_CB.SelectedItem = "Одиночки";
        }                     // Установка соединения с загрузкой формы для считывания и предварительного выделения фракции

        private void NewPers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }

        }         // Событие закрывания окна, при котором производится проверка и закрытие соединения
    }
}
