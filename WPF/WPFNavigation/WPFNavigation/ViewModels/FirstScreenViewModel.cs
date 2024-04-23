﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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








        private RelayCommand<string> sendTextCommnad;

        public RelayCommand<string> SendTextCommnad
        {
            get
            {
                return sendTextCommnad ?? new RelayCommand<string>(
                   param =>
                    {
                        if(param == "Second")
                        {
                            Messenger.Default.Send<string>(Text);
                        }
                        else if (param == "Third")
                        {
                            Messenger.Default.Send<string>(Text);
                        }
                
                    }
                    );
            }

        }





    }
}