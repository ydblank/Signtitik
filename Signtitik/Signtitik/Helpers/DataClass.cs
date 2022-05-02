using Signtitik.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Signtitik.Helpers
{
    public static class DataClass
    {
        public static ObservableCollection<SignModel> signModels = new ObservableCollection<SignModel>()
        {
            new SignModel()
            {
                Name = "Red",
                Category = "Color",
                Gif = "red.gif",
                Icon = ""
            },
            new SignModel()
            {
                Name = "Yellow",
                Category = "Color",
                Gif = "yellow.gif",
                Icon = ""
            },
        };
    }
}
