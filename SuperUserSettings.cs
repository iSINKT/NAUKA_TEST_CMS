using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NAUKA_CMS
{
    // Окно позволяющее изменить данные для входа в учетную запись
    // Админ-пользователь один.
    public partial class SuperUserSettings : Form                                                           
    {                                                                                                       
        SqlConnection sqlConnection;
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
            string strConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\Database.mdf;Integrated Security=True";

            using (sqlConnection = new SqlConnection(strConnect))
            {
                await sqlConnection.OpenAsync();
                using (SqlCommand command = new SqlCommand("UPDATE [SuperUser] SET [tocken]=@tocken WHERE Id=1", sqlConnection))
                {
                    command.Parameters.AddWithValue("tocken", md5.GetMD5(Log_T.Text + Pass_T.Text));
                    await command.ExecuteNonQueryAsync();
                }
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }                                                                                                  
                                                                                                           
    }
}
