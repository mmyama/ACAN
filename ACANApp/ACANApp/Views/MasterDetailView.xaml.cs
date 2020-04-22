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
    public partial class MasterDetailView : MasterDetailPage
    {
        public MasterDetailView()
        {
            InitializeComponent();
            Detail = new NavigationPage(new PageInicio());
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailViewMasterMenuItem;
            if (item == null)
                return;

            switch (item.Id)
            {
                case 0:
                    Detail = new NavigationPage(new PageInicio());
                    break;
                case 1:
                    Detail = new NavigationPage(new PageAikido());
                    break;
                case 2:
                    Detail = new NavigationPage(new PageCultura());
                    break;
                case 3:
                    Detail = new NavigationPage(new PageNossoDojo());
                    break;
                case 4:
                    Detail = new NavigationPage(new PageFundador());
                    break;
                case 5:
                    Detail = new NavigationPage(new PageKawai());
                    break;
                case 6:
                    Detail = new NavigationPage(new PageCadastro());
                    break;
                case 7:
                    Detail = new NavigationPage(new PageContato());
                    break;
                default:
                    break;
            }


            IsPresented = false;
            MasterPage.ListView.SelectedItem = null;
        }
    }
}