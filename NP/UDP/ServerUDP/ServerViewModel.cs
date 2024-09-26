using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Sockets;
using System.Windows.Media;
using System.Net;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows;


namespace ServerUDP
{
    class ServerViewModel : ViewModelBase
    {
        private ImageSource screenImage;
        public ImageSource ScreenImage
        {
            get { return screenImage; }
            set { Set(ref screenImage, value); }
        }

        private RelayCommand acceptButtonCommand;

        public RelayCommand AcceptButtonCommand
        {
            get
            {
                return acceptButtonCommand ?? new RelayCommand(
                  () =>
                  {
                     
                      Task.Run(() =>
                      {
                          try
                          {
                              UdpClient udpClient = new UdpClient(7070);

                              IPEndPoint? iep = null;

                              while (true)
                              {

                                
                                  MemoryStream ms = new MemoryStream();
                                  while (true)
                                  {
                                      var byteArr = udpClient.Receive(ref iep);
                                      if (byteArr[0]==0 && byteArr[1] == 1 && byteArr[2] == 2)
                                      {
                                          break;
                                      }

                                      ms.Write(byteArr, 0, byteArr.Length);


                                  }

                                  Application.Current.Dispatcher.Invoke(() =>
                                  {
                                      var imgSrc = GetImageFromBtyeArr(ms);
                                      ScreenImage = imgSrc;
                                  });
                              }
                          }
                          catch (Exception ex)
                          {
                              MessageBox.Show(ex.Message);
                          }
                      });
                      


                  });
            }

        }


        public ImageSource GetImageFromBtyeArr(MemoryStream ms)
        {
            BitmapImage btmI = new BitmapImage();   

            btmI.BeginInit();
            btmI.StreamSource = ms;
            btmI.EndInit();

            ImageSource imageSource = btmI as ImageSource;

            return imageSource;

        }


    }
}
