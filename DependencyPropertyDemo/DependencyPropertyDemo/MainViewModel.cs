using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using DependencyPropertyDemo.Annotations;

namespace DependencyPropertyDemo
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private byte _red;
        private byte _green;
        private byte _blue;

        public byte Red
        {
            get => _red;
            set
            {
                if (value.Equals(_red)) return;
                _red = value;
                OnPropertyChanged();
            }
        }

        public byte Green
        {
            get => _green;
            set
            {
                if (value.Equals(_green)) return;
                _green = value;
                OnPropertyChanged();
            }
        }

        public byte Blue
        {
            get => _blue;
            set
            {
                if (value.Equals(_blue)) return;
                _blue = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}