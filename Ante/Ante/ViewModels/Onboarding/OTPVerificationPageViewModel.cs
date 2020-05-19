using System;
using System.Collections.Generic;
using System.Text;

namespace Ante.ViewModels.Onboarding
{
    public class OTPVerificationPageViewModel : BaseViewModel
    {
        public Func<IList<char>, bool> ValidatorFunc { get; }

        public OTPVerificationPageViewModel()
        {
            ValidatorFunc = (arg) =>
            {
                for (int i = 0; i < arg.Count; ++i)
                {
                    if (arg[i] != ('1' + i))
                    {
                        return false;
                    }
                }
                return true;
            };
        }

        public string PinOne
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string PinTwo
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string PinThree
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string PinFour
        {
            get => GetValue<string>();
            set => SetValue(value);
        }
    }
}
