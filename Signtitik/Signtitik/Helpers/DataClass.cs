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
            new SignModel() { Name = "Long", Category = "Size", Gif = "longs.gif", Icon = ""},
            new SignModel() { Name = "Short", Category = "Size", Gif = "shorts.gif", Icon = ""},

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
            new SignModel() { Name = "What are you looking for", Category = "PhrasesSeller", Gif = "what_are_you_looking_for.gif", Icon = "" },
            new SignModel() { Name = "Try checking the other stores", Category = "PhrasesSeller", Gif = "try_checking_the_other_stores.gif", Icon = "" },
            new SignModel() { Name = "Do you still want to buy this", Category = "PhrasesSeller", Gif = "do_you_still_want_to_buy_this.gif", Icon = "" },
            new SignModel() { Name = "Is this all you want to buy", Category = "PhrasesSeller", Gif = "is_this_all_you_want_to_buy.gif", Icon = "" },
            new SignModel() { Name = "Sorry we can't accept cash yet. We don't have any change", Category = "PhrasesSeller", Gif = "sorry_we_cant_accept_cash_yet_we_dont_have_any_change.gif", Icon = "" },
            new SignModel() { Name = "Sorry, we do not have this in our store", Category = "PhrasesSeller", Gif = "sorry_we_do_not_have_this_in_our_store.gif", Icon = "" },
            new SignModel() { Name = "This product is fresh", Category = "PhrasesSeller", Gif = "this_product_is_fresh.gif", Icon = "" },
            new SignModel() { Name = "Is this what you're looking for", Category = "PhrasesSeller", Gif = "is_this_what_youre_looking_for", Icon = "" },
            new SignModel() { Name = "Did you bring an ecobag", Category = "PhrasesSeller", Gif = "did_you_bring_an_ecobag.gif", Icon = "" },

            // Other Phrases Category - Buyer
            new SignModel() { Name = "The money you gave is not enough", Category = "PhrasesBuyer", Gif = "the_money_you_gave_is_not_enough.gif", Icon = "" },
            new SignModel() { Name = "Do you have this product", Category = "PhrasesBuyer", Gif = "do_you_have_this_product.gif", Icon = "" },
            new SignModel() { Name = "Are there any variations for this product", Category = "PhrasesBuyer", Gif = "are_there_any_variations_for_this_product.gif", Icon = "" },
            new SignModel() { Name = "In which store can I find this product", Category = "PhrasesBuyer", Gif = "in_which_store_can_i_find_this_product.gif", Icon = "" },
            new SignModel() { Name = "Can I buy this in pieces", Category = "PhrasesBuyer", Gif = "can_i_buy_this_in_pieces.gif", Icon = "" },
            new SignModel() { Name = "Do you have another size for this", Category = "PhrasesBuyer", Gif = "do_you_have_another_size_for_this.gif", Icon = "" },
            new SignModel() { Name = "Is this product fresh or new", Category = "PhrasesBuyer", Gif = "is_this_product_fresh_or_new.gif", Icon = "" },
            new SignModel() { Name = "How much is this per kilo", Category = "PhrasesBuyer", Gif = "how_much_is_this_per_kilo.gif", Icon = "" },
            new SignModel() { Name = "This is too expensive. Can you lower the price a little bit", Category = "PhrasesBuyer", Gif = "this_is_too_expensive_can_you_lower_the_price_a_little_bit.gif", Icon = "" },
            new SignModel() { Name = "Can you please put the things that bough inside the ecobag", Category = "PhrasesBuyer", Gif = "can_you_please_put_the_things_that_i_bougth_inside_the_ecobag.gif", Icon = "" },
            new SignModel() { Name = "How much does this product cost", Category = "PhrasesBuyer", Gif = "how_much_does_this_prodcut_cost.gif", Icon = "" },

        };
    }
}
