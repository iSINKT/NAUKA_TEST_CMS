using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace NAUKA_CMS
{

    //Окно написания сообщения для отправки письма персонажу
    public partial class MessageMail : Form                                             
    {
        public MessageMail()
        {
            InitializeComponent();
        }

        public MessageMail(string email)
        {
            InitializeComponent();
            Mail_T.Text = email;
        }                                             

        // Отправка сообщения после нажатия кнопки Send
        private void button1_Click(object sender, EventArgs e)                         
        {
            Send(Mail_T.Text, Message_T.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        // Функция полностью описана в коде формы ForgotAPass.cs
        void Send(string Email, string Message)
        {
            var fromAddress = new MailAddress("NaukaCMS@yandex.ru", "NAUKA_CMS");
            var toAddress = new MailAddress(Email, Email);
            const string fromPassword = "Qasw12qasw12";
            const string subject = "Тестовое Сообщение";
            string body = Message;

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
                smtp.Send(message);
            }

        }                                     
    }
}
