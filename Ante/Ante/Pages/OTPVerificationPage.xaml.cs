using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ante.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OTPVerificationPage : ContentPage
    {
        public OTPVerificationPage()
        {
            InitializeComponent();            
        }

        private void PinOne_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PinOne.Text.Length > 0)
                PinTwo.Focus();
        }
        private void PinTwo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PinTwo.Text.Length > 0)
                PinThree.Focus();
            else
                PinOne.Focus();
        }
        private void PinThree_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PinThree.Text.Length > 0)
                PinFour.Focus();
            else
                PinTwo.Focus();
        }
        private void PinFour_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PinFour.Text.Length > 0)
                PinFour.Focus();
            else
                PinThree.Focus();
        }
    }
}