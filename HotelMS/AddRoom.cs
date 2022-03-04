using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMS
{
    public partial class AddRoom:Form
    {
        public AddRoom()
        {
            InitializeComponent();
            Roomid.Focus();
        }

        private void OK_Click(object sender,EventArgs e)
        {
            if(Roomid.Text=="") MessageBox.Show("请输入房间号！","提示");
            else
            {
                string sqlconn = @"server=LAPTOP-9CFSOQH9;Initial Catalog=HotelMS;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlconn);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    "select * from Room where Roomid="+int.Parse(Roomid.Text)+";"
                    ,sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if(sqlDataReader.Read()) MessageBox.Show("房间已经创建！","提示");
                else
                {
                    sqlDataReader.Close();
                    sqlCommand=new SqlCommand(
                        "insert into Room values("+int.Parse(Roomid.Text)+",'"+Type.Text+"','空闲');"
                        ,sqlConnection);
                    if(sqlCommand.ExecuteNonQuery()==0) MessageBox.Show("添加失败！","提示");
                    else
                    {
                        MessageBox.Show("添加成功！","提示");
                        sqlConnection.Close();
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
