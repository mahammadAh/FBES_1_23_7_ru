using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFNavigation.Services;
using WPFNavigation.ViewModels;

namespace WPFNavigation
{
    public class ViewModelLocator
    {

        private INavigationService NavigationService { get; set; }

        private MainViewModel MainViewModel { get; set; }
        private FirstScreenViewModel FirstScreenViewModel { get; set; }
        private SecondScreenViewModel SecondScreenViewModel { get; set; }
        private ThirdScreenViewModel ThirdScreenViewModel { get; set; }


        public ViewModelLocator()
        {
            NavigationService = new NavigationService();

            MainViewModel = new MainViewModel(NavigationService);
            FirstScreenViewModel = new FirstScreenViewModel(NavigationService);
            SecondScreenViewModel = new SecondScreenViewModel(NavigationService);
            ThirdScreenViewModel = new ThirdScreenViewModel(NavigationService);

            NavigationService.Register("Main", MainViewModel);
            NavigationService.Register("First", FirstScreenViewModel);
            NavigationService.Register("Second", SecondScreenViewModel);
            NavigationService.Register("Third", ThirdScreenViewModel);

            NavigationService.Navigate("First");
        }


        public ViewModelBase GetMainViewModel()
        {
            return MainViewModel;
        }




    }
}
