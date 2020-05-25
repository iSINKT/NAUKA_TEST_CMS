using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace NAUKA_CMS
{
    // Окно позволяющее изменить данные для входа в учетную запись
    // Админ-пользователь один.
    public partial class SuperUserSettings : Form                                                           
    {
        const string Password = "Qasw12qasw12";
        const string UserID = "isinkt123_nauka";
        const string host = "isinkt123.beget.tech";
        const string database = "isinkt123_nauka";
        string connectionString = $"Server={host};Database={database};port=3306;User Id={UserID};password={Password}";
        MySqlConnection MysqlConnection;
        public SuperUserSettings()
        {
            InitializeComponent();
        }



        // Событие нажатия кнопки Discard, которая закрывает соединение и форму
        //   без сохранения данных
        private void Discard_B_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }                                        
                                                 

        //Формирование запроса на обновление токена новых введенных данных в таблице 
        // SuperUser.
        private async void Ok_B_Click(object sender, EventArgs e)
        {
            using (MysqlConnection = new MySqlConnection(connectionString))
            {
                await MysqlConnection.OpenAsync();
                using (var command = new MySqlCommand("UPDATE SuperUser SET tocken=@tocken WHERE Id=1", MysqlConnection))
                {
                    command.Parameters.AddWithValue("tocken", md5.GetMD5(Log_T.Text + Pass_T.Text));
                    await command.ExecuteNonQueryAsync();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }                                                                                                  
                                                                                                           
    }
}
