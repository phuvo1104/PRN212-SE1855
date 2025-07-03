using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp2;

namespace WpfApp_FE
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
      
        public LoginWindow()
        {
            InitializeComponent();
        }
        public void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            string email = TxtEmail.Text;
            string pwd = TxtPass.Password;
            AccountMember am = accountMemberService.GetAccountMemberByEmailAndPassword(email, pwd);
            if (am == null)
            {
                MessageBox.Show("Đăng nhập thất bại", "Failed Login",
                    MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            else
            {
                MainWindow mainWindow = new MainWindow(am);
                mainWindow.Show();
                this.Close();
            }
        }

    }
}
