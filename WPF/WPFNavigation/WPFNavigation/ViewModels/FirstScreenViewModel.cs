using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WPFNavigation.Messanger;
using WPFNavigation.Services;

namespace WPFNavigation.ViewModels
{ 
    public class FirstScreenViewModel : ViewModelBase
    {

		private string text;

		public string Text
		{
			get { return text; }
			set { Set(ref text, value); }
		}


        public INavigationService navigationService { get; set; }

        public FirstScreenViewModel(INavigationService navigationService)
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
                         if (param == "Second")
                        {
                            navigationService.Navigate("Second");


                        }
                        else if (param == "Third")
                        {
                            navigationService.Navigate("Third");

                        }
                    }
                    );
            }

        }





    }
}
