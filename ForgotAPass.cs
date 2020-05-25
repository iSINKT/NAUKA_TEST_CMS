using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace NAUKA_CMS
{

    // Форма позволяющая отправить на электронный ящик письмо с "новыми" логином и паролем
    public partial class ForgotAPass : Form                                                     
    {

        const string Password = "Qasw12qasw12";
        const string UserID = "isinkt123_nauka";
        const string host = "isinkt123.beget.tech";
        const string database = "isinkt123_nauka";
        string connectionString = $"Server={host};Database={database};port=3306;User Id={UserID};password={Password}";
        MySqlConnection MysqlConnection;
        public ForgotAPass()
        {
            InitializeComponent();
        }

                             

        private async void Confirm_B_Click(object sender, EventArgs e)
        {
            using (MysqlConnection = new MySqlConnection(connectionString))
            {

                await MysqlConnection.OpenAsync();


                // "Новые" логин и пароль. Они придут Вам в электронном письме.
                // Здесь можно сделать реализацию генерации случайных данных. 
                string Login = "RandomLogin";                                                       
                string Pass = "RandomPass";                                                         
                
                
                // Отправка письма
                if (!string.IsNullOrEmpty(Mail_T.Text))
                {
                    // Формирование тела сообщения
                    string StrMessage = "Hello!! \n Your Login: " + Login + '\n' + "You Password: " + Pass;        
                    Send(Mail_T.Text, StrMessage);
                }
                // После отправки необходимо изменить токен в базе данных,  
                //  иначе письмо придет, а входные данные для входа останутся прежними.                
                using (var command = new MySqlCommand("UPDATE SuperUser SET tocken=@tocken WHERE Id=1", MysqlConnection))          
                {                                                                                                                         
                    command.Parameters.AddWithValue("tocken", md5.GetMD5(Login + Pass));
                    await command.ExecuteNonQueryAsync();
                }
            }
            this.DialogResult = DialogResult.OK;
           
            this.Close();
        }


        // Функция отправки электронных сообщений путем использования SMTP-сервера 
        //  и зарегистрированного ящика на Яндексе. Корректней было бы вынести её в отдельный класс.
        void Send(string Email, string Message)
        {

            // Данные ящика, с которого будет осуществляться отправка сообщений и Логин (от кого сообщение) 
            var fromAddress = new MailAddress("NaukaCMS@yandex.ru", "NAUKA_CMS");
            // Адрес получателя
            var toAddress = new MailAddress(Email, Email);
            // Пароль для входа в ящик-отправитель
            const string fromPassword = "Qasw12qasw12";
            // Тема письма
            const string subject = "Тестовое Сообщение";
            // Тело письма
            string body = Message;

            // Конфигурирование SMTP-клиента
            var smtp = new SmtpClient                                                       
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
                // Отправка сообщения
                smtp.Send(message);                                                            
            }

        }

        private void ForgotAPass_FormClosing(object sender, FormClosingEventArgs e)                 
        {            
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
