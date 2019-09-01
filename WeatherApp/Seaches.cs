using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WeatherApp
{
    class Seaches :INotifyPropertyChanged
    {

        
            public event PropertyChangedEventHandler PropertyChanged;

            public string Seache { get; set; }

            private string _origin;
            public string Origin
            {
                get { return _origin; }
                set
                {
                    if (_origin == value) return;   
                    _origin = value;
                    OnPropertyChanged(nameof(Origin));
                }
            }

            

            private void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(propertyName));
            }


           public string seachOptions { get; set; }

            public Seaches()
            {

            }

            public Seaches(string s)
            {
                seachOptions = s;
            }
        }
}
