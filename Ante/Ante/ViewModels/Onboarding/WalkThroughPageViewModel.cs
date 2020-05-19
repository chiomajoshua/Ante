using Ante.Models;
using Ante.Pages.Onboarding;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ante.ViewModels.Onboarding
{
    public class WalkThroughPageViewModel : BaseViewModel
    {
        public WalkThroughPageViewModel()
        {
            Items = new List<SliderItem> {
                new SliderItem{ Title = "", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", ImagePath = "WalkThroughOne.png" },
                new SliderItem{ Title = "", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", ImagePath = "WalkThroughTwo.png" },
                new SliderItem{ Title = "", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", ImagePath = "WalkThroughThree.png" }
            };
        }


        public List<Models.SliderItem> Items
        {
            get;
            set;
        }


        public ICommand GetStartedCommand => new Command(() =>
        {
            PushPageAsync(new LoginPage());

        });
    }
}