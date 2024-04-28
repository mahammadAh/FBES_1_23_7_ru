using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFNavigation.Messanger;

namespace WPFNavigation.ViewModels
{
    public class SecondScreenViewModel : ViewModelBase 
    {


        private string labelText;

        public string LabelText
        {
            get { return labelText ;  }
            set { Set(ref labelText, value); }
        }

        public SecondScreenViewModel()
        {
            Messenger.Default.Register<MessageForSecondScreen>(this,
                      message =>
                      {
                          LabelText = "Second screen: " + message.Text;
                      });
        }
       

    
    }
}
