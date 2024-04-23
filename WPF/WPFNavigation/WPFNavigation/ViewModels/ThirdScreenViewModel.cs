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
    public class ThirdScreenViewModel : ViewModelBase ,IMyMessenger
    {
        private string labelText;

        public string LabelText
        {
            get { return labelText; }
            set { Set(ref labelText, value); }
        }




        public void GetMessage()
        {
            Messenger.Default.Register<string>(this,
                         message =>
                         {
                             LabelText = "Received: " + message;
                         });
        }
    }
}
