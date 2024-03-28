namespace Calculator
{
    public partial class Form1 : Form
    {
        public string show { get; set; } 
        public string currentPart { get; set; }

        public int result { get; set; } = 0;

        public string sym { get; set; }
        public Form1()
        {
            InitializeComponent();
   
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;
            currentPart += clickedButton.Text;         
            labelRuslt.Text = currentPart;
            

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            sym = "+";
           labelRuslt.Text = sym;
           result += Int32.Parse(currentPart);
            currentPart = string.Empty;

        }

        private void buttonRavno_Click(object sender, EventArgs e)
        {
           switch(sym)
            {
                case "+":
                    result += Int32.Parse(currentPart);
                    break;
            }

            labelRuslt.Text = result.ToString();
        }
    }
}