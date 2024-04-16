using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandWPF
{
    public class CommandRelay : ICommand
    {
        public Action<object> execute { get; set; }
        public Func<object,bool> canExecute { get; set; }

        //  public event EventHandler? CanExecuteChanged;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public CommandRelay(Action<object> execute, Func<object,bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
           return canExecute == null  ||  canExecute.Invoke(parameter);
            
        }

        public void Execute(object? parameter)
        {
            execute?.Invoke(parameter);
        }
    }
}
