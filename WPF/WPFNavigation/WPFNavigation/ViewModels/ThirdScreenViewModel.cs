using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFNavigation.Messanger;
using WPFNavigation.Services;

namespace WPFNavigation.ViewModels
{
    public class ThirdScreenViewModel : ViewModelBase 
    {
        private string labelText;

        public string LabelText
        {
            get { return labelText; }
            set { Set(ref labelText, value); }
        }

        public ViewModelLocator NavigationServiceLocator { get; set; }


        public INavigationService navigationService { get; set; }

        public ThirdScreenViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;


        }


        private RelayCommand<string> changeScreens;

        public RelayCommand<string> ChangeScreens
        {
            get
            {
                return changeScreens ?? new RelayCommand<string>(
                    param =>
                    {
                        if (param == "First")
                        {
                            navigationService.Navigate("First");


                        }
                        else if (param == "Second")
                        {
                            navigationService.Navigate("Second");

                        }
                    }
                    );
            }

        }




    }
}
