using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WPFNavigation.Messanger;
using WPFNavigation.Views;
using WPFNavigation.Services;
using GalaSoft.MvvmLight.Messaging;

namespace WPFNavigation.ViewModels
{
    public class MainViewModel :  ViewModelBase
    {
		
      
        private ViewModelBase currentScreen;

        public ViewModelBase CurrentScreen
        {
            get { return currentScreen; }
            set { Set(ref currentScreen, value); }
        }




        public INavigationService navigationService { get; set; }

        public MainViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            Messenger.Default.Register<ViewModelBase>(this,
                          currentScreen =>
                          {
                              CurrentScreen = currentScreen;
                          });

        }



    }
}
