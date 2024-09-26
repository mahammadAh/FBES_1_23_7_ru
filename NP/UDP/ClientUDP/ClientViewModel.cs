using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

using System.Net.Sockets;

using System.Windows;

namespace ClientUDP
{
    class ClientViewModel : ViewModelBase
    {

        public ClientViewModel()
        {
            IP = "127.0.0.1";
            PORT = "7070";
        }


        private string port;
        public string PORT
        {
            get { return port; }
            set { Set(ref port, value); }
        }

        private string ip;
        public string IP
        {
            get { return ip; }
            set { Set(ref ip, value); }
        }



        private RelayCommand shareButtonCommand;

        public RelayCommand ShareButtonCommand
        {
            get
            {
                return shareButtonCommand ?? new RelayCommand(
                  () =>
                  {
                      Task.Run(() =>
                      {
                          UdpClient client = new UdpClient(IP, Convert.ToInt32(PORT));

                          while (true)
                          {

                              var byteArr = ScreenShot();

                              byte[] buffer = new byte[32000];
                              MemoryStream ms = new MemoryStream(byteArr);
                              while(ms.Read(buffer, 0, buffer.Length)!=0){
                                  client.Send(buffer);
                              }

                              byte[] stopCode = new byte[3] { 0, 1, 2 };
                              client.Send(stopCode);

                          }
                      });
                    
                  });
            }

        }


        public byte[] ScreenShot()
        {
            try
            {
                int screenWidth = (int)SystemParameters.VirtualScreenWidth;
                int screenHeight = (int)SystemParameters.VirtualScreenHeight;

             
                using (MemoryStream ms = new MemoryStream())
                {
                    Bitmap btmp = new Bitmap(screenWidth, screenHeight);

                    using (Graphics g = Graphics.FromImage(btmp))
                    {
                        g.CopyFromScreen(0,0, 0, 0, new System.Drawing.Size{ Width = screenWidth , Height = screenHeight});
                        Bitmap btmpObj = new Bitmap(btmp, (int)(screenWidth), (int)(screenHeight));
                        btmpObj.Save(ms, ImageFormat.Jpeg);
                        return ms.GetBuffer();
                    }
                }
            }
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

           
        }




    }
}
