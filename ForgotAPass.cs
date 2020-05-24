using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace NAUKA_CMS
{
    public partial class ForgotAPass : Form                                                     // Форма позволяющая отправить на электронный ящик письмо с "новыми" логином и паролем
    {
        SqlConnection sqlConnection;
        public ForgotAPass()
        {
            InitializeComponent();
        }

        private async void ForgotAPass_Load(object sender, EventArgs e)
        {
            string strConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anton\source\repos\NAUKA_CMS\Database.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(strConnect);
            await sqlConnection.OpenAsync();
        }                       // Установка соединения при загрузке формы.

        private async void Confirm_B_Click(object sender, EventArgs e)
        {

            string Login = "RandomLogin";                                                        // "Новые" логин и пароль. Они придут Вам в электронном письме.
            string Pass = "RandomPass";                                                          // Здесь можно сделать реализацию генерации случайных данных. 
            
            
            string StrMessage = "Hello!! \n Your Login: " + Login + '\n' + "You Password: " + Pass ;        // Формирование тела сообщения
            Send(Mail_T.Text, StrMessage);                                                                  // Отправка письма

            SqlCommand command = new SqlCommand("UPDATE [SuperUser] SET [tocken]=@tocken WHERE Id=1", sqlConnection);   // После отправки необходимо изменить токен в базе данных,
            command.Parameters.AddWithValue("tocken", md5.GetMD5(Login + Pass));                                        //  иначе письмо придет, а входные данные для входа останутся прежними.
            await command.ExecuteNonQueryAsync();

            this.DialogResult = DialogResult.OK;
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }
            this.Close();
        }

        void Send(string Email, string Message)                                                  // Функция отправки электронных сообщений путем использования SMTP-сервера 
        {                                                                                        //  и зарегистрированного ящика на Яндексе. Корректней было бы вынести её в отдельный класс.
            try
            {
                var fromAddress = new MailAddress("NaukaCMS@yandex.ru", "NAUKA_CMS");           // Данные ящика, с которого будет осуществляться отправка сообщений и Логин (от кого сообщение) 
                var toAddress = new MailAddress(Email, Email);                                  // Адрес получателя
                const string fromPassword = "Qasw12qasw12";                                     // Пароль для входа в ящик-отправитель
                const string subject = "Тестовое Сообщение";                                    // Тема письма
                string body = Message;                                                          // Тело письма


                var smtp = new SmtpClient                                                       // Конфигурирование SMTP-клиента
                {
                    Host = "smtp.yandex.ru",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);                                                             // Отправка сообщения
                }
            }
            catch
            {
                // Обработка исключения на случай пустого окна ввода E-mail
            }
        }

        private void ForgotAPass_FormClosing(object sender, FormClosingEventArgs e)                 // Закрытие соединения с БД при закрытии формы
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) { sqlConnection.Close(); }
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
