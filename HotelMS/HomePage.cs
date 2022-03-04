using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelMS
{
    public partial class HomePage:Form
    {
        public HomePage()
        {
            InitializeComponent();
            AccountText.Focus();
        }

        private void Homepage_Load(object sender,EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Login_Click(object sender,EventArgs e)
        {
            string account = AccountText.Text;
            string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
            SqlConnection sqlConnection=new SqlConnection(sqlconn);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(
                "select * from UserInfo where Userid='"+AccountText.Text+"' and Userpsw='"+PasswordText.Text+"'"
                ,sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if(!sqlDataReader.Read()) MessageBox.Show("用户名或密码错误！","提示");
            else
            {
                sqlDataReader.Close();
                sqlCommand=new SqlCommand(
                "select Usertype from UserInfo where Userid='"+AccountText.Text+"'"
                ,sqlConnection);
                if(sqlCommand.ExecuteScalar().ToString()=="管理员")
                {
                    AdminPage adminPage = new AdminPage(account);
                    adminPage.Show();
                }
                else
                {
                    UserPage userPage = new UserPage(account);
                    userPage.Show();
                }
                sqlConnection.Close();
                AccountText.Text="";
                PasswordText.Text="";
            }
        }

        private void timer1_Tick(object sender,EventArgs e)
        {
            lbltime.Text=DateTime.Now.ToString();
        }

        private void lbltime_Load(object sender,EventArgs e)
        {
            lbltime.Text=DateTime.Now.ToString();
        }

        private void Register_Click(object sender,EventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
        }

        private void Exit_Click(object sender,EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg,Keys keyData)
        {
            if(keyData==Keys.Enter)
            {
                Login.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg,keyData);
        }

        private void Forgetpsw_Click(object sender,EventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }
    }
}
