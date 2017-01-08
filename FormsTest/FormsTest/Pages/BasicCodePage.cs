using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsTest.Pages
{
    class BasicCodePage : ContentPage
    {
        public BasicCodePage()
        {
            Content = new Label() {Text = "Hello Forms", HorizontalOptions = LayoutOptions.Center,
                                   VerticalOptions = LayoutOptions.Center};
        }
    }
}
