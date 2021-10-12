using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeBinder.Authentication.DataModels;
using FeBinder.Authentication.ViewModel.Base;

namespace FeBinder.Authentication.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        #region Public Members
        /// <summary>
        /// Variable Where We Save Current Page in Auth. menu
        /// </summary>
        public AuthenticationPage CurrentPage { get; set; } = AuthenticationPage.Login;

        #endregion
    }
}
