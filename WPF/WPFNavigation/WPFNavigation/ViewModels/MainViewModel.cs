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


        private Dictionary<string, ViewModelBase> userControls = new Dictionary<string, ViewModelBase>();

        public MainViewModel()
        {
            userControls.Add("First", new FirstScreenViewModel());
            userControls.Add("Second", new SecondScreenViewModel());
            userControls.Add("Third", new ThirdScreenViewModel());
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

                            CurrentScreen = userControls["First"];
                


                        }
                        else if (param == "Second")
                        {
                            CurrentScreen = userControls["Second"];
                            IMyMessenger myMessenger = userControls["Second"] as IMyMessenger;
                            myMessenger.GetMessage();
                        }
                        else if(param == "Third")
                        {
                            CurrentScreen = userControls["Third"];
                            IMyMessenger myMessenger = userControls["Third"] as IMyMessenger;
                            myMessenger.GetMessage();
                        }
                    }
                    );
            }

        }






    }
}
