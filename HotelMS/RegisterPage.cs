using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelMS
{
    public partial class RegisterPage:Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterPage_Load(object sender,EventArgs e)
        {
            this.CenterToScreen();
            AccountText.Focus();
        }

        private void Register_Click(object sender,EventArgs e)
        {
            string account = AccountText.Text;
            string psw = PswText.Text;
            string psw2 = PswText2.Text;
            string name = NameText.Text;
            string id = IdText.Text;
            string tell = TellText.Text;
            if(account==""||psw==""||psw2==""||name==""||id==""||tell=="")
                MessageBox.Show("注册信息不完整！");
            else
            {
                if(psw!=psw2) MessageBox.Show("密码与确认密码不一致！");
                else
                {
                    string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                    SqlConnection sqlConnection = new SqlConnection(sqlconn);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(
                        "select * from UserInfo where Userid='"+account+"'"
                        ,sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if(sqlDataReader.Read()) MessageBox.Show("用户名已被注册！");
                    else
                    {
                        sqlDataReader.Close();
                        sqlCommand=new SqlCommand(
                            "insert into UserInfo(Userid,Userpsw,Usertype,Username,Useridcard,Usertell) values('"+account+"','"+psw+"','用户','"+name+"','"+id+"','"+tell+"')"
                            ,sqlConnection);
                        if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("注册失败！");
                        else
                        {
                            MessageBox.Show("注册成功！");
                            sqlConnection.Close();
                            this.Close();
                        }
                    }
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg,Keys keyData)
        {
            if(keyData==Keys.Enter)
            {
                Register.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg,keyData);
        }
    }
}
