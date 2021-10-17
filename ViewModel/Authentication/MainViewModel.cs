using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using FeBinder.Authentication.ViewModel.Base;
using FeBinder.Controls.Authentication;
using FeBinder.ViewModel.Base;

namespace FeBinder.ViewModel.Authentication
{
    class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// Link to exits control for display
        /// </summary>
        private UserControl _currentControl;
        /// <summary>
        /// Login Control xaml
        /// </summary>
        private UserControl _loginControl;
        /// <summary>
        /// Register Control xaml
        /// </summary>
        private UserControl _registerControl;

        private RelayCommand _displayLoginCommand;
        private RelayCommand _displayRegisterCommand;

        public RelayCommand DisplayLoginCommand
        {
            get
            {
                return _displayLoginCommand ??
                       (_displayLoginCommand = new RelayCommand(obj =>
                       {
                           
                           CurrentControl = _loginControl;

                       }));
            }
        }

        public RelayCommand DisplayRegisterCommand
        {
            get
            {
                return _displayRegisterCommand ??
                       (_displayRegisterCommand = new RelayCommand(obj =>
                       {
                           CurrentControl = _registerControl;
                       }));
            }
        }



        public UserControl CurrentControl
        {
            get => _currentControl;
            set
            {
                _currentControl = null;
                _currentControl = value;
                OnPropertyChanged("CurrentControl");
            }
        }

        public MainViewModel()
        {
            _loginControl = new LoginControl();
            _registerControl = new RegisterControl();

            _currentControl = _loginControl;
        }
    }
}
