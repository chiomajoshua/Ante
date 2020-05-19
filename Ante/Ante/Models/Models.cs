using System;
using Xamarin.Forms;

namespace Ante.Models
{
    public class SliderItem
    {
        public string Title
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }


        public string ImagePath
        {
            get;
            set;
        }
    }



    public class Step
    {
        public Image Icon { get; set; }
        public Label Title { get; set; }
        public BoxView[] Lines { get; set; }
        public StepType Type { get; set; }
    }


    public enum StepType
    {
        PersonalInfo, Location, Documents, ID, Otp, Password
    }




    public class ApiCallResult<T>
    {
        public T Result
        {
            get;
            set;

        }


        public bool IsSuccessfull
        {
            get;
            set;
        }



        public string Message
        {
            get;
            set;


        }

    }



    public class OnboardCompleteEventArg
    {
        public bool IsSuccesful
        {
            get;
            set;
        }

        public object ExtraValue
        {
            get;
            set;
        }
    }



    public enum OnboardingStatus
    {
        FirstLaunch,
        Started,
        BVNValidated,
        LittleMoreCompleted,
        NextOfKinCompleted,
        PassportPictureUploaded,
        MandateUploaded,
        IDUploaded,
        // IDSkipped,
        UtilityUploaded,

        // UtilitySkipped,
        CustomerRegistered,
        DocumentUploaded,
        OTPValidated,
        PasswordCompleted,
        //PaymentCompleted,
        //SubscriptionCompleted,
        OnboardingCompleted

    }

    public static class Constants
    {
        public const string N0_ACCOUNT_NO = "000000000000000";
        public const string NAIRA_SYMBOL = "₦";
    }


    public class DashboardPageMenuItem
    {
        public string Title
        {
            get;
            set;
        }

        public string Icon
        {
            get;
            set;
        }

        public Func<bool> CanOpen
        {
            get;
            set;
        }

        public Type Page
        {
            get;
            set;
        }

        public object[] Args
        {
            get;
            set;
        }

    }


    public class NewsItem
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }

    public enum GatewayIcon
    {
        MASTER = 1,
        VISA,
        VERVE,
        ZENITH,
        DIAMOND,
        FCMB,
        GTB,
        ACCESS,
        FIDELITY
    }



    public enum CustomerType
    {
        New, Existing, Complete
    }


}