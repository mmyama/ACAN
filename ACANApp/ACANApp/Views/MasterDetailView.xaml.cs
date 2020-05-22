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
            Detail = new NavigationPage(new InicioView());
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
                    Detail = new NavigationPage(new InicioView());
                    break;
                case 1:
                    Detail = new NavigationPage(new AikidoView());
                    break;
                case 2:
                    Detail = new NavigationPage(new CulturaView());
                    break;
                case 3:
                    Detail = new NavigationPage(new NossoDojoView());
                    break;
                case 4:
                    Detail = new NavigationPage(new FundadorView());
                    break;
                case 5:
                    Detail = new NavigationPage(new KawaiView());
                    break;
                case 6:
                    Detail = new NavigationPage(new BlogView());
                    
                    break;
                case 7:
                    Detail = new NavigationPage(new CadastroView());
                    break;
                case 8:
                    Detail = new NavigationPage(new ContatoView());
                    break;
                default:
                    break;
            }


            IsPresented = false;
            MasterPage.ListView.SelectedItem = null;
        }
    }
}