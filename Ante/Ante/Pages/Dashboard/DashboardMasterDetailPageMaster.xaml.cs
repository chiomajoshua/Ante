using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ante.Pages.Dashboard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public DashboardMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new DashboardMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class DashboardMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<DashboardMasterDetailPageMasterMenuItem> MenuItems { get; set; }

            public DashboardMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<DashboardMasterDetailPageMasterMenuItem>(new[]
                {
                    new DashboardMasterDetailPageMasterMenuItem { Id = 0, Title = "Page 1" },
                    new DashboardMasterDetailPageMasterMenuItem { Id = 1, Title = "Page 2" },
                    new DashboardMasterDetailPageMasterMenuItem { Id = 2, Title = "Page 3" },
                    new DashboardMasterDetailPageMasterMenuItem { Id = 3, Title = "Page 4" },
                    new DashboardMasterDetailPageMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}