﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Autofarmer
{
    class RelayCommand : ICommand
    {
        protected Action<object> _action;
        protected Predicate<object> _predicate;
        public event EventHandler? CanExecuteChanged;

        public RelayCommand(Action<object> action)
        {
            _action = action;
        }

        public bool CanExecute(object? parameter)
        {
            if (_predicate == null) return true;
            return _predicate(parameter);
        }

        public void Execute(object? parameter)
        {
            _action(parameter!);
        }
    }
}
