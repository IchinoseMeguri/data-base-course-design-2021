using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMS
{
    public partial class ForgetPassword:Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
            AccountText.Focus();
        }

        private void OK_Click(object sender,EventArgs e)
        {
            string account = AccountText.Text;
            string name = NameText.Text;
            string id = IdText.Text;
            string tell = TellText.Text;
            if(account==""||name==""||id==""||tell=="")
                MessageBox.Show("信息不完整！");
            else
            {
                string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlconn);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    "select * from UserInfo where Userid='"+account+"'"
                    ,sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if(!sqlDataReader.Read()) MessageBox.Show("用户名未被注册！");
                else
                {
                    sqlDataReader.Close();
                    sqlCommand=new SqlCommand(
                    "select * from UserInfo where Userid='"+account+"'and Username='"+name+"'and Useridcard='"+id+"'and Usertell='"+tell+"';"
                    ,sqlConnection);
                    sqlDataReader=sqlCommand.ExecuteReader();
                    if(!sqlDataReader.Read()) MessageBox.Show("信息错误！","提示");
                    else
                    {
                        sqlDataReader.Close();
                        sqlCommand=new SqlCommand(
                        "update UserInfo set Userpsw='123456' where Userid='"+account+"';"
                        ,sqlConnection);
                        if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("密码重置失败！","提示");
                        else
                        {
                            MessageBox.Show("密码成功重置为123456！","提示");
                            sqlConnection.Close();
                        }
                    }
                }
            }
        }

        private void Exit_Click(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}
