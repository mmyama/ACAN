using ACANApp.Models;
using ACANApp.ViewModels;
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
    public partial class InicioView : ContentPage
    {
        /*
         * Falta:   - Banner superior móvel (carousel??)
         *          - ícones com links para redes sociais
         */
        public InicioView()
        {
            InitializeComponent();
            this.BindingContext = new InicioViewModel();
        }

        void ListView_OnItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var selectedItem = (RssData)e.Item;
            Navigation.PushAsync(new WebView(selectedItem.Link));
        }

    }
}