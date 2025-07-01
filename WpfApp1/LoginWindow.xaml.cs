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
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        MyStoreContext context= new MyStoreContext();
        public LoginWindow()
        {
            InitializeComponent();
            ChangeBackGround();
        }

     

  
       
        private void ChangeBackGround()
        {
            LinearGradientBrush brush = new LinearGradientBrush();
            brush.GradientStops.Add(new GradientStop(Colors.Yellow, 0.0));
            brush.GradientStops.Add(new GradientStop(Colors.Green, 0.25));
            brush.GradientStops.Add(new GradientStop(Colors.Blue, 0.5));
            brush.GradientStops.Add(new GradientStop(Colors.Purple, 1.0));
            buttonthoat.Background = brush;
            RadialGradientBrush brush2 = new RadialGradientBrush();
            brush2.GradientStops.Add(new GradientStop(Colors.Yellow, 0.0));
            brush2.GradientStops.Add(new GradientStop(Colors.Green, 0.5));
            brush2.GradientStops.Add(new GradientStop(Colors.Blue, 0.5));
            brush2.GradientStops.Add(new GradientStop(Colors.Purple, 1.0));
            buttondangnhap.Background = brush2;
        }



        private void Button_Click_dangnhap(object sender, RoutedEventArgs e)
        {
            string email = TxtEmail.Text;
            string password = TxtPassword.Password;

            AccountMember am = context.AccountMembers
                .FirstOrDefault(a => a.EmailAddress == email && a.MemberPassword == password);

            if (am == null)
            {
                MessageBox.Show("Đăng nhập thất bại", "Fail Login",
                    MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }

            MessageBox.Show("Đăng nhập thành công", "Success",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click_thoat(object sender, RoutedEventArgs e)
        {

        }
    }
}
