using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Services
{
    internal interface IMyNavigationService
    {
        public void Register(string panelName, ViewModelBase panelViewModel);
        public void Navigate(string panelName);
        
    }
}
