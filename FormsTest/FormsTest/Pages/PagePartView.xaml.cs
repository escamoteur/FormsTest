using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FormsTest.Pages
{
    public partial class PagePartView : ContentView
    {
        public int MaxLength { get; set; } //Will be accessible as Xaml Attribute

        public PagePartView()
        {
            InitializeComponent();
        }

        //Limit the entry to MaxLength characters 
        private void Entry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length > MaxLength)
                capitalEntry.Text = e.OldTextValue;
        }
    }
}
