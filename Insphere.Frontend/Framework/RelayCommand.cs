using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Insphere.Frontend.Framework
{
    /// <summary>
    /// Stanadrd class for operating on ICommands (enabling MVVM for button clicks)
    /// </summary>
    /// <param name="execute">The action to execute</param>
    public class RelayCommand(Action<object> execute) : ICommand
    {

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}
