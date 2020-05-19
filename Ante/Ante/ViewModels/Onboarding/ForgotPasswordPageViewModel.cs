using Ante.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ante.ViewModels.Onboarding
{
    public class ForgotPasswordPageViewModel : BaseViewModel
    {
        public ForgotPasswordPageViewModel()
        {

        }
        public string Email
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public ICommand OTPVerifyCommand => new Command(() =>
        {
            PushPageAsync(new OTPVerificationPage());

        });
    }
}
