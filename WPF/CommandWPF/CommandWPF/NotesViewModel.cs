using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CommandWPF
{
    public class NotesViewModel : ObservibleObject 
    {

        private ObservableCollection<Note> notes;

        public ObservableCollection<Note> Notes
        {
            get { return notes; }
            set { MySet<ObservableCollection<Note>>(ref notes, value); }
        }

        public Note SelectedNote { get; set; }


        private string noteText;

        public string NoteText
        {
            get { return noteText; }
            set { MySet<string>(ref noteText, value); }
        }


        public CommandRelay buttonAddCommnad;

        public CommandRelay ButtonAddCommnad
        {
            get {
                return buttonAddCommnad ?? new CommandRelay(
                    param =>
                    {
                        Notes.Add(new Note() { text = NoteText , isDone = false});
                        NoteText = "";
                    },
                    param =>
                    {
                        return NoteText?.Length > 0;
                    }
                    );
            }

           
        }

        public CommandRelay buttonIsDoneCommand;

        public CommandRelay ButtonIsDoneCommand
        {
            get
            {
                return buttonIsDoneCommand ?? new CommandRelay(
                    param =>
                    {
                        SelectedNote.isDone = !SelectedNote.isDone;
                        MessageBox.Show(SelectedNote.text);
                    }
                    );
            }


        }




        public NotesViewModel()
        {
            Notes = new ObservableCollection<Note>();
        }
    }
}
