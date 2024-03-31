using ContactBook.Presenter;

namespace ContactBook
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ContactsBookPresenter contactsBookPresenter = new ContactsBookPresenter();
            ContactsBookView contactsBookView = new ContactsBookView(contactsBookPresenter);
            contactsBookPresenter.CBView = contactsBookView;


            Application.Run(contactsBookView);
        }
    }
}