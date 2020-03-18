using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEditorSample
{
    public class ViewModel : INotifyPropertyChanged
    {
        private bool isEnabled;

        public bool IsEnabled
        {
            get { return isEnabled; }
            set
            {
                isEnabled = value;
                OnPropertyChanged("IsEnabled");
            }
        }

        private int index;
        public int SelectedIndex
        {
            get { return index; }
            set
            {
                index = value;
                OnPropertyChanged("SelectedIndex");
            }
        }

        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public ViewModel()
        {
            IsEnabled = false;
            SelectedIndex = 6;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
