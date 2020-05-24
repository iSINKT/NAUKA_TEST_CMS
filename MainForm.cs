using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NAUKA_CMS
{

    // Главная форма системы управления контентом
    public partial class MainForm : Form                                                                     
    {
        SqlConnection sqlConnection;
        public MainForm()
        {
            InitializeComponent();
        }



        // Вызов окна регистрации при "File - New Person"
        private void newPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new NewPers().ShowDialog() == DialogResult.OK)
                if (TDep_CB.Text != "")
                    Refresh();

        }                          




        //Закрытие программы через "File - Exit"
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }                               

        private async void MainForm_Load(object sender, EventArgs e)
        {

            if (new LogForm().ShowDialog() != DialogResult.OK)                                                  //Проверка на корректную авторизацию
            {
                this.Close();
            }
            else
            {
                try
                {
                    string strConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\Database.mdf;Integrated Security=True";
                    using (sqlConnection = new SqlConnection(strConnect))
                    {
                        await sqlConnection.OpenAsync();                                                                // Указание расположения БД, установка соединения
                        SqlDataReader sqlReader = null;
                        using (SqlCommand command = new SqlCommand("SELECT * FROM [TheDep]", sqlConnection))
                        {                   //  Формирование запроса к БД. "TheDep = The Departament - отдел, 
                                            //  но вскоре Отдел начал исполнять роль Фракции.

                            using (sqlReader = await command.ExecuteReaderAsync())
                            {
                                while (await sqlReader.ReadAsync())
                                {                                                                                            // Обработка результата запроса - Наполнение КомбоБоксов фракциями из таблицы TheDep
                                    TDep_CB.Items.Add(Convert.ToString(sqlReader["The Departament"]));
                                    Dep_CB.Items.Add(Convert.ToString(sqlReader["The Departament"]));
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);       //Обработка исключений
                }
                
            }
        }





        // Событие при выборе/изменении Итема в Комбобоксе фракции, в следствии чего, 
        //происходит моментальное обновление списка людей, принадлежащих выбранной фракции
        private void TDep_CM_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
        }                                                                                                     
                                                                                                              
        
            
            
        // Нажатие на кнопку Edit, разрешающая редактирование информационной карточки персонажа
        private void Edit_B_Click(object sender, EventArgs e)
        { 
            Panel.Enabled = true;
            Edit_B.Enabled = false;
            Save_Bt.Enabled = true;
        }


        // Событие выбора персонажа из списка, показывающее информационную карточку.
        private async void ListOfPerson_SelectedIndexChanged(object sender, EventArgs e)           
        {
            if (ListOfPerson.SelectedIndex != -1)
            {
                string Id = "";               
                for (int i = 0; ListOfPerson.Text[i] != '\t'; i++)                                          //Нахождение айди для наполнения карточки информацией из БД
                        Id += ListOfPerson.Text[i];
                try
                {

                    string strConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\Database.mdf;Integrated Security=True";
                    using (sqlConnection = new SqlConnection(strConnect))
                    {
                        await sqlConnection.OpenAsync();
                        CardOfPerson.Visible = true;
                        SqlDataReader sqlReader = null;
                        using (SqlCommand command = new SqlCommand("SELECT * FROM [" + TDep_CB.Text + "] WHERE  Id=" + Id, sqlConnection))
                        {

                            using (sqlReader = await command.ExecuteReaderAsync())
                            {
                                while (await sqlReader.ReadAsync())
                                {
                                    FName_T.Text = Convert.ToString(sqlReader["FirstName"]);
                                    LName_T.Text = Convert.ToString(sqlReader["LastName"]);
                                    Patr_T.Text = Convert.ToString(sqlReader["Patronymic"]);
                                    Data.Value = Convert.ToDateTime(sqlReader["DateofBirth"]);
                                    Addr_T.Text = Convert.ToString(sqlReader["Addres"]);
                                    Dep_CB.Text = TDep_CB.Text;
                                    Email_T.Text = Convert.ToString(sqlReader["Email"]);
                                    AbM_T.Text = Convert.ToString(sqlReader["AboutMyself"]);
                                }

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }



        // Так как персонажи классифицированы по фракциям, то редактирование карточки было
        //    решено выполнить в виде "Вставить-Удалить", что решило вопрос с переходом персонажа
        //    в другую фракци, но повлекло за собой проблему изменения айди в рамках одной фракции при
        //    редактировании какой-либо другой информации. Это проблема логики, т.к персонаж-то один и тот же.
        private async void Save_Bt_Click(object sender, EventArgs e)
        {
            string Id = "";
            for (int i = 0; ListOfPerson.Text[i] != '\t'; i++)
                Id += ListOfPerson.Text[i];

            string strConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\Database.mdf;Integrated Security=True";
            using (sqlConnection = new SqlConnection(strConnect))
            {
                await sqlConnection.OpenAsync();
                using (SqlCommand command = new SqlCommand("INSERT INTO [" + Dep_CB.Text + "] (FirstName, LastName, Patronymic, DateofBirth, Addres, Email, AboutMyself)" +
                                                "VALUES (@FirstName, @LastName, @Patronymic, @DateofBirth, @Addres, @Email, @AboutMyself)", sqlConnection))
                {
                    command.Parameters.AddWithValue("FirstName", FName_T.Text);
                    command.Parameters.AddWithValue("LastName", LName_T.Text);
                    command.Parameters.AddWithValue("Patronymic", Patr_T.Text);
                    command.Parameters.AddWithValue("DateofBirth", Data.Value);
                    command.Parameters.AddWithValue("Addres", Addr_T.Text);
                    command.Parameters.AddWithValue("Email", Email_T.Text);
                    command.Parameters.AddWithValue("AboutMyself", AbM_T.Text);


                    await command.ExecuteNonQueryAsync();
                }


                using (SqlCommand command = new SqlCommand("DELETE FROM [" + TDep_CB.Text + "] WHERE  Id=" + Id, sqlConnection))
                {
                    await command.ExecuteNonQueryAsync();
                }
            }
            Panel.Enabled = false;
            Save_Bt.Enabled = false;
            Edit_B.Enabled = true;

            Refresh();
        }



        // Событие выхода из учетной записи и вызов окна авторизации
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (new LogForm().ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                CardOfPerson.Visible = false;
                ListOfPerson.Items.Clear();
                Dep_CB.SelectedIndex = 0;
                this.Show();
            }
        }


        // Событие кнопки DELETE
        private async void Del_B_Click(object sender, EventArgs e)
        {
            string Id = "";
            for (int i = 0; ListOfPerson.Text[i] != '\t'; i++)
                Id += ListOfPerson.Text[i];

            string strConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\Database.mdf;Integrated Security=True";
            using (sqlConnection = new SqlConnection(strConnect))
            {
                await sqlConnection.OpenAsync();
                using (SqlCommand command = new SqlCommand("DELETE FROM [" + TDep_CB.Text + "] WHERE  Id=" + Id, sqlConnection))
                {
                    await command.ExecuteNonQueryAsync();
                }
            }
            Refresh( );
            
        }


        // Из-за частого использования была вынесена функция Обновления списка персонажей
        async void Refresh() 
        {
            ListOfPerson.Items.Clear();
            try
            {
                string strConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\Database.mdf;Integrated Security=True";
                using (sqlConnection = new SqlConnection(strConnect))
                {
                    await sqlConnection.OpenAsync();
                    SqlDataReader sqlReader = null;
                    using (SqlCommand command = new SqlCommand("SELECT * FROM [" + TDep_CB.Text.ToString() + "]", sqlConnection))
                    {

                        using (sqlReader = await command.ExecuteReaderAsync())
                        {
                            while (await sqlReader.ReadAsync())
                            {
                                ListOfPerson.Items.Add(Convert.ToString(sqlReader["id"]) + '\t' + Convert.ToString(sqlReader["FirstName"]) + ' ' + Convert.ToString(sqlReader["LastName"]) + ' ' + Convert.ToString(sqlReader["Patronymic"]));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            CardOfPerson.Visible = false;
        }


        // Событие "Option - Admin", позволяющее изменить логин и пароль для входа в 
        //   учетную запись. Админ-пользователь !один!
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new SuperUserSettings().ShowDialog() == DialogResult.OK)
                if(!string.IsNullOrEmpty(TDep_CB.Text))
                Refresh();
        }



        // Событие нажатие кнопки To Connect, позволяющей связаться с персонажем путем отправки 
        //   письма на указанную в карточке электронную почту.
        private void Tcon_B_Click(object sender, EventArgs e)
        {
            if (new MessageMail(Email_T.Text).ShowDialog() == DialogResult.OK)
                Refresh();
        }                                                                                                      
    }
}
