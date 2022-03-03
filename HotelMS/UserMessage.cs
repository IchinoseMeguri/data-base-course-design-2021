using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelMS
{
    public partial class UserMessage:Form
    {
        string account;
        public UserMessage(String account)
        {
            InitializeComponent();
            this.account=account;
            string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(sqlconn);
            sqlConnection.Open();
            NameText.Text=new SqlCommand(
                "select Username from UserInfo where Userid='"+account+"';"
                ,sqlConnection).ExecuteScalar().ToString();
            IdText.Text=new SqlCommand(
                "select Useridcard from UserInfo where Userid='"+account+"';"
                ,sqlConnection).ExecuteScalar().ToString();
            TellText.Text=new SqlCommand(
                "select Usertell from UserInfo where Userid='"+account+"';"
                ,sqlConnection).ExecuteScalar().ToString();
            string title= new SqlCommand(
                "select Usertype from UserInfo where Userid='"+account+"';"
                ,sqlConnection).ExecuteScalar().ToString();
            label1.Text="亲爱的"+title+account+"，您好。";
            sqlConnection.Close();
        }

        private void PswChange_Click(object sender,EventArgs e)
        {
            UserPasswordChange userPasswordChange = new UserPasswordChange(account);
            userPasswordChange.Show();
        }

        private void Save_Click(object sender,EventArgs e)
        {
            if(NameText.Text==""||IdText.Text==""||TellText.Text=="") MessageBox.Show("输入信息不完整！","提示");
            else
            {
                string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlconn);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    "update UserInfo set Username='"+NameText.Text+"',Useridcard='"+IdText.Text+"',Usertell='"+TellText.Text+"' where Userid='"+account+"';"
                    ,sqlConnection);
                if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("修改失败！","提示");
                else
                {
                    MessageBox.Show("修改成功！","提示");
                    sqlConnection.Close();
                }
            }
        }

        private void Exit_Click(object sender,EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg,Keys keyData)
        {
            if(keyData==Keys.Enter)
            {
                Save.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg,keyData);
        }
    }
}
