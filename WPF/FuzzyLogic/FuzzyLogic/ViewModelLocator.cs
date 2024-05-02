using FuzzyLogic.Services;
using FuzzyLogic.ViewModels;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace FuzzyLogic
{
    internal class ViewModelLocator
    {
        private AdminPanelViewModel adminPanelVM { get; set; }
        private UserPanelViewModel userPanelVM { get; set; }
        private MainSreenViewModel mainScreenVM { get; set; }

        private IMyNavigationService navigationService { get; set; }

        public ViewModelLocator() 
        {
            navigationService = new MyNavigationService();

            adminPanelVM = new AdminPanelViewModel(navigationService);
            userPanelVM = new UserPanelViewModel(navigationService);
            mainScreenVM = new MainSreenViewModel();

            navigationService.Register("adminPanel", adminPanelVM);
            navigationService.Register("userPanel", userPanelVM);

            navigationService.Navigate("adminPanel");
        }

        public ViewModelBase GetMainScreenVM()
        {
            return mainScreenVM;
        }


    }
}
