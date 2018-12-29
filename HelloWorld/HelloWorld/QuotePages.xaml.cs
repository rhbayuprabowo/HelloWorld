using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotePages : ContentPage
	{
        int index = 0;
        string[] quotes = { "Don't cry because it's over, smile because it happened.",
                            "Be yourself; everyone else is already taken.",
                            "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.",
                            "So many books, so little time.",
                            "A room without books is like a body without a soul."};

		public QuotePages ()
		{
			InitializeComponent ();
            lbl_quote.Text = quotes[index];
		}

        private void Btn_quote_Pressed(object sender, EventArgs e)
        {
            index = get_index(index);
            lbl_quote.Text = quotes[index];
        }

        private int get_index(int old_index)
        {
            if (++old_index >= 5)
            {
                return 0;
            }
            return ++old_index;
        }
    }
}