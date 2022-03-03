using System;
using System.Windows.Forms;

namespace HotelMS
{
    public partial class AdminPage:Form
    {
        string account;
        public AdminPage(string account)
        {
            InitializeComponent();
            label1.Text="亲爱的管理员"+account+"，您好。";
            this.account=account;
        }

        private void AdminPage_Load(object sender,EventArgs e)
        {
            this.CenterToScreen();
        }

        private void RoomButton_Click(object sender,EventArgs e)
        {
            RoomMessage roomMessage = new RoomMessage();
            roomMessage.Show();
        }

        private void Exit_Click(object sender,EventArgs e)
        {
            this.Close();
        }

        private void UserButton_Click(object sender,EventArgs e)
        {
            AdminUserPage adminUserPage = new AdminUserPage();
            adminUserPage.Show();
        }

        private void OrderButton_Click(object sender,EventArgs e)
        {
            OrderMessage orderMessage = new OrderMessage();
            orderMessage.Show();
        }

        private void Message_Click(object sender,EventArgs e)
        {
            UserMessage userMessage = new UserMessage(account);
            userMessage.Show();
        }
    }
}
