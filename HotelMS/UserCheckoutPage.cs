using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMS
{
    public partial class UserCheckoutPage:Form
    {
        string account;
        public UserCheckoutPage(string account)
        {
            InitializeComponent();
            this.account=account;
            string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(sqlconn);
            sqlConnection.Open();
            ShowRefresh(sqlConnection);
            sqlConnection.Close();
        }

        private void ShowRefresh(SqlConnection sqlConnection)
        {
            Roomid.Focus();
            SqlCommand sqlCommand = new SqlCommand(
                "select Orderid,Orderroom,Orderstate from OrderInfo where Orderuser='"+account+"' and Orderstate='进行中';"
                ,sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource=dataSet.Tables[0].DefaultView;
        }

        private void Search_Click(object sender,EventArgs e)
        {
            if(Roomid.Text=="") MessageBox.Show("请输入房间号！","提示");
            else
            {
                string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlconn);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    "select * from OrderInfo where Orderroom="+int.Parse(Roomid.Text)+";"
                    ,sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource=dataSet.Tables[0].DefaultView;
                sqlConnection.Close();
            }
        }

        private void Checkout_Click(object sender,EventArgs e)
        {
            if(Roomid.Text=="") MessageBox.Show("请输入房间号！","提示");
            else
            {
                if(MessageBox.Show("退订房间"+Roomid.Text,"提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                    SqlConnection sqlConnection = new SqlConnection(sqlconn);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(
                        "select * from OrderInfo where Orderuser='"+account+"' and Orderroom="+int.Parse(Roomid.Text)+";"
                        ,sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if(!sqlDataReader.Read()) MessageBox.Show("未预订该房间！","提示");
                    else
                    {
                        sqlDataReader.Close();
                        sqlCommand=new SqlCommand(
                            "update Room set Roomstate='空闲' where Roomid="+int.Parse(Roomid.Text)+";"
                            ,sqlConnection);
                        if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("退订失败！","提示");
                        else
                        {
                            sqlCommand=new SqlCommand(
                                "update OrderInfo set Orderstate='已结束' where Orderroom="+int.Parse(Roomid.Text)+";"
                                ,sqlConnection);
                            if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("退订失败！","提示");
                            else
                            {
                                MessageBox.Show("退订成功！","提示");
                                ShowRefresh(sqlConnection);
                                sqlConnection.Close();
                            }
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
