using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NAUKA_CMS
{
    public partial class LogForm : Form                                                                 // Форма входа в учетную запись Админа-пользователя. 
                                                                                                        // Логирование выполнено с использованием алгоритма хеширования MD5
                                                                                                        // в целях безопасности. Таким образом БД не хранит логин и пароль напрямую,
                                                                                                        // а лишь Хэш-код их суммы. Именно с этим Хешем произвидится сравнение введенных
                                                                                                        // данных после нажатия кнопки Входа. 
                                                                                                        // Суть в том, что взломав БД, прямых данных для входа там не будет.
    {
        SqlConnection sqlConnection;
        string Hash;
        public LogForm()
        {
            InitializeComponent();
        }

      

        private async void B_Sing_in_Click(object sender, EventArgs e)                                  // Событие нажатия на кнопку входа
        {
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string strConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\Database.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(strConnect);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [SuperUser]", sqlConnection);
            try
            {                                                                               
                sqlReader = await command.ExecuteReaderAsync();                                         // Установка соединения, формирование запроса, присвоение Hash = токен
                while (await sqlReader.ReadAsync())                                                     // Установка соединения по кнопке сделана для корректного обновления данных.
                {                                                                                       // В случае установки соединения при загрузке формы, не проходит тест-кейс:
                    Hash = Convert.ToString(sqlReader["tocken"]);                                       //  -Открыть окно логирования, восстановить данные, зайти по новым данным. 
                }                                                                                       // Тест провалится по причине устаревшей информации у формы. В таком случае
            }                                                                                           // вход будет возможен только по старым данным, а по новым данным можно
            catch (Exception ex)                                                                        // будет зайти только в новой сессии.
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null) sqlReader.Close();
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            

            if (md5.GetMD5(Login.Text + Pass.Text) == Hash)                                             // Сумма Логина и Пароля преобразуется в хеш, результаты сравниваются.
            {
                this.DialogResult = DialogResult.OK;                                                    // В случае успеха, положительный результат диалога обрабатывается дольше
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Login or Pass", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);          // Иначе показать окно с ошибкой
            }
           
        }

        private async void Forgot_LL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ForgotAPass().ShowDialog();
        }                   // Событие нажатия на ссылку, что вызывает окно восстановления данных
                                                                                                                      // А фактически, приведение к данным по умолчанию.
        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)                                         // Событие закрытия окна с закрытием соединения.
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }
        }                                    
    }
}
