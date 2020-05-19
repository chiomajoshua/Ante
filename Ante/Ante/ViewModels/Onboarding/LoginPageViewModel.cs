using Ante.Models;
using Ante.Pages;
using Ante.Pages.Onboarding;
using Ante.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ante.ViewModels.Onboarding
{
    public class LoginPageViewModel : BaseViewModel
    {
        public LoginPageViewModel()
        {
            Init();
        }
        public string Email
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string Password
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string Pin
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public List<Country> Countries
        {
            get;
            set;
        }

        public Country _country;

        public Country SelectedCountry
        {
            get
            {
                return _country;
            }
            set
            {
                SetProperty(ref _country, value);
            }
        }



        private void VerifyEmail()
        {
            if (string.IsNullOrEmpty(Email))
            {
                StatusDialog.Show(StatusDialogType.Info, "CAUTION", "Please provide your registered email", "Ok", null);
                return;
            }            
        }

        public void PinLogin(string Pin=null)
        {
            if(string.IsNullOrEmpty(Pin))
            {
                StatusDialog.Show(StatusDialogType.Info, "CAUTION", "Please provide your pin", "Ok", null);
                return;
            }
            if (Xamarin.Essentials.Connectivity.NetworkAccess != Xamarin.Essentials.NetworkAccess.Internet)
            {
                StatusDialog.Show(StatusDialogType.Info, "CAUTION", "No Network Access", "Ok", null);
                return;
            }
            else
            {
                StatusDialog.Show(StatusDialogType.Success, "SUCCESS", "Welcome, User! Login Successful", "Ok", null);
            }
        }

        private void PasswordLogin()
        {
            if (Xamarin.Essentials.Connectivity.NetworkAccess != Xamarin.Essentials.NetworkAccess.Internet)
            {
                StatusDialog.Show(StatusDialogType.Info, "CAUTION", "No Network Access", "Ok", null);
                return;
            }
            else
            {
                StatusDialog.Show(StatusDialogType.Success, "SUCCESS", "Welcome, User! Login Successful", "Ok", null);
            }
        }

        private async void Init()
        {
            try
            {
                Countries = PickerService.GetCountries().OrderBy(c => c.name).ToList();                
            }
            catch(Exception ce)
            {
                throw ce;
            }
        }

        public ICommand ForgotPasswordPageCommand => new Command(() =>
        {
            PushPageAsync(new ForgotPasswordPage());
        });

        public ICommand RecipientLoginPageCommand => new Command(() =>
        {
            PushPageAsync(new RecipientLoginPage());
        });

        public ICommand PinLoginPageCommand => new Command(() =>
        {
            PushPageAsync(new LoginPagePin(new LoginPageViewModel()));
        });

        public ICommand PasswordLoginPageCommand => new Command(() =>
        {
            PushPageAsync(new LoginPasswordPage());
        });

        public ICommand LoginPageCommand => new Command(PasswordLogin);

        public ICommand VerifyEmailPageCommand => new Command(VerifyEmail);
    }
}