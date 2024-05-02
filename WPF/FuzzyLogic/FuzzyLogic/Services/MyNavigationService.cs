using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Services
{
    internal class MyNavigationService : IMyNavigationService
    {
        private IDictionary<string, ViewModelBase> panels = new Dictionary<string, ViewModelBase>();


        public void Register(string panelName, ViewModelBase panelViewModel)
        {
            panels.Add(panelName, panelViewModel);
        }

        public void Navigate(string panelName)
        {
            Messenger.Default.Send<ViewModelBase>(panels[panelName]);
        }

      
    }
}
