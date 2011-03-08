using System;
using System.ComponentModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace EtwasGrafik
{
    public class Model : INotifyPropertyChanged
    {

        private string _ellipseText;
        public string EllipseText
        {
            get { return _ellipseText; }
            set
            {
                if(value != _ellipseText)
                {
                    _ellipseText = value;
                    OnPropertyChanged("EllipseText");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string message)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(message));
            }
        }
    }
}
