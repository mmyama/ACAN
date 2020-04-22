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

namespace ACANApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailACANMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailACANMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailACANMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailACANMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailACANMasterMenuItem> MenuItems { get; set; }

            public MasterDetailACANMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailACANMasterMenuItem>(new[]
                {
                    new MasterDetailACANMasterMenuItem { Id = 0, Title = "Page 1" },
                    new MasterDetailACANMasterMenuItem { Id = 1, Title = "Page 2" },
                    new MasterDetailACANMasterMenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailACANMasterMenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailACANMasterMenuItem { Id = 4, Title = "Page 5" },
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