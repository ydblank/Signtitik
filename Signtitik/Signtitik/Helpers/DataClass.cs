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
            new SignModel() { Name = "A", Category = "Alphabet", Gif = "A.gif", Icon = "" },
            new SignModel() { Name = "B", Category = "Alphabet", Gif = "B.gif", Icon = "" },
            new SignModel() { Name = "C", Category = "Alphabet", Gif = "C.gif", Icon = "" },
            new SignModel() { Name = "D", Category = "Alphabet", Gif = "D.gif", Icon = "" },
            new SignModel() { Name = "E", Category = "Alphabet", Gif = "E.gif", Icon = "" },
            new SignModel() { Name = "F", Category = "Alphabet", Gif = "F.gif", Icon = "" },
            new SignModel() { Name = "G", Category = "Alphabet", Gif = "G.gif", Icon = "" },
            new SignModel() { Name = "H", Category = "Alphabet", Gif = "H.gif", Icon = "" },
            new SignModel() { Name = "I", Category = "Alphabet", Gif = "I.gif", Icon = "" },
            new SignModel() { Name = "J", Category = "Alphabet", Gif = "J.gif", Icon = "" },
            new SignModel() { Name = "K", Category = "Alphabet", Gif = "K.gif", Icon = "" },
            new SignModel() { Name = "L", Category = "Alphabet", Gif = "L.gif", Icon = "" },
            new SignModel() { Name = "M", Category = "Alphabet", Gif = "M.gif", Icon = "" },
            new SignModel() { Name = "N", Category = "Alphabet", Gif = "N.gif", Icon = "" },
            new SignModel() { Name = "O", Category = "Alphabet", Gif = "O.gif", Icon = "" },
            new SignModel() { Name = "P", Category = "Alphabet", Gif = "P.gif", Icon = "" },
            new SignModel() { Name = "Q", Category = "Alphabet", Gif = "Q.gif", Icon = "" },
            new SignModel() { Name = "R", Category = "Alphabet", Gif = "R.gif", Icon = "" },
            new SignModel() { Name = "S", Category = "Alphabet", Gif = "S.gif", Icon = "" },
            new SignModel() { Name = "T", Category = "Alphabet", Gif = "T.gif", Icon = "" },
            new SignModel() { Name = "U", Category = "Alphabet", Gif = "U.gif", Icon = "" },
            new SignModel() { Name = "V", Category = "Alphabet", Gif = "V.gif", Icon = "" },
            new SignModel() { Name = "W", Category = "Alphabet", Gif = "W.gif", Icon = "" },
            new SignModel() { Name = "X", Category = "Alphabet", Gif = "X.gif", Icon = "" },
            new SignModel() { Name = "Y", Category = "Alphabet", Gif = "Y.gif", Icon = "" },
            new SignModel() { Name = "Z", Category = "Alphabet", Gif = "Z.gif", Icon = "" },

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

            // Greetings Category
            new SignModel() { Name = "Hi", Category = "Greetings", Gif = "hi.gif", Icon = "" },
            new SignModel() { Name = "Hello", Category = "Greetings", Gif = "hello.gif", Icon = "" },
            new SignModel() { Name = "Good Morning", Category = "Greetings", Gif = "good_morning.gif", Icon = "" },
            new SignModel() { Name = "Good Noon", Category = "Greetings", Gif = "good_noon.gif", Icon = "" },
            new SignModel() { Name = "Good Afternoon", Category = "Greetings", Gif = "good_afternoon.gif", Icon = "" },
            new SignModel() { Name = "Good Evening", Category = "Greetings", Gif = "good_evening.gif", Icon = "" },
            new SignModel() { Name = "Please", Category = "Greetings", Gif = "please.gif", Icon = "" },
            new SignModel() { Name = "Thank You", Category = "Greetings", Gif = "thank_you.gif", Icon = "" },
            new SignModel() { Name = "Your Welcom", Category = "Greetings", Gif = "your_welcome.gif", Icon = "" },
        };
    }
}
