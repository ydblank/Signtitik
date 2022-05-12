using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Signtitik.Helpers
{
    public static class DataClass
    {
        public static ObservableCollection<SignModel> signList = new ObservableCollection<SignModel>()
        {
            // Alphabet Category
            new SignModel() { Name = "A", Category = "Alphabet", Gif = "a.gif", Icon = "" },
            new SignModel() { Name = "B", Category = "Alphabet", Gif = "b.gif", Icon = "" },
            new SignModel() { Name = "C", Category = "Alphabet", Gif = "c.gif", Icon = "" },
            new SignModel() { Name = "D", Category = "Alphabet", Gif = "d.gif", Icon = "" },
            new SignModel() { Name = "E", Category = "Alphabet", Gif = "e.gif", Icon = "" },
            new SignModel() { Name = "F", Category = "Alphabet", Gif = "f.gif", Icon = "" },
            new SignModel() { Name = "G", Category = "Alphabet", Gif = "g.gif", Icon = "" },
            new SignModel() { Name = "H", Category = "Alphabet", Gif = "h.gif", Icon = "" },
            new SignModel() { Name = "I", Category = "Alphabet", Gif = "i.gif", Icon = "" },
            new SignModel() { Name = "J", Category = "Alphabet", Gif = "j.gif", Icon = "" },
            new SignModel() { Name = "K", Category = "Alphabet", Gif = "k.gif", Icon = "" },
            new SignModel() { Name = "L", Category = "Alphabet", Gif = "l.gif", Icon = "" },
            new SignModel() { Name = "M", Category = "Alphabet", Gif = "m.gif", Icon = "" },
            new SignModel() { Name = "N", Category = "Alphabet", Gif = "n.gif", Icon = "" },
            new SignModel() { Name = "O", Category = "Alphabet", Gif = "o.gif", Icon = "" },
            new SignModel() { Name = "P", Category = "Alphabet", Gif = "p.gif", Icon = "" },
            new SignModel() { Name = "Q", Category = "Alphabet", Gif = "q.gif", Icon = "" },
            new SignModel() { Name = "R", Category = "Alphabet", Gif = "r.gif", Icon = "" },
            new SignModel() { Name = "S", Category = "Alphabet", Gif = "s.gif", Icon = "" },
            new SignModel() { Name = "T", Category = "Alphabet", Gif = "t.gif", Icon = "" },
            new SignModel() { Name = "U", Category = "Alphabet", Gif = "u.gif", Icon = "" },
            new SignModel() { Name = "V", Category = "Alphabet", Gif = "v.gif", Icon = "" },
            new SignModel() { Name = "W", Category = "Alphabet", Gif = "w.gif", Icon = "" },
            new SignModel() { Name = "X", Category = "Alphabet", Gif = "x.gif", Icon = "" },
            new SignModel() { Name = "Y", Category = "Alphabet", Gif = "y.gif", Icon = "" },
            new SignModel() { Name = "Z", Category = "Alphabet", Gif = "z.gif", Icon = "" },

            // Colors Category
            new SignModel() { Name = "Colors", Category = "Colors",  Gif = "colors.gif", Icon = "" },
            new SignModel() { Name = "Red", Category = "Colors", Gif = "red.gif", Icon = "" },
            new SignModel() { Name = "Yellow", Category = "Colors",  Gif = "yellow.gif", Icon = "" },
            new SignModel() { Name = "Blue", Category = "Colors",  Gif = "blue.gif", Icon = "" },
            new SignModel() { Name = "Orange", Category = "Colors",  Gif = "orange.gif", Icon = "" },
            new SignModel() { Name = "Green", Category = "Colors",  Gif = "green.gif", Icon = "" },
            new SignModel() { Name = "Brown", Category = "Colors",  Gif = "brown.gif", Icon = "" },
            new SignModel() { Name = "Violet", Category = "Colors",  Gif = "violet.gif", Icon = "" },
            new SignModel() { Name = "Black", Category = "Colors",  Gif = "black.gif", Icon = "" },
            new SignModel() { Name = "White", Category = "Colors",  Gif = "white.gif", Icon = "" },

            // Temperature Category
            new SignModel() { Name = "Temperature", Category = "Temperature", Gif = "temperature.gif", Icon = ""},
            new SignModel() { Name = "Cold", Category = "Temperature", Gif = "cold.gif", Icon = ""},
            new SignModel() { Name = "Hot", Category = "Temperature", Gif = "hot.gif", Icon = ""},

            // Size Category
            new SignModel() { Name = "Size", Category = "Size", Gif = "size.gif", Icon = ""},
            new SignModel() { Name = "Big", Category = "Size", Gif = "big.gif", Icon = "" },
            new SignModel() { Name = "Medium", Category = "Size", Gif = "medium.gif", Icon = ""},
            new SignModel() { Name = "Small", Category = "Size", Gif = "small.gif", Icon = ""},
            new SignModel() { Name = "Long", Category = "Size", Gif = "long.gif", Icon = ""},
            new SignModel() { Name = "Short", Category = "Size", Gif = "short.gif", Icon = ""},

            // Greetings Category
            new SignModel() { Name = "Hi", Category = "Greetings", Gif = "hi.gif", Icon = "" },
            new SignModel() { Name = "Hello", Category = "Greetings", Gif = "hello.gif", Icon = "" },
            new SignModel() { Name = "Good Morning", Category = "Greetings", Gif = "good_morning.gif", Icon = "" },
            new SignModel() { Name = "Good Noon", Category = "Greetings", Gif = "good_noon.gif", Icon = "" },
            new SignModel() { Name = "Good Afternoon", Category = "Greetings", Gif = "good_afternoon.gif", Icon = "" },
            new SignModel() { Name = "Good Evening", Category = "Greetings", Gif = "good_evening.gif", Icon = "" },
            new SignModel() { Name = "Please", Category = "Greetings", Gif = "please.gif", Icon = "" },
            new SignModel() { Name = "Thank You", Category = "Greetings", Gif = "thank_you.gif", Icon = "" },
            new SignModel() { Name = "Your Welcome", Category = "Greetings", Gif = "your_welcome.gif", Icon = "" },

            // Other Phrases Category - Seller 
        };
    }
}
