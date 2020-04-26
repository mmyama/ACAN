using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using ACANApp.ViewModels;

namespace ACANApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContatoView : ContentPage
    {
        public ContatoView()
        {
            InitializeComponent();
            this.BindingContext = new ContatoViewModel();
        }
    }
}