using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMS
{
    public partial class UserBookPage:Form
    {
        string account;
        public UserBookPage(string account)
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
                "select * from Room order by Roomstate,Roomid;"
                ,sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource=dataSet.Tables[0].DefaultView;
        }

        private void Exit_Click(object sender,EventArgs e)
        {
            this.Close();
        }

        private void Search_Click(object sender,EventArgs e)
        {
            if(Roomid.Text==""&&Roomtype.Text=="") MessageBox.Show("请输入房间号或房间类型！","提示");
            else
            {
                if(Roomid.Text=="")
                {
                    string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                    SqlConnection sqlConnection = new SqlConnection(sqlconn);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(
                        "select * from Room where Roomtype='"+Roomtype.Text+"' order by Roomstate,Roomid;"
                        ,sqlConnection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);
                    dataGridView1.DataSource=dataSet.Tables[0].DefaultView;
                    sqlConnection.Close();
                }
                else
                {
                    string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                    SqlConnection sqlConnection = new SqlConnection(sqlconn);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(
                        "select * from Room where Roomid="+int.Parse(Roomid.Text)+" order by Roomstate,Roomid;"
                        ,sqlConnection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);
                    dataGridView1.DataSource=dataSet.Tables[0].DefaultView;
                    sqlConnection.Close();
                }
            }
        }

        private void Book_Click(object sender,EventArgs e)
        {
            if(Roomid.Text=="") MessageBox.Show("请输入房间号！","提示");
            else
            {
                if(MessageBox.Show("预订房间"+Roomid.Text,"提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                    SqlConnection sqlConnection = new SqlConnection(sqlconn);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(
                        "select Roomstate from Room where Roomid="+int.Parse(Roomid.Text)+";"
                        ,sqlConnection);
                    if(sqlCommand.ExecuteScalar().ToString()=="占用") MessageBox.Show("房间已被占用！","提示");
                    else
                    {
                        sqlCommand=new SqlCommand(
                            "update Room set Roomstate='占用' where Roomid="+int.Parse(Roomid.Text)+";"
                            ,sqlConnection);
                        if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("预订失败！","提示");
                        else
                        {
                            sqlCommand=new SqlCommand(
                                "insert into OrderTable(Orderroom,Orderuser,Orderstate)"+
                                "values("+int.Parse(Roomid.Text)+",'"+account+"','进行中');"
                                ,sqlConnection);
                            if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("预订失败！","提示");
                            else
                            {
                                MessageBox.Show("预订成功！","提示");
                                ShowRefresh(sqlConnection);
                                sqlConnection.Close();
                            }
                        }
                    }
                }
            }
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
