using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMS
{
    public partial class AdminChangeRoomMessage:Form
    {
        int Roomid;
        public AdminChangeRoomMessage(int Roomid)
        {
            InitializeComponent();
            this.Roomid=Roomid;
            label1.Text="房间"+Roomid;
            string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(sqlconn);
            sqlConnection.Open();
            Type.Text=new SqlCommand(
                "select Roomtype from Room where Roomid="+Roomid+";"
                ,sqlConnection).ExecuteScalar().ToString();
            sqlConnection.Close();
        }

        private void Delete_Click(object sender,EventArgs e)
        {
            if(MessageBox.Show("即将删除房间"+Roomid,"提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlconn);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    "delete from Room where Roomid="+Roomid+";"
                    ,sqlConnection);
                if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("删除失败！","提示");
                else
                {
                    MessageBox.Show("删除成功！","提示");
                    sqlConnection.Close();
                    this.Close();
                }
            }
        }

        private void OK_Click(object sender,EventArgs e)
        {
            string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(sqlconn);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(
                "update Room set Roomtype='"+Type.Text+"' where Roomid="+Roomid+";"
                ,sqlConnection);
            if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("修改失败！","提示");
            else
            {
                MessageBox.Show("修改成功！","提示");
                sqlConnection.Close();
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
