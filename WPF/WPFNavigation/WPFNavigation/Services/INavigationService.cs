using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNavigation.Services
{
    public interface INavigationService
    {
        public void Register(string pageName , ViewModelBase viewModel);

        public void Navigate(string pageName);
    }
}
