using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMS
{
    public partial class UserPasswordChange:Form
    {
        string account;
        public UserPasswordChange(string account)
        {
            InitializeComponent();
            this.account=account;
            pswf.Focus();
        }

        private void OK_Click(object sender,EventArgs e)
        {
            string psw = pswf.Text;
            string psw1 = pswn.Text;
            string psw2 = pswn2.Text;
            string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(sqlconn);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(
                "select * from UserInfo where Userid='"+account+"' and Userpsw='"+psw+"'"
                ,sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if(!sqlDataReader.Read()) MessageBox.Show("密码错误！","提示");
            else
            {
                sqlDataReader.Close();
                if(psw1=="") MessageBox.Show("密码不允许为空！","提示");
                else
                {
                    if(psw1!=psw2) MessageBox.Show("密码与确认密码不一致！","提示");
                    else
                    {
                        sqlCommand=new SqlCommand(
                            "update UserInfo set Userpsw='"+psw1+"' where Userid='"+account+"';"
                            ,sqlConnection);
                        if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("修改失败！","提示");
                        else
                        {
                            MessageBox.Show("修改成功！","提示");
                            sqlConnection.Close();
                            this.Close();
                        }
                    }
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
                OK.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg,keyData);
        }
    }
}
