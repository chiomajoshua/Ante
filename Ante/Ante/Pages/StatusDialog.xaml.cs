using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
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
    public partial class StatusDialog : PopupPage
    {
        public StatusDialog(StatusDialogType type, string titleVal, string msgVal, string btn1Text, Action btn1Ac, string btn2Text, Action btn2Ac, string btn3Text, Action btn3Ac)
        {
            InitializeComponent();
            title.Text = titleVal;
            msg.Text = msgVal.Count() > 300 ? "An error occured." : msgVal;

            if (!string.IsNullOrEmpty(btn1Text))
            {
                btn1.Text = btn1Text;
                btn1.Clicked += (a, b) =>
                {
                    Navigation.PopPopupAsync();
                    btn1Ac?.Invoke();
                };
            }
            else btn1.IsVisible = false;


            if (!string.IsNullOrEmpty(btn2Text))
            {
                btn2.Text = btn2Text;
                btn2.Clicked += (a, b) =>
                {
                    Navigation.PopPopupAsync();
                    btn2Ac?.Invoke();
                };
            }
            else btn2.IsVisible = false;


            btn2.Text = btn2Text;

            if (!string.IsNullOrEmpty(btn3Text))
            {
                btn3.Text = btn3Text;
                btn3.Clicked += (a, b) =>
                {
                    Navigation.PopPopupAsync();
                    btn3Ac?.Invoke();
                };
            }
            else btn3.IsVisible = false;
            switch (type)
            {
                case StatusDialogType.Success:
                    gifimg.Source = "success_icon_gif.gif";
                    gifimg.LoadingPlaceholder = "success_icon_gif.gif";
                    break;
                case StatusDialogType.Info:
                    gifimg.Source = "info_icon_gif.gif";
                    gifimg.LoadingPlaceholder = "info_icon_gif.gif";
                    break;
                case StatusDialogType.Error:
                    gifimg.Source = "info_icon_gif.gif";
                    gifimg.LoadingPlaceholder = "info_icon_gif.gif";
                    break;
                default:
                    break;
            }
        }

        public static void Show(StatusDialogType type, string title, string msg, string btn1Text, Action btn1)
        {
            StatusDialog bd = new StatusDialog(type, title, msg, btn1Text, btn1, null, null, null, null);

            App.Current.MainPage.Navigation.PushPopupAsync(bd);
        }



        public static void Show(StatusDialogType type, string title, string msg, string btn1Text, Action btn1, string btn2Text, Action btn2)
        {
            StatusDialog bd = new StatusDialog(type, title, msg, btn1Text, btn1, btn2Text, btn2, null, null);

            App.Current.MainPage.Navigation.PushPopupAsync(bd);
        }

        public static void Show(StatusDialogType type, string title, string msg, string btn1Text, Action btn1, string btn2Text, Action btn2, string btn3Text, Action btn3)
        {
            StatusDialog bd = new StatusDialog(type, title, msg, btn1Text, btn1, btn2Text, btn2, btn3Text, btn3);

            App.Current.MainPage.Navigation.PushPopupAsync(bd);
        }

    }

    public enum StatusDialogType
    {
        Success, Info, Error
    }
}