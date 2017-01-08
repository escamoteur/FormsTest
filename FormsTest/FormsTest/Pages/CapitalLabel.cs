using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsTest.Pages
{
    class CapitalEntry : Entry
    {
        public CapitalEntry()
        {
            TextChanged += CapitalEntry_TextChanged;   
        }

        private void CapitalEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Text =   e.NewTextValue.ToUpper();
        }
    }
}
