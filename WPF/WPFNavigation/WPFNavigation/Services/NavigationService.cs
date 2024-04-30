using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;

namespace WPFNavigation.Services
{
    public class NavigationService : INavigationService
    {
        private Dictionary<string, ViewModelBase> userControls = new Dictionary<string, ViewModelBase>();


        public void Register(string pageName, ViewModelBase viewModel)
        {
            userControls.Add(pageName, viewModel);
        }

        public void Navigate(string pageName)
        {
            Messenger.Default.Send<ViewModelBase>(userControls[pageName]);
        }

       
    }
}
