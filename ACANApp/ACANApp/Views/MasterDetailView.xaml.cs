using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ACANApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailViewACAN : MasterDetailPage
    {
        public MasterDetailViewACAN()
        {
            InitializeComponent();
            Detail = new NavigationPage(new PageInicio());
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            IsPresented = false;
            MasterPage.ListView.SelectedItem = null;
        }
    }
}