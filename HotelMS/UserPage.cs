using System;
using System.Windows.Forms;

namespace HotelMS
{
    public partial class UserPage:Form
    {
        string account;
        public UserPage(string account)
        {
            InitializeComponent();
            label1.Text="亲爱的用户"+account+"，您好。";
            this.account=account;
        }

        private void UserPage_Load(object sender,EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Exit_Click(object sender,EventArgs e)
        {
            this.Close();
        }

        private void Change_Click(object sender,EventArgs e)
        {
            UserMessage messageChange = new UserMessage(this.account);
            messageChange.Show();
        }

        private void Bookroom_Click(object sender,EventArgs e)
        {
            UserBookPage bookPage = new UserBookPage(account);
            bookPage.Show();
        }

        private void Checkout_Click(object sender,EventArgs e)
        {
            UserCheckoutPage checkoutPage = new UserCheckoutPage(account);
            checkoutPage.Show();
        }
    }
}
