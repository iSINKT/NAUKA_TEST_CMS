using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace NAUKA_CMS
{

    // Форма входа в учетную запись Админа-пользователя. 
    // Авторизация выполненa с использованием алгоритма хеширования MD5
    // в целях безопасности. Таким образом БД не хранит логин и пароль напрямую,
    // а лишь Хэш-код их суммы. Именно с этим Хешем произвидится сравнение введенных
    // данных после нажатия кнопки Входа. 
    // Суть в том, что взломав БД, прямых данных для входа там не будет.
    public partial class LogForm : Form
    
    {
        const string Password = "Qasw12qasw12";
        const string UserID = "isinkt123_nauka";
        const string host = "isinkt123.beget.tech";
        const string database = "isinkt123_nauka";
        string connectionString = $"Server={host};Database={database};port=3306;User Id={UserID};password={Password}";
        MySqlConnection MysqlConnection;
        string Hash;
        public LogForm()
        {
            InitializeComponent();
        }

      
        // Событие нажатия на кнопку входа
        private async void B_Sing_in_Click(object sender, EventArgs e)                                  
        {
            // Установка соединения, формирование запроса, присвоение Hash = токен
            // Установка соединения по кнопке сделана для корректного обновления данных.
            // В случае установки соединения при загрузке формы, не проходит тест-кейс:
            //  -Открыть окно авторизации, восстановить данные, зайти по новым данным. 
            // Тест провалится по причине устаревшей информации у формы. В таком случае
            // вход будет возможен только по старым данным, а по новым данным можно
            // будет зайти только в новой сессии.
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            try
            {
                using (MysqlConnection = new MySqlConnection(connectionString))
                {                   
                    MysqlConnection.Open();
                    using (var command = new MySqlCommand("SELECT * FROM SuperUser", MysqlConnection))
                    {
                        using (var  sqlReader = await command.ExecuteReaderAsync())
                        {
                            while (await sqlReader.ReadAsync())
                            {
                                Hash = Convert.ToString(sqlReader["tocken"]);
                            }
                        }
                    }                                                                                              
                }                                   
            }
            catch (Exception ex)                                                                        
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Сумма Логина и Пароля преобразуется в хеш, результаты сравниваются.
            if (md5.GetMD5(Login.Text + Pass.Text) == Hash)                                            
            {
                // В случае успеха, положительный результат диалога обрабатывается дольше
                this.DialogResult = DialogResult.OK;                                                   
                this.Close();
            }
            else
            {
                // Иначе показать окно с ошибкой
                MessageBox.Show("Wrong Login or Pass", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);          
            }
           
        }


        // Событие нажатия на ссылку, что вызывает окно восстановления данных
        // А фактически, приведение к данным по умолчанию.
        private async void Forgot_LL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ForgotAPass().ShowDialog();
        }                                                                                                          
                                                                                                                   
                                           
    }
}
