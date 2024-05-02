using FuzzyLogic.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.ViewModels
{
    internal class UserPanelViewModel : ViewModelBase
    {

        private IMyNavigationService MyNavigationServie { get; set; }

        public UserPanelViewModel(IMyNavigationService navigationService)
        {
            MyNavigationServie = navigationService;
        }

        private RelayCommand openAdminPanelCommand;

        public RelayCommand OpenAdminPanelCommand
        {
            get
            {
                return openAdminPanelCommand ?? new RelayCommand(
                () =>
                {
                    MyNavigationServie.Navigate("adminPanel");
                });
            }

        }
    }
}
