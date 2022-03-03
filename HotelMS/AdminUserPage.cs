using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelMS
{
    public partial class AdminUserPage:Form
    {
        public AdminUserPage()
        {
            InitializeComponent();
            string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(sqlconn);
            sqlConnection.Open();
            ShowRefresh(sqlConnection);
            sqlConnection.Close();
        }

        private void ShowRefresh(SqlConnection sqlConnection)
        {
            Userid.Focus();
            SqlCommand sqlCommand = new SqlCommand(
                "select Userid,Usertype,Username,Useridcard,Usertell from UserInfo;"
                ,sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource=dataSet.Tables[0].DefaultView;
        }

        private void Search_Click(object sender,EventArgs e)
        {
            if(Userid.Text=="") MessageBox.Show("请输入用户名！","提示");
            else
            {
                string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlconn);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    "select Userid,Usertype,Username,Useridcard,Usertell from UserInfo where Userid='"+Userid.Text+"';"
                    ,sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource=dataSet.Tables[0].DefaultView;
                sqlConnection.Close();
            }
        }

        private void Change_Click(object sender,EventArgs e)
        {
            if(Userid.Text=="") MessageBox.Show("请输入用户名！","提示");
            else
            {
                AdminChangeUserMessage adminChangeUserMessage = new AdminChangeUserMessage(Userid.Text);
                adminChangeUserMessage.Show();
            }
        }

        private void Exit_Click(object sender,EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg,Keys keyData)
        {
            if(keyData==Keys.F5)
            {
                string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlconn);
                sqlConnection.Open();
                ShowRefresh(sqlConnection);
                sqlConnection.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg,keyData);
        }
    }
}
