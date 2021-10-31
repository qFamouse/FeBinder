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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FeBinder.Entities;
using FeBinder.Repositories;

namespace FeBinder.Controls.Authentication
{
    /// <summary>
    /// Interaction logic for RegisterControl.xaml
    /// </summary>
    public partial class RegisterControl : UserControl
    {
        private BinderContext _dbContext;

        public RegisterControl()
        {
            InitializeComponent();

            _dbContext = new BinderContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string password = PasswordBox.Password.Trim();
            string password_2 = PasswordBoxConfirm.Password.Trim();

            _dbContext.Users.Add(new User {login = login, password = password});
            _dbContext.SaveChanges();
        }
    }
}
