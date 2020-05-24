using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NAUKA_CMS
{
    public partial class SuperUserSettings : Form                                                           // Окно позволяющее изменить данные для входа в учетную запись
    {                                                                                                       // Админ-пользователь один.
        SqlConnection sqlConnection;
        public SuperUserSettings()
        {
            InitializeComponent();
        }

        private async void SuperUserSettings_Load(object sender, EventArgs e)
        {
            string strConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anton\source\repos\NAUKA_CMS\Database.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(strConnect);
            await sqlConnection.OpenAsync();


        }                            // Установка соединения с БД при загрузке формы

        private void SuperUserSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }
        }               // Событие закрытия окна с закрытием соединения.

        private void Discard_B_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }                                        // Событие нажатия кнопки Discard, которая закрывает соединение и форму
                                                                                                           //   без сохранения данных

        private async void Ok_B_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE [SuperUser] SET [tocken]=@tocken WHERE Id=1", sqlConnection);
            command.Parameters.AddWithValue("tocken", md5.GetMD5( Log_T.Text + Pass_T.Text));
            await command.ExecuteNonQueryAsync();
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }                                       //Формирование запроса на обновление токена новых введенных данных в таблице 
                                                                                                           // SuperUser.
    }
}
