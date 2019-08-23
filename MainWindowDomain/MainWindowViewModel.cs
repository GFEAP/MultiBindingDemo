using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MultiBindingDemo.MainWindowDomain
{
    /// <summary>
    /// Simplified MVVM: This ViewModel contains the 'Model'
    /// </summary>
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        
        public MainWindowViewModel()
        {
            ScaleFactor = 1.0d;
        }

        private string _Text1;
        private string _Text2;
        private string _Text3;
        private string _Text4;
        private double _ScaleFactor;
        

        public string Text1
        {
            get => _Text1;
            set
            {
                if (_Text1 != value)
                {
                    _Text1 = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Text2
        {
            get => _Text2;
            set
            {
                if (_Text2 != value)
                {
                    _Text2 = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Text3
        {
            get => _Text3;
            set
            {
                if (_Text3 != value)
                {
                    _Text3 = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Text4
        {
            get => _Text4;
            set
            {
                if (_Text4 != value)
                {
                    _Text4 = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double ScaleFactor
        {
            get => _ScaleFactor;
            set
            {
                if (_ScaleFactor != value)
                {
                    _ScaleFactor = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
