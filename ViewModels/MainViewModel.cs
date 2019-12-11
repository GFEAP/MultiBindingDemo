using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace GeeDemos.MultiBinding.ViewModels
{
    /// <summary>
    /// Simplified MVVM: This ViewModel contains the 'Model'
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            ScaleFactor = 1.0d;
        }

        #region private Actions
        private Action CloseWindowAction;
        #endregion

        #region public Methods
        public void SetCloseAction(Action closeWindowAction)
        {
            if (CloseWindowAction == null)
                CloseWindowAction = new Action(closeWindowAction);
        }
        #endregion

        #region Model
        private string _Text1;
        private string _Text2;
        private string _Text3;
        private string _Text4;
        private double _ScaleFactor;
        #endregion

        #region ViewModel
        public string Text1
        {
            get => _Text1;
            set => Set(ref _Text1, value);
        }
        public string Text2
        {
            get => _Text2;
            set => Set(ref _Text2, value);
        }
        public string Text3
        {
            get => _Text3;
            set => Set(ref _Text3, value);
        }
        public string Text4
        {
            get => _Text4;
            set => Set(ref _Text4, value);
        }
        public double ScaleFactor
        {
            get => _ScaleFactor;
            set => Set(ref _ScaleFactor, value);
        }
        #endregion


        #region ICommandInvokers
        private void CloseWindowCommandInvoker(object commandParameter)
        {
            CloseWindowAction?.Invoke();
        }

        #endregion

        ICommand _CloseWindowCommand;
        public ICommand CloseWindowCommand
        {
            get
            {
                if (_CloseWindowCommand == null)
                    _CloseWindowCommand = new RelayCommand<object>(CloseWindowCommandInvoker);
                return _CloseWindowCommand;
            }
        }

    }
}
