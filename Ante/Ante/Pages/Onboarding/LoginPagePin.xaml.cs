using Ante.ViewModels.Onboarding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ante.Pages.Onboarding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPagePin : ContentPage
    {
        private readonly LoginPageViewModel _loginPageViewModel;
        string pin;
        public LoginPagePin(LoginPageViewModel loginPageViewModel)
        {
            InitializeComponent();
            pin = string.Empty;
            PinOne.Focus();
            BindingContext = _loginPageViewModel = loginPageViewModel;
        }

        private void PinOne_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PinOne.Text.Length > 0)
            {
                pin += PinOne.Text;
                PinTwo.Focus();
            }
            else
                PinOne.Focus();
        }
        private void PinTwo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PinTwo.Text.Length > 0)
            {
                pin += PinTwo.Text;
                PinThree.Focus();
            }
            else
                PinOne.Focus();
        }
        private void PinThree_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PinThree.Text.Length > 0)
            {
                pin += PinThree.Text;
                PinFour.Focus();
            }
            else
                PinTwo.Focus();
        }
        private void PinFour_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PinFour.Text.Length > 0 && !string.IsNullOrEmpty(PinThree.Text) && !string.IsNullOrEmpty(PinTwo.Text) && !string.IsNullOrEmpty(PinOne.Text))
            {
                pin += PinFour.Text;
                _loginPageViewModel.PinLogin(pin);
                PinFour.Focus();
            }
            else
            {
                PinThree.Focus();
            }
        }
    }
}