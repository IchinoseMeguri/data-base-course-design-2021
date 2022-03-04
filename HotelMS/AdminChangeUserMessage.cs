using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMS
{
    public partial class AdminChangeUserMessage:Form
    {
        string account;
        public AdminChangeUserMessage(string account)
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
            label1.Text="用户"+account+"的信息：";
            sqlConnection.Close();
        }

        private void Delete_Click(object sender,EventArgs e)
        {
            if(MessageBox.Show("即将注销账户"+account,"提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlconn);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    "delete from UserInfo where Userid='"+account+"';"
                    ,sqlConnection);
                if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("注销失败！","提示");
                else
                {
                    MessageBox.Show("注销成功！","提示");
                    sqlConnection.Close();
                    this.Close();
                }
            }
        }

        private void PswChange_Click(object sender,EventArgs e)
        {
            if(MessageBox.Show("即将重置账户"+account+"的密码","提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlconn);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    "update UserInfo set Userpsw='123456' where Userid='"+account+"';"
                    ,sqlConnection);
                if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("重置失败！","提示");
                else
                {
                    MessageBox.Show("重置成功！","提示");
                    sqlConnection.Close();
                }
            }
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

        private void Beadmin_Click(object sender,EventArgs e)
        {
            if(MessageBox.Show("即将设置账户"+account+"为管理员","提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlconn);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    "update UserInfo set Usertype='管理员' where Userid='"+account+"';"
                    ,sqlConnection);
                if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("设置失败！","提示");
                else
                {
                    MessageBox.Show("设置成功！","提示");
                    sqlConnection.Close();
                }
            }
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
