using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMS
{
    public partial class OrderMessage:Form
    {
        public OrderMessage()
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
            Orderid.Focus();
            SqlCommand sqlCommand = new SqlCommand(
                "select * from OrderInfo order by Orderid;"
                ,sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource=dataSet.Tables[0].DefaultView;
        }

        private void Search_Click(object sender,EventArgs e)
        {
            if(Orderid.Text=="") MessageBox.Show("请输入订单号！","提示");
            else
            {
                string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlconn);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    "select * from OrderInfo where Orderid="+int.Parse(Orderid.Text)+";"
                    ,sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource=dataSet.Tables[0].DefaultView;
                sqlConnection.Close();
            }
        }

        private void Delete_Click(object sender,EventArgs e)
        {
            if(Orderid.Text=="") MessageBox.Show("请输入订单号","提示");
            else
            {
                string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlconn);
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(
                    "select Orderstate from OrderInfo where Orderid="+int.Parse(Orderid.Text)+";"
                    ,sqlConnection);
                if(sqlCommand.ExecuteScalar().ToString()=="已结束")
                {
                    if(MessageBox.Show("即将删除此条订单记录","提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        sqlCommand=new SqlCommand(
                            "delete from OrderInfo where Orderid="+int.Parse(Orderid.Text)+";"
                            ,sqlConnection);
                        if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("删除失败！","提示");
                        else
                        {
                            MessageBox.Show("删除成功！","提示");
                            ShowRefresh(sqlConnection);
                            sqlConnection.Close();
                        }
                    }
                }
                else
                {
                    if(MessageBox.Show("此条订单尚未结束，确认结束订单并删除","提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        sqlCommand=new SqlCommand(
                            "update Room set Roomstate='空闲' where Roomid in "+
                            "(select Orderroom from OrderInfo where Orderid="+int.Parse(Orderid.Text)+");"
                            ,sqlConnection);
                        if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("删除失败！","提示");
                        else
                        {
                            sqlCommand=new SqlCommand(
                            "delete from OrderTable where Orderid="+int.Parse(Orderid.Text)+";"
                            ,sqlConnection);
                            if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("删除失败！","提示");
                            else
                            {
                                MessageBox.Show("删除成功！","提示");
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
