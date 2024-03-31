using ContactBook.Presenter;
using ContactBook.Model;
namespace ContactBook
{
    public partial class ContactsBookView : Form
    {
        public ContactsBookPresenter CBPresenter { get; set; }

        public ContactsBookView(ContactsBookPresenter contactsBookPresenter)
        {
            InitializeComponent();
            CBPresenter = contactsBookPresenter;
        }

        public void UpdateContactsList(List<Contact> contacts)
        {
            listBoxContacts.DataSource = null;
            listBoxContacts.DataSource = contacts;
        }

        public void Clear()
        {
            textBoxName.Text = String.Empty;
            textBoxSurname.Text = String.Empty;
            textBoxPhone.Text = String.Empty;
        }


        public void OnClick_AddButton(object sender, EventArgs e)
        {
            try
            {
                CBPresenter.AddContact(new Contact()
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Phone = textBoxPhone.Text
                });

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void OnClick_DeleteButton(object sender, EventArgs e)
        {
            Contact selectedContact = listBoxContacts.SelectedItem as Contact;
            CBPresenter.RemoveContact(selectedContact);
        }
    }
}