using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMS
{
    public partial class RoomMessage:Form
    {
        public RoomMessage()
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
            Roomid.Focus();
            SqlCommand sqlCommand = new SqlCommand(
                "select * from Room order by Roomid;"
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
                    "select * from Room where Roomid="+int.Parse(Roomid.Text)+";"
                    ,sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource=dataSet.Tables[0].DefaultView;
                sqlConnection.Close();
            }
        }

        private void Add_Click(object sender,EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.Show();
        }

        private void Change_Click(object sender,EventArgs e)
        {
            if(Roomid.Text=="") MessageBox.Show("请输入房间号！","提示");
            else
            {
                AdminChangeRoomMessage adminChangeRoomMessage = new AdminChangeRoomMessage(int.Parse(Roomid.Text));
                adminChangeRoomMessage.Show();
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
