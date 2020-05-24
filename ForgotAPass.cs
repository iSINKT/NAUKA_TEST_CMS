using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace NAUKA_CMS
{

    // Форма позволяющая отправить на электронный ящик письмо с "новыми" логином и паролем
    public partial class ForgotAPass : Form                                                     
    {
        SqlConnection sqlConnection;
        public ForgotAPass()
        {
            InitializeComponent();
        }

                             

        private async void Confirm_B_Click(object sender, EventArgs e)
        {
            string strConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\Database.mdf;Integrated Security=True";
            using (sqlConnection = new SqlConnection(strConnect))
            {

                await sqlConnection.OpenAsync();


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
                using (SqlCommand command = new SqlCommand("UPDATE [SuperUser] SET [tocken]=@tocken WHERE Id=1", sqlConnection))          
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
