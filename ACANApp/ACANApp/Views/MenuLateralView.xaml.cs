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
    public partial class MenuLateralView : ContentPage
    {
        public ListView ListView;

        public MenuLateralView()
        {
            InitializeComponent();

            BindingContext = new MasterDetailACANMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailACANMasterViewModel
        {
            public ObservableCollection<MasterDetailViewMasterMenuItem> MenuItems { get; set; }

            public MasterDetailACANMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailViewMasterMenuItem>(new[]
                {
                    new MasterDetailViewMasterMenuItem { Id = 0, Title = "Início" },
                    new MasterDetailViewMasterMenuItem { Id = 1, Title = "Aikido" },
                    new MasterDetailViewMasterMenuItem { Id = 2, Title = "Cultura" },
                    new MasterDetailViewMasterMenuItem { Id = 3, Title = "Nosso Dojo" },
                    new MasterDetailViewMasterMenuItem { Id = 4, Title = "História do Aikido" },
                    new MasterDetailViewMasterMenuItem { Id = 5, Title = "Aikido no Brasil" },
                    new MasterDetailViewMasterMenuItem { Id = 6, Title = "Blog" },
                    new MasterDetailViewMasterMenuItem { Id = 7, Title = "Envio de Documentos" },
                    new MasterDetailViewMasterMenuItem { Id = 8, Title = "Contato" },
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