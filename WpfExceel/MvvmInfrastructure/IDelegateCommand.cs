﻿namespace WpfExceel.MvvmInfrastructure
{
    using System.Windows.Input;

    public interface IDelegateCommand : ICommand
    {
        void RaiseCanExecuteChanged();
    }
}
