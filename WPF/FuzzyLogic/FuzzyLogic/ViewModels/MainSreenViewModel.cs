using FuzzyLogic.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.ViewModels
{
    internal class MainSreenViewModel : ViewModelBase
    {
		private ViewModelBase currentPanel;

		public ViewModelBase CurrentPanel
		{
			get { return currentPanel; }
			set { Set(ref currentPanel, value); }
		}

       
        public MainSreenViewModel()
		{
         

            Messenger.Default.Register<ViewModelBase>(this,
				(panelViewModel) =>
				{
					CurrentPanel = panelViewModel;
				}
			);

        }

    }
}
