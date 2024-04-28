using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFNavigation.Messanger;

namespace WPFNavigation.ViewModels
{
    public class ThirdScreenViewModel : ViewModelBase 
    {
        private string labelText;

        public string LabelText
        {
            get { return labelText; }
            set { Set(ref labelText, value); }
        }

        public ThirdScreenViewModel()
        {
            Messenger.Default.Register<MessageForThirdScreen>(this,
                      message =>
                      {
                          LabelText = "Third Screen : " + message.Text;
                      });
        }


  
    }
}
