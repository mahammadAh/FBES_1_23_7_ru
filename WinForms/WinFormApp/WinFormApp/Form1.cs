namespace WinFormApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.ShowDialog();

            var imageAdress = dialog.FileName;

            labelImageAdress.Text = imageAdress;

            for(int i = 0; i <=100; i++)
            {
                Thread.Sleep(100);
                progressBar1.Value = i;
            }
          

            pictureBoxImage.Image?.Dispose();
            pictureBoxImage.Image = Image.FromFile(imageAdress);
        }
    }
}