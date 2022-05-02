using Signtitik.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Signtitik.Models
{
    class SignModel : ObservableObject
    {
        string _name { get; set; }
        string _category { get; set; }
        string _gif { get; set; }
        string _icon { get; set; }

        public string Name { get { return _name; } set { _name = value; OnPropertyChanged("Name"); } }
        public string Category { get { return _category; } set { _category = value; OnPropertyChanged("Category"); } }
        public string Gif { get { return _gif; } set { _gif = value; OnPropertyChanged("Gif"); } }
        public string Icon { get { return _icon; } set { _icon = value; OnPropertyChanged("Icon"); } }
    }
}
