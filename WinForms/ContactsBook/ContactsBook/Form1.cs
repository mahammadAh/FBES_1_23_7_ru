using System.Diagnostics.Metrics;
using System.Drawing.Design;

namespace ContactsBook
{
    public partial class Form1 : Form
    {
        public List<Contact> Contacts;
        public int counter = 0;

        List<EyesColor> eyesColors = new List<EyesColor>() { EyesColor.Green, EyesColor.Black, EyesColor.Blue, EyesColor.Brown };
        public Form1()
        {
            InitializeComponent();
            Contacts = new List<Contact>()
            {
                new Contact(){ Name = "Elnur", Surname = "Aliyev",Gender = Gender.Male , Phone = "(055) 737-23-23",EyesColor = EyesColor.Brown , isMarried = true ,imageURL = "C:\\Users\\ahmadov_m\\Desktop\\CODE\\FBES_1_23_7_ru\\WinForms\\ContactsBook\\ContactsBook\\Images\\cat1.jpg"},
                new Contact(){ Name = "Alyona", Surname = "Vishnevetskaya",Gender = Gender.Female , Phone = "(055) 737-23-23",EyesColor = EyesColor.Green , isMarried = false,imageURL = "C:\\Users\\ahmadov_m\\Desktop\\CODE\\FBES_1_23_7_ru\\WinForms\\ContactsBook\\ContactsBook\\Images\\cat2.jpg"},
                new Contact(){ Name = "David", Surname = "Sladkov",Gender = Gender.Male , Phone = "(055) 737-23-23",EyesColor = EyesColor.Brown , isMarried = true,imageURL ="C:\\Users\\ahmadov_m\\Desktop\\CODE\\FBES_1_23_7_ru\\WinForms\\ContactsBook\\ContactsBook\\Images\\cat3.jpg" },
                new Contact(){ Name = "Ayaz", Surname = "Bagirzade",Gender = Gender.Male , Phone = "(055) 737-23-23",EyesColor = EyesColor.Brown , isMarried = true ,imageURL = "C:\\Users\\ahmadov_m\\Desktop\\CODE\\FBES_1_23_7_ru\\WinForms\\ContactsBook\\ContactsBook\\Images\\cat4.jpg"},
                new Contact(){ Name = "Fuad", Surname = "Shukurzade",Gender = Gender.Male , Phone = "(055) 737-23-23",EyesColor = EyesColor.Brown , isMarried = false,imageURL ="C:\\Users\\ahmadov_m\\Desktop\\CODE\\FBES_1_23_7_ru\\WinForms\\ContactsBook\\ContactsBook\\Images\\cat5.jpg"},
                new Contact(){ Name = "Dinara", Surname = "Qasimova",Gender = Gender.Female , Phone = "(055) 737-23-23",EyesColor = EyesColor.Brown , isMarried = false ,imageURL = "C:\\Users\\ahmadov_m\\Desktop\\CODE\\FBES_1_23_7_ru\\WinForms\\ContactsBook\\ContactsBook\\Images\\cat3.jpg"},
            };

            listBoxContacts.DataSource = null;
            listBoxContacts.DataSource = Contacts;

            comboBoxEyesColor.DataSource = eyesColors;


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{textBoxName.Text} {textBoxSurname.Text}","myWindow",MessageBoxButtons.OK,MessageBoxIcon.Information);

            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text))
            {
                MessageBox.Show("Name or Surname Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }


            Contact newContact = new Contact();

            newContact.Name = textBoxName.Text;
            newContact.Surname = textBoxSurname.Text;

            if (radioButtonMale.Checked)
            {
                newContact.Gender = Gender.Male;
            }
            else if (radioButtonFemale.Checked)
            {
                newContact.Gender = Gender.Female;
            }

            newContact.Phone = maskedTextBoxPhone.Text;

            int eyesIndex = comboBoxEyesColor.SelectedIndex;

            if (eyesIndex == 0)
            {
                newContact.EyesColor = EyesColor.Green;
            }
            else if (eyesIndex == 1)
            {
                newContact.EyesColor = EyesColor.Black;
            }
            else if (eyesIndex == 2)
            {
                newContact.EyesColor = EyesColor.Blue;
            }
            else if (eyesIndex == 3)
            {
                newContact.EyesColor = EyesColor.Brown;
            }

            newContact.isMarried = checkBoxMarried.Checked;

            Contacts.Add(newContact);

            listBoxContacts.DataSource = null;
            listBoxContacts.DataSource = Contacts;
            //listBoxContacts.Items.Add(newContact);
            CleanView();
        }

        private void CleanView()
        {
            textBoxName.Text = string.Empty;
            textBoxSurname.Text = string.Empty;
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = true;
            maskedTextBoxPhone.Text = string.Empty;
            checkBoxMarried.Checked = false;

        }
        private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContacts.SelectedIndex >= 0)
            {
                labelName.Text = Contacts[listBoxContacts.SelectedIndex].Name;
                labelSurname.Text = Contacts[listBoxContacts.SelectedIndex].Surname;
                labelGender.Text = Contacts[listBoxContacts.SelectedIndex].Gender.ToString();
                labelPhone.Text = Contacts[listBoxContacts.SelectedIndex].Phone;
                labelEyesColor.Text = Contacts[listBoxContacts.SelectedIndex].EyesColor.ToString();
                bool isMarried = Contacts[listBoxContacts.SelectedIndex].isMarried;
                labelMarried.Text = isMarried ? "Yes" : "No";
                if (!String.IsNullOrEmpty(Contacts[listBoxContacts.SelectedIndex].imageURL))
                {
                    pictureBoxImage.Image?.Dispose();
                    pictureBoxImage.Image = Image.FromFile(Contacts[listBoxContacts.SelectedIndex].imageURL);

                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxContacts.SelectedIndex >= 0)
            {
                string text = $"Remove {Contacts[listBoxContacts.SelectedIndex].ToString()} ?";
                var result = MessageBox.Show(text, "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Contacts.RemoveAt(listBoxContacts.SelectedIndex);
                    listBoxContacts.DataSource = null;
                    listBoxContacts.DataSource = Contacts;
                    CleanView();
                }
            }
        }
    }

    public enum Gender { Male, Female }

    public enum EyesColor { Green, Black, Blue, Brown }

    public class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Gender Gender { get; set; }

        public string Phone { get; set; }

        public EyesColor EyesColor { get; set; }

        public bool isMarried { get; set; }

        public string imageURL { get; set; }


        public override string ToString()
        {
            return $"{Name} {Surname}";

        }
    }
}