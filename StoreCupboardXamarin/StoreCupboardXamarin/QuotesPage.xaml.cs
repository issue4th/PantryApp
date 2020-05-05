using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoreCupboardXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        private readonly string[] _quotes = { "First quote", "Second quote", "Third quote" };
        private int _quoteIndex = 0;

        public QuotesPage()
        {
            InitializeComponent();
        }

        internal void OnNextQuote(object sender, EventArgs e)
        {
            Quote.Text = GetNextQuote();
        }

        private string GetNextQuote()
            => GetQuote(_quoteIndex++);

        private string GetQuote(int quoteIndex)
            => _quotes[quoteIndex % _quotes.Length];
    }
}